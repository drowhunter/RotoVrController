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
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            btnStopSound = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnPlaySound = new MaterialSkin.Controls.MaterialButton();
            sliderRumblePower = new MaterialSkin.Controls.MaterialSlider();
            cmbSoundFile = new MaterialSkin.Controls.MaterialComboBox();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            tabControl.SuspendLayout();
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
            materialCard1.Location = new Point(19, 104);
            materialCard1.Margin = new Padding(16, 19, 16, 19);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16, 19, 16, 19);
            materialCard1.Size = new Size(875, 216);
            materialCard1.TabIndex = 0;
            materialCard1.Paint += materialCard1_Paint;
            // 
            // lblCockpitDegree
            // 
            lblCockpitDegree.AutoSize = true;
            lblCockpitDegree.Depth = 0;
            lblCockpitDegree.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCockpitDegree.Location = new Point(624, 159);
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
            lblMaxPower.Location = new Point(624, 108);
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
            lblConnection.Location = new Point(734, 19);
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
            lblMode.Location = new Point(393, 108);
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
            lblFirmwareVer.Location = new Point(393, 159);
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
            lblHTDegree.Location = new Point(51, 159);
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
            lblBaseDegree.Location = new Point(51, 108);
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
            btnDisconnect.Location = new Point(393, 27);
            btnDisconnect.Margin = new Padding(5, 8, 5, 8);
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
            btnConnect.Location = new Point(51, 27);
            btnConnect.Margin = new Padding(5, 8, 5, 8);
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
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Depth = 0;
            tabControl.Font = new Font("Microsoft JhengHei UI", 12F);
            tabControl.Location = new Point(19, 23);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(827, 249);
            tabControl.TabIndex = 1;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(btnSetZero);
            tabPage1.Controls.Add(sliderBaseAngle);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(819, 211);
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
            btnSetZero.Location = new Point(70, 31);
            btnSetZero.Margin = new Padding(5, 8, 5, 8);
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
            sliderBaseAngle.Location = new Point(70, 124);
            sliderBaseAngle.Margin = new Padding(3, 4, 3, 4);
            sliderBaseAngle.MouseState = MaterialSkin.MouseState.HOVER;
            sliderBaseAngle.Name = "sliderBaseAngle";
            sliderBaseAngle.RangeMax = 359;
            sliderBaseAngle.Size = new Size(667, 40);
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
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(819, 211);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "FREE";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sliderSpeed
            // 
            sliderSpeed.Depth = 0;
            sliderSpeed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderSpeed.Location = new Point(83, 119);
            sliderSpeed.Margin = new Padding(3, 4, 3, 4);
            sliderSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            sliderSpeed.Name = "sliderSpeed";
            sliderSpeed.Size = new Size(667, 40);
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
            btnFreeRight.Location = new Point(237, 39);
            btnFreeRight.Margin = new Padding(5, 8, 5, 8);
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
            btnFreeLeft.Location = new Point(83, 39);
            btnFreeLeft.Margin = new Padding(5, 8, 5, 8);
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
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(819, 211);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "COCKPIT";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // sliderCockpitSpeed
            // 
            sliderCockpitSpeed.Depth = 0;
            sliderCockpitSpeed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sliderCockpitSpeed.Location = new Point(83, 119);
            sliderCockpitSpeed.Margin = new Padding(3, 4, 3, 4);
            sliderCockpitSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            sliderCockpitSpeed.Name = "sliderCockpitSpeed";
            sliderCockpitSpeed.Size = new Size(667, 40);
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
            btnCockpitRight.Location = new Point(237, 39);
            btnCockpitRight.Margin = new Padding(5, 8, 5, 8);
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
            btnCockpitLeft.Location = new Point(83, 39);
            btnCockpitLeft.Margin = new Padding(5, 8, 5, 8);
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
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = tabControl;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(19, 344);
            materialTabSelector1.Margin = new Padding(3, 4, 3, 4);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(875, 64);
            materialTabSelector1.TabIndex = 2;
            materialTabSelector1.Text = "materialTabSelector1";
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
            materialCard2.Location = new Point(19, 736);
            materialCard2.Margin = new Padding(16, 19, 16, 19);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16, 19, 16, 19);
            materialCard2.Size = new Size(866, 188);
            materialCard2.TabIndex = 3;
            // 
            // btnStopSound
            // 
            btnStopSound.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStopSound.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnStopSound.Depth = 0;
            btnStopSound.HighEmphasis = true;
            btnStopSound.Icon = null;
            btnStopSound.Location = new Point(767, 36);
            btnStopSound.Margin = new Padding(5, 8, 5, 8);
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
            materialLabel1.Location = new Point(90, 49);
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
            btnPlaySound.Location = new Point(667, 36);
            btnPlaySound.Margin = new Padding(5, 8, 5, 8);
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
            sliderRumblePower.Location = new Point(90, 112);
            sliderRumblePower.Margin = new Padding(3, 4, 3, 4);
            sliderRumblePower.MouseState = MaterialSkin.MouseState.HOVER;
            sliderRumblePower.Name = "sliderRumblePower";
            sliderRumblePower.Size = new Size(667, 40);
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
            cmbSoundFile.Location = new Point(237, 23);
            cmbSoundFile.Margin = new Padding(3, 4, 3, 4);
            cmbSoundFile.MaxDropDownItems = 4;
            cmbSoundFile.MouseState = MaterialSkin.MouseState.OUT;
            cmbSoundFile.Name = "cmbSoundFile";
            cmbSoundFile.Size = new Size(406, 49);
            cmbSoundFile.StartIndex = 0;
            cmbSoundFile.TabIndex = 0;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(tabControl);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(19, 419);
            materialCard3.Margin = new Padding(16, 19, 16, 19);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(16, 19, 16, 19);
            materialCard3.Size = new Size(866, 299);
            materialCard3.TabIndex = 4;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(19, 943);
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
            materialLabel3.Location = new Point(19, 980);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(454, 19);
            materialLabel3.TabIndex = 6;
            materialLabel3.Text = "Press  keyboard key (A / S) to play or stop the selected audio file";
            // 
            // RotoMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 1095);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Controls.Add(materialTabSelector1);
            Controls.Add(materialCard1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "RotoMainForm";
            Padding = new Padding(3, 85, 3, 4);
            Sizable = false;
            Text = "rotoVR  Window Control V1.0";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
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
    }
}