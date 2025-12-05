/*
 * 
 *  Edward Chan
 * 
 * Revision history:
 * 
 *          V1.1 -   Add  Safety Stop / Emergency Button Event supported and handling
 *               -   Add  RunMode  and Error Mode event handler
 *               -   Add  Idle mode 
 *               
 * 
 */



using MaterialSkin;
using MaterialSkin.Controls;

using rotoUSB;
using System.CodeDom.Compiler;
using System.Reflection.Emit;
using System.Windows.Forms;


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

        // UI update timer
        private System.Windows.Forms.Timer uiTimer;


        // v1.1
        // Declare errorPanel to show error message dialog
        private Panel errorPanel;
        private MaterialLabel errorLabel;
        private bool isErrorRecover = false;


        public void CreateErrorPanel()
        {
            errorPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(128, Color.Black),
                Enabled = true
            };

            var errorCard = new MaterialSkin.Controls.MaterialCard
            {
                Size = new Size(400, 120),
                BackColor = Color.White

            };
            errorCard.Location = new Point(
                (this.ClientSize.Width - errorCard.Width) / 2,
                (this.ClientSize.Height - errorCard.Height) / 2
            );

            /*
            // Override paint to apply custom background
            errorCard.Paint += (s, e) =>
            {
                e.Graphics.Clear(Color.LightPink);  
            };
            */

            // System error icon (use a built-in or custom image)
            PictureBox errorIcon = new PictureBox
            {
                Image = Properties.Resources.tick,   // SystemIcons.Error.ToBitmap(), // uses tick icon
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(48, 48),
                Location = new Point(20, 30)
            };

            errorLabel = new MaterialSkin.Controls.MaterialLabel
            {
                Text = "",
                AutoSize = false,
                Width = 300,
                Height = 60,
                Location = new Point(80, 30)
            };

            errorCard.Controls.Add(errorIcon);
            errorCard.Controls.Add(errorLabel);
            errorPanel.Controls.Add(errorCard);
            this.Controls.Add(errorPanel);
            errorPanel.Visible = false;

        }

        public void ShowError(string message)
        {
            // if (errorPanel != null) return;

            if (errorPanel.InvokeRequired)
            {
                // Executes on the UI thread synchronously.
                errorPanel.Invoke(new Action(() =>
                {
                    errorLabel.Text = message;
                    errorPanel.Visible = true;
                    errorPanel.BringToFront();
                }));
            }
            else
            {
                errorLabel.Text = message;
                errorPanel.Visible = true;
                errorPanel.BringToFront();
            }


        }

        public void CloseError()
        {

            if (errorPanel.InvokeRequired)
            {
                // Executes on the UI thread synchronously.
                errorPanel.Invoke(new Action(() =>
                {
                    errorPanel.Visible = false;
                }));
            }
            else
            {
                errorPanel.Visible = false;
            }

        }



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

            // v1.1
            roto.ErrorModeChanged += Roto_ErrorModeChanged;
            roto.RunModeChanged += Roto_RunModeChanged;


            // Enable the console debug in Visual Studio
            //    : Project -> rotoVRController properties -> Application -> Output Type -> Console Application

            roto.EnableConsoleDebug();
            // this.Text = "rotoVR Window Control V1.1 (Debug Build)";

            this.Text = "rotoVR Window Control V1.1";

            InitBaseUIEvent();
            initRumbleUIEvent();

            CreateErrorPanel();
            cbxEnableModeSound.Checked = true;



        }







        private void Roto_RunModeChanged(int runMode)
        {

            if (this.InvokeRequired)
            {
                // Executes on the UI thread synchronously.
                this.Invoke(new Action(() =>
                {
                    updateModeUI(runMode);
                }));
            }
            else
            {
                updateModeUI(runMode);
            }

        }





        // Error Mode triggered --> pause! ---> untriggered --> resume!
        private void Roto_ErrorModeChanged(int errorMode)
        {

            Console.WriteLine("Error Mode Triggered: " + errorMode.ToString("X"));

            if (errorMode == RotoChair.ERROR_NONE)                     // Resume Normal
            {

                Console.WriteLine("Resume normal ");
                // Before resuming object following, we need to align back the base degre with the object
                // otherwise, the chair will drift immediately.
                if (rotoStatus.RunMode == RotoChair.MODE_OBJECT_FOLLOW)
                {
                    rotoStatus = roto.GetRotoStatus();
                    Console.WriteLine("Try set slider degree back to  " + rotoStatus.BaseDegree);
                    roto.SetObjectFollowDegree((int)rotoStatus.BaseDegree, 100);
                    sliderBaseAngle.Value = (int)rotoStatus.BaseDegree;
                }

                CloseError();

                isErrorRecover = true;
            }
            else if (errorMode == RotoChair.ERROR_EMERGENCY_STOP)      // Emergency stop button triggered
            {
                ShowError("Safety Sensor / Emergency Button has been Triggered");


                Console.WriteLine("Emergency Stop =");
            
                player.StopSound();
                isErrorRecover = false;
            }

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

        }


        private string setConditionText(bool condition, string trueString, string falseString)
        {
            if (condition)
                return trueString;
            else
                return falseString;
        }


        // UI update thread - this simulates Graphic Update Loop
        private void UpdateUI(object sender, EventArgs e)
        {
            string strMode = "";

            // read  the latest roto status from RotoChair 
            rotoStatus = roto.GetRotoStatus();

            // update UI elements
            if (rotoStatus.RunMode == RotoChair.MODE_FREE)
                strMode = "FREE";
            else if (rotoStatus.RunMode == RotoChair.MODE_COCKPIT)
                strMode = "COCKPIT";
            else if (rotoStatus.RunMode == RotoChair.MODE_OBJECT_FOLLOW)
                strMode = "OBJECT FOLLOW";
            else
                strMode = "IDLE";

            lblBaseDegree.Text = "Base Angle(°): " + rotoStatus.BaseDegree.ToString("F2");
            // lblHTDegree.Text = "Headtracker Angle(°): " + rotoStatus.HTDegree;
            lblHTDegree.Text = "";
            lblMode.Text = "Mode: " + strMode;
            lblFirmwareVer.Text = "Firmware Ver: " + rotoStatus.FirmwareVersion;
            lblConnection.Text = setConditionText(rotoStatus.USBConnected, "USB Connected", "");
            lblMaxPower.Text = "Max Power(%): " + rotoStatus.MaxPowerLimit;
            lblCockpitDegree.Text = "Cockpit Angle(°): " + rotoStatus.CockpitDegreeLimit;
        }







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
            // updateChairMode();

            /*
            // For UI Test
            ShowError("Emergency Stop Triggered." + System.Environment.NewLine + "Please release the stop button to resume the chair control .");
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 4000;
            timer.Start();
            timer.Tick += Timer_Tick;
            */
        }

        /*
         private void Timer_Tick(object? sender, EventArgs e)
         {


             CloseError();
         }
      */

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


        private void setChairMode(int runMode)
        {

            // updateModeUI(runMode);
            switch (runMode)
            {
                case RotoChair.MODE_IDLE:
                    roto.SetIdleMode();
                    break;
                case RotoChair.MODE_FREE:
                    roto.SetFreeMode();
                    break;

                case RotoChair.MODE_COCKPIT:
                    roto.SetCockpitMode(cockpitDegreeLimit);
                    break;

                case RotoChair.MODE_OBJECT_FOLLOW:
                    roto.SetObjectFollowMode();
                    break;

            }
        }

        /*
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
        */


        private void btnSetZero_Click(object sender, EventArgs e)
        {
            sliderBaseAngle.Value = 0;
            roto.SetZeroBaseCommand();

        }



        private void sliderBaseAngle_onValueChanged(object sender, int newValue)
        {
            if (rotoStatus.RunMode == RotoChair.MODE_OBJECT_FOLLOW)
            {
                Console.WriteLine("Slider Set OF angle to " + newValue);
                roto.SetObjectFollowDegree(newValue, 100);
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


        private void RotoMainForm_Load(object sender, EventArgs e)
        {

        }


        private void ResetButtonStyles()
        {
            btnIdle.UseAccentColor = false;
            btnFree.UseAccentColor = false;
            btnCockpit.UseAccentColor = false;
            btnObjectFollow.UseAccentColor = false;
        }

        private void updateModeUI(int currentMode)
        {
            ResetButtonStyles();

            switch (currentMode)
            {
                case RotoChair.MODE_IDLE:
                    btnIdle.UseAccentColor = true;
                    tabControl.SelectedIndex = 0;
                    break;
                case RotoChair.MODE_FREE:
                    btnFree.UseAccentColor = true;
                    tabControl.SelectedIndex = 2;
                    break;
                case RotoChair.MODE_COCKPIT:
                    btnCockpit.UseAccentColor = true;
                    tabControl.SelectedIndex = 3;
                    break;
                case RotoChair.MODE_OBJECT_FOLLOW:
                    btnObjectFollow.UseAccentColor = true;
                    tabControl.SelectedIndex = 1;
                    btnSetZero.PerformClick();
                    break;
            }
        }




        private void btnIdle_Click(object sender, EventArgs e)
        {
            //ResetButtonStyles();
            //btnIdle.UseAccentColor = true;
            //tabControl.SelectedIndex = 0;
            setChairMode(RotoChair.MODE_IDLE);
        }


        private void btnFree_Click(object sender, EventArgs e)
        {
            setChairMode(RotoChair.MODE_FREE);
            //updateModeUI(RotoChair.MODE_FREE);
        }


        private void btnObjectFollow_Click(object sender, EventArgs e)
        {
            setChairMode(RotoChair.MODE_OBJECT_FOLLOW);
        }


        private void btnCockpit_Click(object sender, EventArgs e)
        {
            setChairMode(RotoChair.MODE_COCKPIT);
        }



        private void cbxEnableResume_CheckedChanged(object sender, EventArgs e)
        {
            roto.EnableModeResume(cbxEnableResume.Checked);
        }



        private void cbxEnableModeSound_CheckedChanged(object sender, EventArgs e)
        {
            roto.EnableModeSound( cbxEnableModeSound.Checked);
        }
    }
}
