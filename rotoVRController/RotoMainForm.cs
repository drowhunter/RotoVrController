using MaterialSkin;
using MaterialSkin.Controls;

using rotoUSB;


namespace rotoVRController
{
    public partial class RotoMainForm : MaterialForm
    {

        private RotoChair roto = RotoChair.Instance;
        private RotoStatus rotoStatus = null;

        private Thread backgroundThread = null;
        private bool isRunning = false;
        private SoundPlayer player = new SoundPlayer();
        private string[] wavFiles = { };

        private int chairMaxPower = 100;
        private int cockpitDegreeLimit = 60;

        private System.Windows.Forms.Timer delayTimer;
        private int delayMilliseconds = 1000;



        public RotoMainForm()
        {
            InitializeComponent();

            // Initialize MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                 Primary.Blue800, Primary.Blue900,
                 Primary.Blue500, Accent.LightBlue200,
                 TextShade.WHITE);





            roto.LoadUSBLibrary();

            // Enable the console debug in Visual Studio
            //    : Project -> rotoVRController properties -> Application -> Output Type -> Console Application

             roto.EnableConsoleDebug();
             this.Text = "rotoVR Window Control V1.0 (Debug Build)";

            //this.Text = "rotoVR Window Control V1.0";

            InitBaseUIEvent();
            initRumbleUIEvent();



        }





