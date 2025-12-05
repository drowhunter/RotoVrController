namespace rotoVRController
{
    partial class RotoMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblCockpitDegree = new MaterialSkin.Controls.MaterialLabel();
            lblMaxPower = new MaterialSkin.Controls.MaterialLabel();
            lblConnection = new MaterialSkin.Controls.MaterialLabel();
            lblMode = new MaterialSkin.Controls.MaterialLabel();
            lblFirmwareVer = new MaterialSkin.Controls.MaterialLabel();
            lblHTDegree = new MaterialSkin.Controls.MaterialLabel();
            lblBaseDegree = new MaterialSkin.Controls.MaterialLabel();
            btnDisconnect = new MaterialSkin.Controls.MaterialButton();
            btnConnect = new MaterialSkin.Controls.MaterialButton();
            tabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPage4 = new TabPage();
            lblIdleDescription = new MaterialSkin.Controls.MaterialLabel();
            tabPage1 = new TabPage();
            btnSetZero = new MaterialSkin.Controls.MaterialButton();
            sliderBaseAngle = new MaterialSkin.Controls.MaterialSlider();
            tabPage2 = new TabPage();
            sliderSpeed = new MaterialSkin.Controls.MaterialSlider();
            btnFreeRight = new MaterialSkin.Controls.MaterialButton();
            btnFreeLeft = new MaterialSkin.Controls.MaterialButton();
            tabPage3 = new TabPage();
            sliderCockpitSpeed = new MaterialSkin.Controls.MaterialSlider();
            btnCockpitRight = new MaterialSkin.Controls.MaterialButton();
            btnCockpitLeft = new MaterialSkin.Controls.MaterialButton();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnStopSound = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnPlaySound = new MaterialSkin.Controls.MaterialButton();
            sliderRumblePower = new MaterialSkin.Controls.MaterialSlider();
            cmbSoundFile = new MaterialSkin.Controls.MaterialComboBox();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            cbxEnableModeSound = new MaterialSkin.Controls.MaterialCheckbox();
            cbxEnableResume = new MaterialSkin.Controls.MaterialCheckbox();
            lbSetMode = new MaterialSkin.Controls.MaterialLabel();
            btnCockpit = new MaterialSkin.Controls.MaterialButton();
            btnObjectFollow = new MaterialSkin.Controls.MaterialButton();
            btnFree = new MaterialSkin.Controls.MaterialButton();
            btnIdle = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblCockpitDegree);
            materialCard1.Controls.Add(lblMaxPower);
            materialCard1.Controls.Add(lblConnection);
            materialCard1.Controls.Add(lblMode);
            materialCard1.Controls.Add(lblFirmwareVer);
            materialCard1.Controls.Add(lblHTDegree);
            materialCard1.Controls.Add(lblBaseDegree);
            materialCard1.Controls.Add(btnDisconnect);
            materialCard1.Controls.Add(btnConnect);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(780, 162);
            materialCard1.TabIndex = 0;
            // 
            // lblCockpitDegree
            // 
            lblCockpitDegree.AutoSize = true;
            lblCockpitDegree.Depth = 0;
            lblCockpitDegree.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCockpitDegree.Location = new Point(546, 119);
            lblCockpitDegree.MouseState = MaterialSkin.MouseState.HOVER;
            lblCockpitDegree.Name = "lblCockpitDegree";
            lblCockpitDegree.Size = new Size(102, 19);
            lblCockpitDegree.TabIndex = 7;
            lblCockpitDegree.Text = "Cockpit Angle:";
            // 
            // lblMaxPower
            // 
            lblMaxPower.AutoSize = true;
            lblMaxPower.Depth = 0;
            lblMaxPower.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMaxPower.Location = new Point(546, 81);
            lblMaxPower.MouseState = MaterialSkin.MouseState.HOVER;
            lblMaxPower.Name = "lblMaxPower";
            lblMaxPower.Size = new Size(84, 19);
            lblMaxPower.TabIndex = 6;
            lblMaxPower.Text = "Max Power:";
            // 
            // lblConnection
            // 
            lblConnection.AutoSize = true;
            lblConnection.Depth = 0;
            lblConnection.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblConnection.Location = new Point(642, 14);
            lblConnection.MouseState = MaterialSkin.MouseState.HOVER;
            lblConnection.Name = "lblConnection";
            lblConnection.Size = new Size(31, 19);
            lblConnection.TabIndex = 5;
            lblConnection.Text = "USB";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Depth = 0;
            lblMode.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblMode.Location = new Point(344, 81);
            lblMode.MouseState = MaterialSkin.MouseState.HOVER;
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(45, 19);
            lblMode.TabIndex = 5;
            lblMode.Text = "Mode:";
            // 
            // lblFirmwareVer
            // 
            lblFirmwareVer.AutoSize = true;
            lblFirmwareVer.Depth = 0;
            lblFirmwareVer.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFirmwareVer.Location = new Point(344, 119);
            lblFirmwareVer.MouseState = MaterialSkin.MouseState.HOVER;
            lblFirmwareVer.Name = "lblFirmwareVer";
            lblFirmwareVer.Size = new Size(98, 19);
            lblFirmwareVer.TabIndex = 4;
            lblFirmwareVer.Text = "Firmware Ver:";
            // 
            // lblHTDegree
            // 
            lblHTDegree.AutoSize = true;
            lblHTDegree.Depth = 0;
            lblHTDegree.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblHTDegree.Location = new Point(45, 119);
            lblHTDegree.MouseState = MaterialSkin.MouseState.HOVER;
            lblHTDegree.Name = "lblHTDegree";
            lblHTDegree.Size = new Size(161, 19);
            lblHTDegree.TabIndex = 3;
            lblHTDegree.Text = "Headtracker Compass:";
            // 
            // lblBaseDegree
            // 
            lblBaseDegree.AutoSize = true;
            lblBaseDegree.Depth = 0;
            lblBaseDegree.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBaseDegree.Location = new Point(45, 81);
            lblBaseDegree.MouseState = MaterialSkin.MouseState.HOVER;
            lblBaseDegree.Name = "lblBaseDegree";
            lblBaseDegree.Size = new Size(93, 19);
            lblBaseDegree.TabIndex = 2;
            lblBaseDegree.Text = "Base Degree:";
            // 
            // btnDisconnect
            // 
            btnDisconnect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDisconnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDisconnect.Depth = 0;
            btnDisconnect.HighEmphasis = true;
            btnDisconnect.Icon = null;
            btnDisconnect.Location = new Point(344, 20);
            btnDisconnect.Margin = new Padding(4, 6, 4, 6);
            btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.NoAccentTextColor = Color.Empty;
            btnDisconnect.Size = new Size(112, 36);
            btnDisconnect.TabIndex = 1;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDisconnect.UseAccentColor = false;
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConnect.Depth = 0;
            btnConnect.HighEmphasis = true;
            btnConnect.Icon = null;
            btnConnect.Location = new Point(45, 20);
            btnConnect.Margin = new Padding(4, 6, 4, 6);
            btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            btnConnect.Name = "btnConnect";
            btnConnect.NoAccentTextColor = Color.Empty;
            btnConnect.Size = new Size(89, 36);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConnect.UseAccentColor = false;
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Depth = 0;
            tabControl.Font = new Font("Microsoft JhengHei UI", 12F);
            tabControl.Location = new Point(21, 159);
            tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(724, 187);
            tabControl.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lblIdleDescription);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(716, 154);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "IDLE";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblIdleDescription
            // 
            lblIdleDescription.AutoSize = true;
            lblIdleDescription.Depth = 0;
            lblIdleDescription.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblIdleDescription.Location = new Point(241, 63);
            lblIdleDescription.MouseState = MaterialSkin.MouseState.HOVER;
            lblIdleDescription.Name = "lblIdleDescription";
            lblIdleDescription.Size = new Size(182, 19);
            lblIdleDescription.TabIndex = 7;
            lblIdleDescription.Text = "BASE is in standby mode.";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(btnSetZero);
            tabPage1.Controls.Add(sliderBaseAngle);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(716, 154);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "OBJECT FOLLOW";
            // 
            // btnSetZero
            // 
            btnSetZero.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSetZero.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSetZero.Depth = 0;
            btnSetZero.HighEmphasis = true;
            btnSetZero.Icon = null;
            btnSetZero.Location = new Point(61, 23);
            btnSetZero.Margin = new Padding(4, 6, 4, 6);
            btnSetZero.MouseState = MaterialSkin.MouseState.HOVER;
            btnSetZero.Name = "btnSetZero";
            btnSetZero.NoAccentTextColor = Color.Empty;
            btnSetZero.Size = new Size(180, 36);
            btnSetZero.TabIndex = 3;
            btnSetZero.Text = "Set Base Degree to 0";
            btnSetZero.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSetZero.UseAccentColor = false;
            btnSetZero.UseVisualStyleBackColor = true;
            btnSetZero.Click += btnSetZero_Click;
            // 
            // sliderBaseAngle
            // 
            sliderBaseAngle.Depth = 0;
            sliderBaseAngle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderBaseAngle.Location = new Point(61, 93);
            sliderBaseAngle.MouseState = MaterialSkin.MouseState.HOVER;
            sliderBaseAngle.Name = "sliderBaseAngle";
            sliderBaseAngle.RangeMax = 359;
            sliderBaseAngle.Size = new Size(584, 40);
            sliderBaseAngle.TabIndex = 2;
            sliderBaseAngle.Text = "Base Angle";
            sliderBaseAngle.Value = 0;
            sliderBaseAngle.ValueMax = 359;
            sliderBaseAngle.onValueChanged += sliderBaseAngle_onValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(sliderSpeed);
            tabPage2.Controls.Add(btnFreeRight);
            tabPage2.Controls.Add(btnFreeLeft);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(716, 154);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "FREE";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sliderSpeed
            // 
            sliderSpeed.Depth = 0;
            sliderSpeed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderSpeed.Location = new Point(73, 89);
            sliderSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            sliderSpeed.Name = "sliderSpeed";
            sliderSpeed.Size = new Size(584, 40);
            sliderSpeed.TabIndex = 5;
            sliderSpeed.Text = "Speed";
            sliderSpeed.Value = 100;
            sliderSpeed.ValueMax = 100;
            // 
            // btnFreeRight
            // 
            btnFreeRight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFreeRight.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFreeRight.Depth = 0;
            btnFreeRight.HighEmphasis = true;
            btnFreeRight.Icon = null;
            btnFreeRight.Location = new Point(207, 29);
            btnFreeRight.Margin = new Padding(4, 6, 4, 6);
            btnFreeRight.MouseState = MaterialSkin.MouseState.HOVER;
            btnFreeRight.Name = "btnFreeRight";
            btnFreeRight.NoAccentTextColor = Color.Empty;
            btnFreeRight.Size = new Size(100, 36);
            btnFreeRight.TabIndex = 4;
            btnFreeRight.Text = "  Right ( > )";
            btnFreeRight.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFreeRight.UseAccentColor = false;
            btnFreeRight.UseVisualStyleBackColor = true;
            btnFreeRight.Click += btnFreeRight_Click;
            // 
            // btnFreeLeft
            // 
            btnFreeLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFreeLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFreeLeft.Depth = 0;
            btnFreeLeft.HighEmphasis = true;
            btnFreeLeft.Icon = null;
            btnFreeLeft.Location = new Point(73, 29);
            btnFreeLeft.Margin = new Padding(4, 6, 4, 6);
            btnFreeLeft.MouseState = MaterialSkin.MouseState.HOVER;
            btnFreeLeft.Name = "btnFreeLeft";
            btnFreeLeft.NoAccentTextColor = Color.Empty;
            btnFreeLeft.Size = new Size(98, 36);
            btnFreeLeft.TabIndex = 3;
            btnFreeLeft.Text = "   Left  ( < )     ";
            btnFreeLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFreeLeft.UseAccentColor = false;
            btnFreeLeft.UseVisualStyleBackColor = true;
            btnFreeLeft.Click += btnFreeLeft_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(sliderCockpitSpeed);
            tabPage3.Controls.Add(btnCockpitRight);
            tabPage3.Controls.Add(btnCockpitLeft);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(716, 154);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "COCKPIT";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // sliderCockpitSpeed
            // 
            sliderCockpitSpeed.Depth = 0;
            sliderCockpitSpeed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderCockpitSpeed.Location = new Point(73, 89);
            sliderCockpitSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            sliderCockpitSpeed.Name = "sliderCockpitSpeed";
            sliderCockpitSpeed.Size = new Size(584, 40);
            sliderCockpitSpeed.TabIndex = 8;
            sliderCockpitSpeed.Text = "Speed";
            sliderCockpitSpeed.Value = 100;
            sliderCockpitSpeed.ValueMax = 100;
            // 
            // btnCockpitRight
            // 
            btnCockpitRight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCockpitRight.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCockpitRight.Depth = 0;
            btnCockpitRight.HighEmphasis = true;
            btnCockpitRight.Icon = null;
            btnCockpitRight.Location = new Point(207, 29);
            btnCockpitRight.Margin = new Padding(4, 6, 4, 6);
            btnCockpitRight.MouseState = MaterialSkin.MouseState.HOVER;
            btnCockpitRight.Name = "btnCockpitRight";
            btnCockpitRight.NoAccentTextColor = Color.Empty;
            btnCockpitRight.Size = new Size(100, 36);
            btnCockpitRight.TabIndex = 7;
            btnCockpitRight.Text = "  Right ( > )";
            btnCockpitRight.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCockpitRight.UseAccentColor = false;
            btnCockpitRight.UseVisualStyleBackColor = true;
            btnCockpitRight.Click += btnCockpitRight_Click;
            // 
            // btnCockpitLeft
            // 
            btnCockpitLeft.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCockpitLeft.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCockpitLeft.Depth = 0;
            btnCockpitLeft.HighEmphasis = true;
            btnCockpitLeft.Icon = null;
            btnCockpitLeft.Location = new Point(73, 29);
            btnCockpitLeft.Margin = new Padding(4, 6, 4, 6);
            btnCockpitLeft.MouseState = MaterialSkin.MouseState.HOVER;
            btnCockpitLeft.Name = "btnCockpitLeft";
            btnCockpitLeft.NoAccentTextColor = Color.Empty;
            btnCockpitLeft.Size = new Size(98, 36);
            btnCockpitLeft.TabIndex = 6;
            btnCockpitLeft.Text = "   Left  ( < )     ";
            btnCockpitLeft.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCockpitLeft.UseAccentColor = false;
            btnCockpitLeft.UseVisualStyleBackColor = true;
            btnCockpitLeft.Click += btnCockpitLeft_Click;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(btnStopSound);
            materialCard2.Controls.Add(materialLabel1);
            materialCard2.Controls.Add(btnPlaySound);
            materialCard2.Controls.Add(sliderRumblePower);
            materialCard2.Controls.Add(cmbSoundFile);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(17, 641);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(780, 141);
            materialCard2.TabIndex = 3;
            // 
            // btnStopSound
            // 
            btnStopSound.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStopSound.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStopSound.Depth = 0;
            btnStopSound.HighEmphasis = true;
            btnStopSound.Icon = null;
            btnStopSound.Location = new Point(671, 27);
            btnStopSound.Margin = new Padding(4, 6, 4, 6);
            btnStopSound.MouseState = MaterialSkin.MouseState.HOVER;
            btnStopSound.Name = "btnStopSound";
            btnStopSound.NoAccentTextColor = Color.Empty;
            btnStopSound.Size = new Size(81, 36);
            btnStopSound.TabIndex = 12;
            btnStopSound.Text = "Stop (S)";
            btnStopSound.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnStopSound.UseAccentColor = false;
            btnStopSound.UseVisualStyleBackColor = true;
            btnStopSound.Click += btnStopSound_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(79, 37);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(71, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Audio File";
            // 
            // btnPlaySound
            // 
            btnPlaySound.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPlaySound.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnPlaySound.Depth = 0;
            btnPlaySound.HighEmphasis = true;
            btnPlaySound.Icon = null;
            btnPlaySound.Location = new Point(584, 27);
            btnPlaySound.Margin = new Padding(4, 6, 4, 6);
            btnPlaySound.MouseState = MaterialSkin.MouseState.HOVER;
            btnPlaySound.Name = "btnPlaySound";
            btnPlaySound.NoAccentTextColor = Color.Empty;
            btnPlaySound.Size = new Size(81, 36);
            btnPlaySound.TabIndex = 10;
            btnPlaySound.Text = "Play (A)";
            btnPlaySound.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnPlaySound.UseAccentColor = false;
            btnPlaySound.UseVisualStyleBackColor = true;
            btnPlaySound.Click += btnPlaySound_Click;
            // 
            // sliderRumblePower
            // 
            sliderRumblePower.Depth = 0;
            sliderRumblePower.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderRumblePower.Location = new Point(79, 84);
            sliderRumblePower.MouseState = MaterialSkin.MouseState.HOVER;
            sliderRumblePower.Name = "sliderRumblePower";
            sliderRumblePower.Size = new Size(584, 40);
            sliderRumblePower.TabIndex = 9;
            sliderRumblePower.Text = "Rumble Power ";
            sliderRumblePower.Value = 100;
            sliderRumblePower.ValueMax = 100;
            // 
            // cmbSoundFile
            // 
            cmbSoundFile.AutoResize = false;
            cmbSoundFile.BackColor = Color.FromArgb(255, 255, 255);
            cmbSoundFile.Depth = 0;
            cmbSoundFile.DrawMode = DrawMode.OwnerDrawVariable;
            cmbSoundFile.DropDownHeight = 174;
            cmbSoundFile.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSoundFile.DropDownWidth = 121;
            cmbSoundFile.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbSoundFile.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbSoundFile.FormattingEnabled = true;
            cmbSoundFile.IntegralHeight = false;
            cmbSoundFile.ItemHeight = 43;
            cmbSoundFile.Location = new Point(207, 17);
            cmbSoundFile.MaxDropDownItems = 4;
            cmbSoundFile.MouseState = MaterialSkin.MouseState.OUT;
            cmbSoundFile.Name = "cmbSoundFile";
            cmbSoundFile.Size = new Size(356, 49);
            cmbSoundFile.StartIndex = 0;
            cmbSoundFile.TabIndex = 0;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(cbxEnableModeSound);
            materialCard3.Controls.Add(cbxEnableResume);
            materialCard3.Controls.Add(lbSetMode);
            materialCard3.Controls.Add(btnCockpit);
            materialCard3.Controls.Add(btnObjectFollow);
            materialCard3.Controls.Add(btnFree);
            materialCard3.Controls.Add(btnIdle);
            materialCard3.Controls.Add(tabControl);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(17, 257);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(780, 363);
            materialCard3.TabIndex = 4;
            // 
            // cbxEnableModeSound
            // 
            cbxEnableModeSound.AutoSize = true;
            cbxEnableModeSound.Depth = 0;
            cbxEnableModeSound.Location = new Point(21, 110);
            cbxEnableModeSound.Margin = new Padding(0);
            cbxEnableModeSound.MouseLocation = new Point(-1, -1);
            cbxEnableModeSound.MouseState = MaterialSkin.MouseState.HOVER;
            cbxEnableModeSound.Name = "cbxEnableModeSound";
            cbxEnableModeSound.ReadOnly = false;
            cbxEnableModeSound.Ripple = true;
            cbxEnableModeSound.Size = new Size(413, 37);
            cbxEnableModeSound.TabIndex = 17;
            cbxEnableModeSound.Text = "Enable Mode Indication Sound (in next mode change)";
            cbxEnableModeSound.UseVisualStyleBackColor = true;
            cbxEnableModeSound.CheckedChanged += cbxEnableModeSound_CheckedChanged;
            // 
            // cbxEnableResume
            // 
            cbxEnableResume.AutoSize = true;
            cbxEnableResume.Depth = 0;
            cbxEnableResume.Location = new Point(21, 73);
            cbxEnableResume.Margin = new Padding(0);
            cbxEnableResume.MouseLocation = new Point(-1, -1);
            cbxEnableResume.MouseState = MaterialSkin.MouseState.HOVER;
            cbxEnableResume.Name = "cbxEnableResume";
            cbxEnableResume.ReadOnly = false;
            cbxEnableResume.Ripple = true;
            cbxEnableResume.Size = new Size(425, 37);
            cbxEnableResume.TabIndex = 16;
            cbxEnableResume.Text = "Enable Emergency Stop Resume (in next mode change)";
            cbxEnableResume.UseVisualStyleBackColor = true;
            cbxEnableResume.CheckedChanged += cbxEnableResume_CheckedChanged;
            // 
            // lbSetMode
            // 
            lbSetMode.AutoSize = true;
            lbSetMode.Depth = 0;
            lbSetMode.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbSetMode.Location = new Point(25, 30);
            lbSetMode.MouseState = MaterialSkin.MouseState.HOVER;
            lbSetMode.Name = "lbSetMode";
            lbSetMode.Size = new Size(115, 19);
            lbSetMode.TabIndex = 15;
            lbSetMode.Text = "Set BASE Mode:";
            // 
            // btnCockpit
            // 
            btnCockpit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCockpit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCockpit.Depth = 0;
            btnCockpit.HighEmphasis = true;
            btnCockpit.Icon = null;
            btnCockpit.Location = new Point(622, 20);
            btnCockpit.Margin = new Padding(4, 6, 4, 6);
            btnCockpit.MouseState = MaterialSkin.MouseState.HOVER;
            btnCockpit.Name = "btnCockpit";
            btnCockpit.NoAccentTextColor = Color.Empty;
            btnCockpit.Size = new Size(103, 36);
            btnCockpit.TabIndex = 14;
            btnCockpit.Text = "   Cockcpit   ";
            btnCockpit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCockpit.UseAccentColor = false;
            btnCockpit.UseVisualStyleBackColor = true;
            btnCockpit.Click += btnCockpit_Click;
            // 
            // btnObjectFollow
            // 
            btnObjectFollow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnObjectFollow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnObjectFollow.Depth = 0;
            btnObjectFollow.HighEmphasis = true;
            btnObjectFollow.Icon = null;
            btnObjectFollow.Location = new Point(359, 20);
            btnObjectFollow.Margin = new Padding(4, 6, 4, 6);
            btnObjectFollow.MouseState = MaterialSkin.MouseState.HOVER;
            btnObjectFollow.Name = "btnObjectFollow";
            btnObjectFollow.NoAccentTextColor = Color.Empty;
            btnObjectFollow.Size = new Size(137, 36);
            btnObjectFollow.TabIndex = 13;
            btnObjectFollow.Text = "Object Follow";
            btnObjectFollow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnObjectFollow.UseAccentColor = false;
            btnObjectFollow.UseVisualStyleBackColor = true;
            btnObjectFollow.Click += btnObjectFollow_Click;
            // 
            // btnFree
            // 
            btnFree.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFree.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFree.Depth = 0;
            btnFree.HighEmphasis = true;
            btnFree.Icon = null;
            btnFree.Location = new Point(517, 20);
            btnFree.Margin = new Padding(4, 6, 4, 6);
            btnFree.MouseState = MaterialSkin.MouseState.HOVER;
            btnFree.Name = "btnFree";
            btnFree.NoAccentTextColor = Color.Empty;
            btnFree.Size = new Size(88, 36);
            btnFree.TabIndex = 12;
            btnFree.Text = "         FREE          ";
            btnFree.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFree.UseAccentColor = false;
            btnFree.UseVisualStyleBackColor = true;
            btnFree.Click += btnFree_Click;
            // 
            // btnIdle
            // 
            btnIdle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIdle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIdle.Depth = 0;
            btnIdle.HighEmphasis = true;
            btnIdle.Icon = null;
            btnIdle.Location = new Point(262, 20);
            btnIdle.Margin = new Padding(4, 6, 4, 6);
            btnIdle.MouseState = MaterialSkin.MouseState.HOVER;
            btnIdle.Name = "btnIdle";
            btnIdle.NoAccentTextColor = Color.Empty;
            btnIdle.Size = new Size(69, 36);
            btnIdle.TabIndex = 11;
            btnIdle.Text = "     IDLE         ";
            btnIdle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIdle.UseAccentColor = false;
            btnIdle.UseVisualStyleBackColor = true;
            btnIdle.Click += btnIdle_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(17, 796);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(499, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Press  keyboard key  (Left / Right) to move  chair in Free/Cockpit mode";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(17, 824);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(454, 19);
            materialLabel3.TabIndex = 6;
            materialLabel3.Text = "Press  keyboard key (A / S) to play or stop the selected audio file";
            // 
            // RotoMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 867);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RotoMainForm";
            Sizable = false;
            Text = "rotoVR  Window Control V1.1";
            Load += RotoMainForm_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnConnect;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialSlider sliderBaseAngle;
        private MaterialSkin.Controls.MaterialButton btnFreeRight;
        private MaterialSkin.Controls.MaterialButton btnFreeLeft;
        private MaterialSkin.Controls.MaterialButton btnDisconnect;
        private TabPage tabPage3;
        private MaterialSkin.Controls.MaterialSlider sliderSpeed;
        private MaterialSkin.Controls.MaterialSlider sliderCockpitSpeed;
        private MaterialSkin.Controls.MaterialButton btnCockpitRight;
        private MaterialSkin.Controls.MaterialButton btnCockpitLeft;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialSlider sliderRumblePower;
        private MaterialSkin.Controls.MaterialComboBox cmbSoundFile;
        private MaterialSkin.Controls.MaterialButton btnPlaySound;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lblHTDegree;
        private MaterialSkin.Controls.MaterialLabel lblBaseDegree;
        private MaterialSkin.Controls.MaterialLabel lblMode;
        private MaterialSkin.Controls.MaterialLabel lblFirmwareVer;
        private MaterialSkin.Controls.MaterialButton btnSetZero;
        private MaterialSkin.Controls.MaterialButton btnStopSound;
        private MaterialSkin.Controls.MaterialLabel lblConnection;
        private MaterialSkin.Controls.MaterialLabel lblMaxPower;
        private MaterialSkin.Controls.MaterialLabel lblCockpitDegree;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private TabPage tabPage4;
        private MaterialSkin.Controls.MaterialButton btnCockpit;
        private MaterialSkin.Controls.MaterialButton btnObjectFollow;
        private MaterialSkin.Controls.MaterialButton btnFree;
        private MaterialSkin.Controls.MaterialButton btnIdle;
        private MaterialSkin.Controls.MaterialLabel lbSetMode;
        private MaterialSkin.Controls.MaterialLabel lblIdleDescription;
        private MaterialSkin.Controls.MaterialCheckbox cbxEnableModeSound;
        private MaterialSkin.Controls.MaterialCheckbox cbxEnableResume;
    }
}