        // process keyboard keys
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                moveLeft();
                Console.WriteLine("left");
            }
            else if (keyData == Keys.Right)
            {
                moveRight();
                Console.WriteLine("right");
            }
            else if (keyData == Keys.A)
            {
                btnPlaySound.PerformClick();
            }
            else if (keyData == Keys.S)
            {
                btnStopSound.PerformClick();
            }

            // prevent other controls from processing the key
            return true;
            // return base.ProcessCmdKey(ref msg, keyData);
        }


        private string setConditionText(bool condition, string trueString, string falseString)
        {
            if (condition)
                return trueString;
            else
                return falseString;
        }


        private RotoStatus? _lastStatus;
        // UI update thread
        private void UpdateUI(object sender, EventArgs e)
        {
            var status = roto.GetRotoStatus();
            if (status == null) return;

            // Only proceed if something changed (simple reference or value diff check)
            if (_lastStatus != null &&
                _lastStatus.RunMode == status.RunMode &&
                Math.Abs(_lastStatus.BaseDegree - status.BaseDegree) < 0.001 &&
                _lastStatus.FirmwareVersion == status.FirmwareVersion &&
                _lastStatus.USBConnected == status.USBConnected &&
                _lastStatus.MaxPowerLimit == status.MaxPowerLimit &&
                _lastStatus.CockpitDegreeLimit == status.CockpitDegreeLimit)
            {
                return;
            }

            var modeText = status.RunMode switch
            {
                RotoChair.MODE_FREE => "FREE",
                RotoChair.MODE_COCKPIT => "COCKPIT",
                RotoChair.MODE_OBJECT_FOLLOW => "OBJECT FOLLOW",
                _ => "IDLE"
            };

            lblBaseDegree.Text      = $"Base Angle(°): {status.BaseDegree:F2}";
            lblHTDegree.Text        = ""; // placeholder
            lblMode.Text            = $"Mode: {modeText}";
            lblFirmwareVer.Text     = $"Firmware Ver: {status.FirmwareVersion}";
            lblConnection.Text      = status.USBConnected ? "USB Connected" : "USB Disconnected";
            lblMaxPower.Text        = $"Max Power(%): {status.MaxPowerLimit}";
            lblCockpitDegree.Text   = $"Cockpit Angle(°): {status.CockpitDegreeLimit}";

            _lastStatus = (RotoStatus)status.Clone(); // assuming Clone implemented
        }

        // UI update timer
        private System.Windows.Forms.Timer uiTimer;



        private void InitBaseUIEvent()
        {

            // update UI timer
            uiTimer = new System.Windows.Forms.Timer();
            uiTimer.Interval = 100;
            uiTimer.Tick += UpdateUI;
            uiTimer.Start();

            // Attach FormClosing event
            this.FormClosing += RotoMainForm_FormClosing;




            this.KeyUp += RotoMainForm_KeyUp;
            this.KeyDown += RotoMainForm_KeyDown;
        }


        private void RotoMainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            Console.WriteLine($"KeyDown code: {e.KeyCode}");
        }

        private void RotoMainForm_KeyUp(object? sender, KeyEventArgs e)
        {
            Console.WriteLine($"KeyUp code: {e.KeyCode}");
        }

        private void RotoMainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {

            Console.WriteLine("Form closing close thread");
            uiTimer.Stop();
            uiTimer.Dispose();

            // Make sure release roto resources and stop debug console at the end of exit code
            roto.Dispose();

        }



        private void initRumbleUIEvent()
        {
            string audioFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "audio");
            if (Directory.Exists(audioFolderPath))
            {
                wavFiles = Directory.GetFiles(audioFolderPath, "*.wav", SearchOption.TopDirectoryOnly);
                foreach (string file in wavFiles)
                {
                    string fileName = Path.GetFileName(file);
                    cmbSoundFile.Items.Add(fileName);
                }
            }
            player.OnAmplitudeChanged += Player_OnAmplitudeChanged;
            cmbSoundFile.SelectedIndex = 0;
        }



        // Connect the roto Chair USB connection, and set the Run mode  according to TabPanel Selected Index      
        private void btnConnect_Click(object sender, EventArgs e)
        {

            roto.Connect();
            updateChairMode();
        }


        // Disconnect the roto Chair USB connection
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            roto.Disconnect();

        }



        // Rumble control
        // change the rumble amplitude according to average sound volume sampled in 100ms period, 
        private void Player_OnAmplitudeChanged(double amplitudeDbm)
        {
            ushort durationMS = 100;
            roto.SetRumble((int)(amplitudeDbm * sliderRumblePower.Value / 100.0), durationMS);
        }


        // play sound 
        private void btnPlaySound_Click(object sender, EventArgs e)
        {
            string soundFile = wavFiles[cmbSoundFile.SelectedIndex];
            player.PlaySound(soundFile);
            Console.WriteLine("Play sound:" + soundFile);
        }


        // stop sound
        private void btnStopSound_Click(object sender, EventArgs e)
        {
            player.StopSound();
            roto.StopRumble();
            Console.WriteLine("Stop sound");
        }



        private void updateChairMode()
        {

            if (tabControl.SelectedIndex == 0)
            {
                sliderBaseAngle.Value = 0;
                roto.SetObjectFollowMode();
            }
            else if (tabControl.SelectedIndex == 1)
            {
                roto.SetFreeMode();
            }
            else if (tabControl.SelectedIndex == 2)
            {
                roto.SetCockpitMode(cockpitDegreeLimit);
            }
        }


        // set the chair running mode
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateChairMode();
        }

        private void btnSetZero_Click(object sender, EventArgs e)
        {
            sliderBaseAngle.Value = 0;
            roto.SetZeroBaseCommand();



        }


        //important: only in Object follow mode, the base angle can be set
        private void sliderBaseAngle_onValueChanged(object sender, int newValue)
        {

            if (rotoStatus != null &&  rotoStatus.RunMode == RotoChair.MODE_OBJECT_FOLLOW)
            {
                Console.WriteLine("Set OF angle to " + newValue);
                roto.SetObjectFollowDegree(newValue);
            }
        }


        private void moveLeft()
        {

            if (rotoStatus.RunMode == RotoChair.MODE_FREE)
                roto.MoveChair(-sliderSpeed.Value);
            else if (rotoStatus.RunMode == RotoChair.MODE_COCKPIT)
                roto.MoveChair(-sliderCockpitSpeed.Value);



        }


        private void moveRight()
        {

            if (rotoStatus.RunMode == RotoChair.MODE_FREE)
                roto.MoveChair(sliderSpeed.Value);
            else if (rotoStatus.RunMode == RotoChair.MODE_COCKPIT)
                roto.MoveChair(sliderCockpitSpeed.Value);



        }


        // Free mode control
        private void btnFreeLeft_Click(object sender, EventArgs e)
        {
            moveLeft();
        }

        private void btnFreeRight_Click(object sender, EventArgs e)
        {

            moveRight();
        }


        // cockpit Mode control

        private void btnCockpitLeft_Click(object sender, EventArgs e)
        {
            moveLeft();
        }

        private void btnCockpitRight_Click(object sender, EventArgs e)
        {
            moveRight();
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
