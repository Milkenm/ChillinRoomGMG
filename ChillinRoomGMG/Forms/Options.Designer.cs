namespace ChillinRoomGMG.Forms
{
	partial class Options
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
			this.panel_background = new System.Windows.Forms.Panel();
			this.titleBar = new ChillinRoomGMG.Controls.PixelTitleBar();
			this.groupBox_general = new System.Windows.Forms.GroupBox();
			this.panel_mineForChillinroom = new System.Windows.Forms.Panel();
			this.pixelCheckBox_mineForChillinroom = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.label_mineForChillinroom = new System.Windows.Forms.Label();
			this.panel_minerInfo = new System.Windows.Forms.Panel();
			this.label_walletAddress = new System.Windows.Forms.Label();
			this.textBox_walletAddress = new System.Windows.Forms.TextBox();
			this.label_minerName = new System.Windows.Forms.Label();
			this.linkLabel_theWhatLink = new System.Windows.Forms.LinkLabel();
			this.textBox_minerName = new System.Windows.Forms.TextBox();
			this.panel_minerSettings = new System.Windows.Forms.Panel();
			this.pixelCheckBox_initializeMinerOnStartup = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.label_initializeMinerOnStartup = new System.Windows.Forms.Label();
			this.pixelCheckBox_terminateOnPause = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.label_terminateOnPause = new System.Windows.Forms.Label();
			this.panel_tray = new System.Windows.Forms.Panel();
			this.pixelCheckBox_closeToTray = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.label_minimizeToTray = new System.Windows.Forms.Label();
			this.pixelCheckBox_minimizeToTray = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.label_closeToTray = new System.Windows.Forms.Label();
			this.panel_sharesNotification = new System.Windows.Forms.Panel();
			this.label_sharesNotification = new System.Windows.Forms.Label();
			this.pixelCheckBox_validShareNotification = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.pixelNumberPicker_validShareNotificationCount = new ChillinRoomGMG.Controls.PixelNumberPicker();
			this.label_validShareNotification = new System.Windows.Forms.Label();
			this.pixelCheckBox_invalidShareNotification = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.pixelNumberPicker_invalidShareNotificationCount = new ChillinRoomGMG.Controls.PixelNumberPicker();
			this.label_invalidShareNotification = new System.Windows.Forms.Label();
			this.groupBox_runOnInactivity = new System.Windows.Forms.GroupBox();
			this.panel_automineDelay = new System.Windows.Forms.Panel();
			this.label_delay = new System.Windows.Forms.Label();
			this.pixelNumberPicker_minutes = new ChillinRoomGMG.Controls.PixelNumberPicker();
			this.comboBox_timeUnit = new System.Windows.Forms.ComboBox();
			this.label_minutes = new System.Windows.Forms.Label();
			this.panel_automineNotifications = new System.Windows.Forms.Panel();
			this.label_automineDesktopNotification = new System.Windows.Forms.Label();
			this.label_automineDisableNotification = new System.Windows.Forms.Label();
			this.pixelCheckBox_automineDisableNotification = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.label_automineEnableNotification = new System.Windows.Forms.Label();
			this.pixelCheckBox_automineEnableNotification = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.pixelSlider_autoMine = new ChillinRoomGMG.Controls.PixelSlider();
			this.panel_buttons = new System.Windows.Forms.Panel();
			this.button_cancel = new System.Windows.Forms.Button();
			this.button_save = new System.Windows.Forms.Button();
			this.panel_background.SuspendLayout();
			this.groupBox_general.SuspendLayout();
			this.panel_mineForChillinroom.SuspendLayout();
			this.panel_minerInfo.SuspendLayout();
			this.panel_minerSettings.SuspendLayout();
			this.panel_tray.SuspendLayout();
			this.panel_sharesNotification.SuspendLayout();
			this.groupBox_runOnInactivity.SuspendLayout();
			this.panel_automineDelay.SuspendLayout();
			this.panel_automineNotifications.SuspendLayout();
			this.panel_buttons.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_background
			// 
			this.panel_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.panel_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_background.Controls.Add(this.titleBar);
			this.panel_background.Controls.Add(this.groupBox_general);
			this.panel_background.Controls.Add(this.groupBox_runOnInactivity);
			this.panel_background.Controls.Add(this.panel_buttons);
			this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_background.Location = new System.Drawing.Point(0, 0);
			this.panel_background.Margin = new System.Windows.Forms.Padding(0);
			this.panel_background.Name = "panel_background";
			this.panel_background.Size = new System.Drawing.Size(755, 491);
			this.panel_background.TabIndex = 0;
			// 
			// titleBar
			// 
			this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Margin = new System.Windows.Forms.Padding(0);
			this.titleBar.Name = "titleBar";
			this.titleBar.ShowMinimizeButton = true;
			this.titleBar.Size = new System.Drawing.Size(753, 22);
			this.titleBar.TabIndex = 0;
			this.titleBar.TitleExtension = "Options";
			// 
			// groupBox_general
			// 
			this.groupBox_general.Controls.Add(this.panel_mineForChillinroom);
			this.groupBox_general.Controls.Add(this.panel_minerInfo);
			this.groupBox_general.Controls.Add(this.panel_minerSettings);
			this.groupBox_general.Controls.Add(this.panel_tray);
			this.groupBox_general.Controls.Add(this.panel_sharesNotification);
			this.groupBox_general.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_general.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_general.Location = new System.Drawing.Point(11, 28);
			this.groupBox_general.Name = "groupBox_general";
			this.groupBox_general.Size = new System.Drawing.Size(731, 295);
			this.groupBox_general.TabIndex = 19;
			this.groupBox_general.TabStop = false;
			this.groupBox_general.Text = "General";
			// 
			// panel_mineForChillinroom
			// 
			this.panel_mineForChillinroom.AutoSize = true;
			this.panel_mineForChillinroom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel_mineForChillinroom.Controls.Add(this.pixelCheckBox_mineForChillinroom);
			this.panel_mineForChillinroom.Controls.Add(this.label_mineForChillinroom);
			this.panel_mineForChillinroom.Location = new System.Drawing.Point(9, 16);
			this.panel_mineForChillinroom.Margin = new System.Windows.Forms.Padding(0);
			this.panel_mineForChillinroom.Name = "panel_mineForChillinroom";
			this.panel_mineForChillinroom.Size = new System.Drawing.Size(151, 20);
			this.panel_mineForChillinroom.TabIndex = 23;
			// 
			// pixelCheckBox_mineForChillinroom
			// 
			this.pixelCheckBox_mineForChillinroom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_mineForChillinroom.BackgroundImage")));
			this.pixelCheckBox_mineForChillinroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_mineForChillinroom.Checked = false;
			this.pixelCheckBox_mineForChillinroom.Location = new System.Drawing.Point(0, 0);
			this.pixelCheckBox_mineForChillinroom.Margin = new System.Windows.Forms.Padding(0);
			this.pixelCheckBox_mineForChillinroom.Name = "pixelCheckBox_mineForChillinroom";
			this.pixelCheckBox_mineForChillinroom.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_mineForChillinroom.TabIndex = 21;
			this.pixelCheckBox_mineForChillinroom.CheckedChanged += new ChillinRoomGMG.Controls.PixelCheckBox.EventDelegate(this.pixelCheckBox_mineForChillinroom_CheckedChanged);
			// 
			// label_mineForChillinroom
			// 
			this.label_mineForChillinroom.AutoSize = true;
			this.label_mineForChillinroom.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mineForChillinroom.ForeColor = System.Drawing.Color.Snow;
			this.label_mineForChillinroom.Location = new System.Drawing.Point(24, 3);
			this.label_mineForChillinroom.Margin = new System.Windows.Forms.Padding(0);
			this.label_mineForChillinroom.Name = "label_mineForChillinroom";
			this.label_mineForChillinroom.Size = new System.Drawing.Size(127, 15);
			this.label_mineForChillinroom.TabIndex = 22;
			this.label_mineForChillinroom.Text = "Mine for Chillin\'Room";
			// 
			// panel_minerInfo
			// 
			this.panel_minerInfo.AutoSize = true;
			this.panel_minerInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel_minerInfo.Controls.Add(this.label_walletAddress);
			this.panel_minerInfo.Controls.Add(this.textBox_walletAddress);
			this.panel_minerInfo.Controls.Add(this.label_minerName);
			this.panel_minerInfo.Controls.Add(this.linkLabel_theWhatLink);
			this.panel_minerInfo.Controls.Add(this.textBox_minerName);
			this.panel_minerInfo.Location = new System.Drawing.Point(9, 47);
			this.panel_minerInfo.Margin = new System.Windows.Forms.Padding(0);
			this.panel_minerInfo.Name = "panel_minerInfo";
			this.panel_minerInfo.Size = new System.Drawing.Size(711, 89);
			this.panel_minerInfo.TabIndex = 24;
			// 
			// label_walletAddress
			// 
			this.label_walletAddress.AutoSize = true;
			this.label_walletAddress.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_walletAddress.ForeColor = System.Drawing.Color.Snow;
			this.label_walletAddress.Location = new System.Drawing.Point(-3, 0);
			this.label_walletAddress.Margin = new System.Windows.Forms.Padding(0);
			this.label_walletAddress.Name = "label_walletAddress";
			this.label_walletAddress.Size = new System.Drawing.Size(121, 15);
			this.label_walletAddress.TabIndex = 31;
			this.label_walletAddress.Text = "XMR wallet address";
			// 
			// textBox_walletAddress
			// 
			this.textBox_walletAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.textBox_walletAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_walletAddress.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.textBox_walletAddress.Location = new System.Drawing.Point(-3, 18);
			this.textBox_walletAddress.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_walletAddress.MaxLength = 95;
			this.textBox_walletAddress.Name = "textBox_walletAddress";
			this.textBox_walletAddress.Size = new System.Drawing.Size(714, 23);
			this.textBox_walletAddress.TabIndex = 32;
			// 
			// label_minerName
			// 
			this.label_minerName.AutoSize = true;
			this.label_minerName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_minerName.ForeColor = System.Drawing.Color.Snow;
			this.label_minerName.Location = new System.Drawing.Point(-3, 48);
			this.label_minerName.Margin = new System.Windows.Forms.Padding(0);
			this.label_minerName.Name = "label_minerName";
			this.label_minerName.Size = new System.Drawing.Size(75, 15);
			this.label_minerName.TabIndex = 33;
			this.label_minerName.Text = "Miner name";
			// 
			// linkLabel_theWhatLink
			// 
			this.linkLabel_theWhatLink.AutoSize = true;
			this.linkLabel_theWhatLink.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel_theWhatLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.linkLabel_theWhatLink.Location = new System.Drawing.Point(94, 49);
			this.linkLabel_theWhatLink.Margin = new System.Windows.Forms.Padding(0);
			this.linkLabel_theWhatLink.Name = "linkLabel_theWhatLink";
			this.linkLabel_theWhatLink.Size = new System.Drawing.Size(116, 13);
			this.linkLabel_theWhatLink.TabIndex = 35;
			this.linkLabel_theWhatLink.TabStop = true;
			this.linkLabel_theWhatLink.Text = "(\"the what?\" help link)";
			this.linkLabel_theWhatLink.Visible = false;
			this.linkLabel_theWhatLink.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			// 
			// textBox_minerName
			// 
			this.textBox_minerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.textBox_minerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_minerName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.textBox_minerName.Location = new System.Drawing.Point(-3, 66);
			this.textBox_minerName.Margin = new System.Windows.Forms.Padding(0);
			this.textBox_minerName.MaxLength = 50;
			this.textBox_minerName.Name = "textBox_minerName";
			this.textBox_minerName.Size = new System.Drawing.Size(714, 23);
			this.textBox_minerName.TabIndex = 34;
			// 
			// panel_minerSettings
			// 
			this.panel_minerSettings.AutoSize = true;
			this.panel_minerSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel_minerSettings.Controls.Add(this.pixelCheckBox_initializeMinerOnStartup);
			this.panel_minerSettings.Controls.Add(this.label_initializeMinerOnStartup);
			this.panel_minerSettings.Controls.Add(this.pixelCheckBox_terminateOnPause);
			this.panel_minerSettings.Controls.Add(this.label_terminateOnPause);
			this.panel_minerSettings.Location = new System.Drawing.Point(9, 146);
			this.panel_minerSettings.Margin = new System.Windows.Forms.Padding(0);
			this.panel_minerSettings.Name = "panel_minerSettings";
			this.panel_minerSettings.Size = new System.Drawing.Size(349, 46);
			this.panel_minerSettings.TabIndex = 23;
			// 
			// pixelCheckBox_initializeMinerOnStartup
			// 
			this.pixelCheckBox_initializeMinerOnStartup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_initializeMinerOnStartup.BackgroundImage")));
			this.pixelCheckBox_initializeMinerOnStartup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_initializeMinerOnStartup.Checked = false;
			this.pixelCheckBox_initializeMinerOnStartup.Location = new System.Drawing.Point(0, 0);
			this.pixelCheckBox_initializeMinerOnStartup.Margin = new System.Windows.Forms.Padding(0);
			this.pixelCheckBox_initializeMinerOnStartup.Name = "pixelCheckBox_initializeMinerOnStartup";
			this.pixelCheckBox_initializeMinerOnStartup.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_initializeMinerOnStartup.TabIndex = 27;
			// 
			// label_initializeMinerOnStartup
			// 
			this.label_initializeMinerOnStartup.AutoSize = true;
			this.label_initializeMinerOnStartup.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_initializeMinerOnStartup.Location = new System.Drawing.Point(24, 3);
			this.label_initializeMinerOnStartup.Margin = new System.Windows.Forms.Padding(0);
			this.label_initializeMinerOnStartup.Name = "label_initializeMinerOnStartup";
			this.label_initializeMinerOnStartup.Size = new System.Drawing.Size(205, 15);
			this.label_initializeMinerOnStartup.TabIndex = 26;
			this.label_initializeMinerOnStartup.Text = "Auto initialize miner on app startup";
			// 
			// pixelCheckBox_terminateOnPause
			// 
			this.pixelCheckBox_terminateOnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_terminateOnPause.BackgroundImage")));
			this.pixelCheckBox_terminateOnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_terminateOnPause.Checked = false;
			this.pixelCheckBox_terminateOnPause.Location = new System.Drawing.Point(0, 26);
			this.pixelCheckBox_terminateOnPause.Margin = new System.Windows.Forms.Padding(0);
			this.pixelCheckBox_terminateOnPause.Name = "pixelCheckBox_terminateOnPause";
			this.pixelCheckBox_terminateOnPause.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_terminateOnPause.TabIndex = 29;
			// 
			// label_terminateOnPause
			// 
			this.label_terminateOnPause.AutoSize = true;
			this.label_terminateOnPause.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_terminateOnPause.Location = new System.Drawing.Point(24, 29);
			this.label_terminateOnPause.Margin = new System.Windows.Forms.Padding(0);
			this.label_terminateOnPause.Name = "label_terminateOnPause";
			this.label_terminateOnPause.Size = new System.Drawing.Size(325, 15);
			this.label_terminateOnPause.TabIndex = 28;
			this.label_terminateOnPause.Text = "Terminate miner on pause (free up RAM, but slow start)";
			// 
			// panel_tray
			// 
			this.panel_tray.AutoSize = true;
			this.panel_tray.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel_tray.Controls.Add(this.pixelCheckBox_closeToTray);
			this.panel_tray.Controls.Add(this.label_minimizeToTray);
			this.panel_tray.Controls.Add(this.pixelCheckBox_minimizeToTray);
			this.panel_tray.Controls.Add(this.label_closeToTray);
			this.panel_tray.Location = new System.Drawing.Point(393, 146);
			this.panel_tray.Margin = new System.Windows.Forms.Padding(0);
			this.panel_tray.Name = "panel_tray";
			this.panel_tray.Size = new System.Drawing.Size(170, 46);
			this.panel_tray.TabIndex = 23;
			// 
			// pixelCheckBox_closeToTray
			// 
			this.pixelCheckBox_closeToTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_closeToTray.BackgroundImage")));
			this.pixelCheckBox_closeToTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_closeToTray.Checked = false;
			this.pixelCheckBox_closeToTray.Location = new System.Drawing.Point(0, 0);
			this.pixelCheckBox_closeToTray.Margin = new System.Windows.Forms.Padding(0);
			this.pixelCheckBox_closeToTray.Name = "pixelCheckBox_closeToTray";
			this.pixelCheckBox_closeToTray.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_closeToTray.TabIndex = 26;
			// 
			// label_minimizeToTray
			// 
			this.label_minimizeToTray.AutoSize = true;
			this.label_minimizeToTray.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_minimizeToTray.Location = new System.Drawing.Point(24, 29);
			this.label_minimizeToTray.Margin = new System.Windows.Forms.Padding(0);
			this.label_minimizeToTray.Name = "label_minimizeToTray";
			this.label_minimizeToTray.Size = new System.Drawing.Size(146, 15);
			this.label_minimizeToTray.TabIndex = 29;
			this.label_minimizeToTray.Text = "Minimize window to tray";
			// 
			// pixelCheckBox_minimizeToTray
			// 
			this.pixelCheckBox_minimizeToTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_minimizeToTray.BackgroundImage")));
			this.pixelCheckBox_minimizeToTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_minimizeToTray.Checked = false;
			this.pixelCheckBox_minimizeToTray.Location = new System.Drawing.Point(0, 26);
			this.pixelCheckBox_minimizeToTray.Margin = new System.Windows.Forms.Padding(0);
			this.pixelCheckBox_minimizeToTray.Name = "pixelCheckBox_minimizeToTray";
			this.pixelCheckBox_minimizeToTray.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_minimizeToTray.TabIndex = 27;
			// 
			// label_closeToTray
			// 
			this.label_closeToTray.AutoSize = true;
			this.label_closeToTray.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_closeToTray.Location = new System.Drawing.Point(24, 3);
			this.label_closeToTray.Margin = new System.Windows.Forms.Padding(0);
			this.label_closeToTray.Name = "label_closeToTray";
			this.label_closeToTray.Size = new System.Drawing.Size(127, 15);
			this.label_closeToTray.TabIndex = 28;
			this.label_closeToTray.Text = "Close window to tray";
			// 
			// panel_sharesNotification
			// 
			this.panel_sharesNotification.AutoSize = true;
			this.panel_sharesNotification.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel_sharesNotification.Controls.Add(this.label_sharesNotification);
			this.panel_sharesNotification.Controls.Add(this.pixelCheckBox_validShareNotification);
			this.panel_sharesNotification.Controls.Add(this.pixelNumberPicker_validShareNotificationCount);
			this.panel_sharesNotification.Controls.Add(this.label_validShareNotification);
			this.panel_sharesNotification.Controls.Add(this.pixelCheckBox_invalidShareNotification);
			this.panel_sharesNotification.Controls.Add(this.pixelNumberPicker_invalidShareNotificationCount);
			this.panel_sharesNotification.Controls.Add(this.label_invalidShareNotification);
			this.panel_sharesNotification.Location = new System.Drawing.Point(9, 205);
			this.panel_sharesNotification.Margin = new System.Windows.Forms.Padding(0);
			this.panel_sharesNotification.Name = "panel_sharesNotification";
			this.panel_sharesNotification.Size = new System.Drawing.Size(199, 79);
			this.panel_sharesNotification.TabIndex = 23;
			// 
			// label_sharesNotification
			// 
			this.label_sharesNotification.AutoSize = true;
			this.label_sharesNotification.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_sharesNotification.Location = new System.Drawing.Point(-3, 0);
			this.label_sharesNotification.Margin = new System.Windows.Forms.Padding(0);
			this.label_sharesNotification.Name = "label_sharesNotification";
			this.label_sharesNotification.Size = new System.Drawing.Size(202, 15);
			this.label_sharesNotification.TabIndex = 36;
			this.label_sharesNotification.Text = "Send a desktop notification every:";
			// 
			// pixelCheckBox_validShareNotification
			// 
			this.pixelCheckBox_validShareNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_validShareNotification.BackgroundImage")));
			this.pixelCheckBox_validShareNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_validShareNotification.Checked = false;
			this.pixelCheckBox_validShareNotification.Location = new System.Drawing.Point(0, 22);
			this.pixelCheckBox_validShareNotification.Margin = new System.Windows.Forms.Padding(0);
			this.pixelCheckBox_validShareNotification.Name = "pixelCheckBox_validShareNotification";
			this.pixelCheckBox_validShareNotification.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_validShareNotification.TabIndex = 36;
			// 
			// pixelNumberPicker_validShareNotificationCount
			// 
			this.pixelNumberPicker_validShareNotificationCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pixelNumberPicker_validShareNotificationCount.Location = new System.Drawing.Point(27, 18);
			this.pixelNumberPicker_validShareNotificationCount.Margin = new System.Windows.Forms.Padding(0);
			this.pixelNumberPicker_validShareNotificationCount.MaximumValue = ((long)(60));
			this.pixelNumberPicker_validShareNotificationCount.MinimumValue = ((long)(1));
			this.pixelNumberPicker_validShareNotificationCount.Name = "pixelNumberPicker_validShareNotificationCount";
			this.pixelNumberPicker_validShareNotificationCount.Size = new System.Drawing.Size(81, 29);
			this.pixelNumberPicker_validShareNotificationCount.TabIndex = 36;
			this.pixelNumberPicker_validShareNotificationCount.Value = ((long)(1));
			this.pixelNumberPicker_validShareNotificationCount.ValueChanged += new ChillinRoomGMG.Controls.PixelNumberPicker.EventDelegate(this.pixelNumberPicker_validShareNotificationCount_ValueChanged);
			// 
			// label_validShareNotification
			// 
			this.label_validShareNotification.AutoSize = true;
			this.label_validShareNotification.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_validShareNotification.Location = new System.Drawing.Point(114, 26);
			this.label_validShareNotification.Margin = new System.Windows.Forms.Padding(0);
			this.label_validShareNotification.Name = "label_validShareNotification";
			this.label_validShareNotification.Size = new System.Drawing.Size(70, 15);
			this.label_validShareNotification.TabIndex = 36;
			this.label_validShareNotification.Text = "valid share";
			// 
			// pixelCheckBox_invalidShareNotification
			// 
			this.pixelCheckBox_invalidShareNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_invalidShareNotification.BackgroundImage")));
			this.pixelCheckBox_invalidShareNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_invalidShareNotification.Checked = false;
			this.pixelCheckBox_invalidShareNotification.Location = new System.Drawing.Point(0, 54);
			this.pixelCheckBox_invalidShareNotification.Margin = new System.Windows.Forms.Padding(0);
			this.pixelCheckBox_invalidShareNotification.Name = "pixelCheckBox_invalidShareNotification";
			this.pixelCheckBox_invalidShareNotification.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_invalidShareNotification.TabIndex = 39;
			// 
			// pixelNumberPicker_invalidShareNotificationCount
			// 
			this.pixelNumberPicker_invalidShareNotificationCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pixelNumberPicker_invalidShareNotificationCount.Location = new System.Drawing.Point(27, 50);
			this.pixelNumberPicker_invalidShareNotificationCount.Margin = new System.Windows.Forms.Padding(0);
			this.pixelNumberPicker_invalidShareNotificationCount.MaximumValue = ((long)(60));
			this.pixelNumberPicker_invalidShareNotificationCount.MinimumValue = ((long)(1));
			this.pixelNumberPicker_invalidShareNotificationCount.Name = "pixelNumberPicker_invalidShareNotificationCount";
			this.pixelNumberPicker_invalidShareNotificationCount.Size = new System.Drawing.Size(81, 29);
			this.pixelNumberPicker_invalidShareNotificationCount.TabIndex = 38;
			this.pixelNumberPicker_invalidShareNotificationCount.Value = ((long)(1));
			this.pixelNumberPicker_invalidShareNotificationCount.ValueChanged += new ChillinRoomGMG.Controls.PixelNumberPicker.EventDelegate(this.pixelNumberPicker_invalidShareNotificationCount_ValueChanged);
			// 
			// label_invalidShareNotification
			// 
			this.label_invalidShareNotification.AutoSize = true;
			this.label_invalidShareNotification.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_invalidShareNotification.Location = new System.Drawing.Point(114, 58);
			this.label_invalidShareNotification.Margin = new System.Windows.Forms.Padding(0);
			this.label_invalidShareNotification.Name = "label_invalidShareNotification";
			this.label_invalidShareNotification.Size = new System.Drawing.Size(80, 15);
			this.label_invalidShareNotification.TabIndex = 37;
			this.label_invalidShareNotification.Text = "invalid share";
			// 
			// groupBox_runOnInactivity
			// 
			this.groupBox_runOnInactivity.Controls.Add(this.panel_automineDelay);
			this.groupBox_runOnInactivity.Controls.Add(this.panel_automineNotifications);
			this.groupBox_runOnInactivity.Controls.Add(this.pixelSlider_autoMine);
			this.groupBox_runOnInactivity.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_runOnInactivity.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_runOnInactivity.Location = new System.Drawing.Point(11, 329);
			this.groupBox_runOnInactivity.Margin = new System.Windows.Forms.Padding(0);
			this.groupBox_runOnInactivity.Name = "groupBox_runOnInactivity";
			this.groupBox_runOnInactivity.Size = new System.Drawing.Size(731, 92);
			this.groupBox_runOnInactivity.TabIndex = 20;
			this.groupBox_runOnInactivity.TabStop = false;
			this.groupBox_runOnInactivity.Text = "Auto-mine";
			// 
			// panel_automineDelay
			// 
			this.panel_automineDelay.AutoSize = true;
			this.panel_automineDelay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel_automineDelay.Controls.Add(this.label_delay);
			this.panel_automineDelay.Controls.Add(this.pixelNumberPicker_minutes);
			this.panel_automineDelay.Controls.Add(this.comboBox_timeUnit);
			this.panel_automineDelay.Controls.Add(this.label_minutes);
			this.panel_automineDelay.Location = new System.Drawing.Point(6, 19);
			this.panel_automineDelay.Margin = new System.Windows.Forms.Padding(0);
			this.panel_automineDelay.Name = "panel_automineDelay";
			this.panel_automineDelay.Size = new System.Drawing.Size(415, 29);
			this.panel_automineDelay.TabIndex = 23;
			// 
			// label_delay
			// 
			this.label_delay.AutoSize = true;
			this.label_delay.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_delay.ForeColor = System.Drawing.Color.Snow;
			this.label_delay.Location = new System.Drawing.Point(-3, 7);
			this.label_delay.Margin = new System.Windows.Forms.Padding(0);
			this.label_delay.Name = "label_delay";
			this.label_delay.Size = new System.Drawing.Size(83, 15);
			this.label_delay.TabIndex = 13;
			this.label_delay.Text = "Enable after :";
			// 
			// pixelNumberPicker_minutes
			// 
			this.pixelNumberPicker_minutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pixelNumberPicker_minutes.Location = new System.Drawing.Point(86, 0);
			this.pixelNumberPicker_minutes.Margin = new System.Windows.Forms.Padding(0);
			this.pixelNumberPicker_minutes.MaximumValue = ((long)(60));
			this.pixelNumberPicker_minutes.MinimumValue = ((long)(1));
			this.pixelNumberPicker_minutes.Name = "pixelNumberPicker_minutes";
			this.pixelNumberPicker_minutes.Size = new System.Drawing.Size(81, 29);
			this.pixelNumberPicker_minutes.TabIndex = 17;
			this.pixelNumberPicker_minutes.Value = ((long)(1));
			this.pixelNumberPicker_minutes.ValueChanged += new ChillinRoomGMG.Controls.PixelNumberPicker.EventDelegate(this.numberPicker_minutes_ValueChanged);
			// 
			// comboBox_timeUnit
			// 
			this.comboBox_timeUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.comboBox_timeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_timeUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox_timeUnit.ForeColor = System.Drawing.Color.Snow;
			this.comboBox_timeUnit.FormattingEnabled = true;
			this.comboBox_timeUnit.Items.AddRange(new object[] {
            "second",
            "minute",
            "hour"});
			this.comboBox_timeUnit.Location = new System.Drawing.Point(170, 4);
			this.comboBox_timeUnit.Name = "comboBox_timeUnit";
			this.comboBox_timeUnit.Size = new System.Drawing.Size(121, 21);
			this.comboBox_timeUnit.TabIndex = 19;
			// 
			// label_minutes
			// 
			this.label_minutes.AutoSize = true;
			this.label_minutes.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_minutes.Location = new System.Drawing.Point(295, 7);
			this.label_minutes.Margin = new System.Windows.Forms.Padding(0);
			this.label_minutes.Name = "label_minutes";
			this.label_minutes.Size = new System.Drawing.Size(120, 15);
			this.label_minutes.TabIndex = 18;
			this.label_minutes.Text = "of system inactivity";
			// 
			// panel_automineNotifications
			// 
			this.panel_automineNotifications.AutoSize = true;
			this.panel_automineNotifications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel_automineNotifications.Controls.Add(this.label_automineDesktopNotification);
			this.panel_automineNotifications.Controls.Add(this.label_automineDisableNotification);
			this.panel_automineNotifications.Controls.Add(this.pixelCheckBox_automineDisableNotification);
			this.panel_automineNotifications.Controls.Add(this.label_automineEnableNotification);
			this.panel_automineNotifications.Controls.Add(this.pixelCheckBox_automineEnableNotification);
			this.panel_automineNotifications.Location = new System.Drawing.Point(6, 60);
			this.panel_automineNotifications.Margin = new System.Windows.Forms.Padding(0);
			this.panel_automineNotifications.Name = "panel_automineNotifications";
			this.panel_automineNotifications.Size = new System.Drawing.Size(424, 20);
			this.panel_automineNotifications.TabIndex = 23;
			// 
			// label_automineDesktopNotification
			// 
			this.label_automineDesktopNotification.AutoSize = true;
			this.label_automineDesktopNotification.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_automineDesktopNotification.Location = new System.Drawing.Point(-3, 3);
			this.label_automineDesktopNotification.Margin = new System.Windows.Forms.Padding(0);
			this.label_automineDesktopNotification.Name = "label_automineDesktopNotification";
			this.label_automineDesktopNotification.Size = new System.Drawing.Size(271, 15);
			this.label_automineDesktopNotification.TabIndex = 35;
			this.label_automineDesktopNotification.Text = "Send a desktop notification when auto-mining:";
			// 
			// label_automineDisableNotification
			// 
			this.label_automineDisableNotification.AutoSize = true;
			this.label_automineDisableNotification.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_automineDisableNotification.Location = new System.Drawing.Point(384, 3);
			this.label_automineDisableNotification.Margin = new System.Windows.Forms.Padding(0);
			this.label_automineDisableNotification.Name = "label_automineDisableNotification";
			this.label_automineDisableNotification.Size = new System.Drawing.Size(40, 15);
			this.label_automineDisableNotification.TabIndex = 34;
			this.label_automineDisableNotification.Text = "Stops";
			// 
			// pixelCheckBox_automineDisableNotification
			// 
			this.pixelCheckBox_automineDisableNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_automineDisableNotification.BackgroundImage")));
			this.pixelCheckBox_automineDisableNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_automineDisableNotification.Checked = false;
			this.pixelCheckBox_automineDisableNotification.Location = new System.Drawing.Point(360, 0);
			this.pixelCheckBox_automineDisableNotification.Margin = new System.Windows.Forms.Padding(0);
			this.pixelCheckBox_automineDisableNotification.Name = "pixelCheckBox_automineDisableNotification";
			this.pixelCheckBox_automineDisableNotification.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_automineDisableNotification.TabIndex = 33;
			// 
			// label_automineEnableNotification
			// 
			this.label_automineEnableNotification.AutoSize = true;
			this.label_automineEnableNotification.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_automineEnableNotification.Location = new System.Drawing.Point(295, 3);
			this.label_automineEnableNotification.Margin = new System.Windows.Forms.Padding(0);
			this.label_automineEnableNotification.Name = "label_automineEnableNotification";
			this.label_automineEnableNotification.Size = new System.Drawing.Size(42, 15);
			this.label_automineEnableNotification.TabIndex = 31;
			this.label_automineEnableNotification.Text = "Starts";
			// 
			// pixelCheckBox_automineEnableNotification
			// 
			this.pixelCheckBox_automineEnableNotification.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_automineEnableNotification.BackgroundImage")));
			this.pixelCheckBox_automineEnableNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_automineEnableNotification.Checked = false;
			this.pixelCheckBox_automineEnableNotification.Location = new System.Drawing.Point(271, 0);
			this.pixelCheckBox_automineEnableNotification.Margin = new System.Windows.Forms.Padding(0);
			this.pixelCheckBox_automineEnableNotification.Name = "pixelCheckBox_automineEnableNotification";
			this.pixelCheckBox_automineEnableNotification.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_automineEnableNotification.TabIndex = 32;
			// 
			// pixelSlider_autoMine
			// 
			this.pixelSlider_autoMine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelSlider_autoMine.BackgroundImage")));
			this.pixelSlider_autoMine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelSlider_autoMine.Location = new System.Drawing.Point(68, 0);
			this.pixelSlider_autoMine.Margin = new System.Windows.Forms.Padding(0);
			this.pixelSlider_autoMine.Name = "pixelSlider_autoMine";
			this.pixelSlider_autoMine.Size = new System.Drawing.Size(28, 14);
			this.pixelSlider_autoMine.Slided = false;
			this.pixelSlider_autoMine.TabIndex = 15;
			// 
			// panel_buttons
			// 
			this.panel_buttons.AutoSize = true;
			this.panel_buttons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel_buttons.Controls.Add(this.button_cancel);
			this.panel_buttons.Controls.Add(this.button_save);
			this.panel_buttons.Location = new System.Drawing.Point(563, 450);
			this.panel_buttons.Margin = new System.Windows.Forms.Padding(0);
			this.panel_buttons.Name = "panel_buttons";
			this.panel_buttons.Size = new System.Drawing.Size(179, 28);
			this.panel_buttons.TabIndex = 23;
			// 
			// button_cancel
			// 
			this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_cancel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_cancel.Location = new System.Drawing.Point(98, 0);
			this.button_cancel.Margin = new System.Windows.Forms.Padding(0);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(81, 28);
			this.button_cancel.TabIndex = 21;
			this.button_cancel.Text = "CANCEL";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// button_save
			// 
			this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_save.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_save.Location = new System.Drawing.Point(0, 0);
			this.button_save.Margin = new System.Windows.Forms.Padding(0);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(81, 28);
			this.button_save.TabIndex = 22;
			this.button_save.Text = "SAVE";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 491);
			this.Controls.Add(this.panel_background);
			this.ForeColor = System.Drawing.Color.Snow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Options";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.Options_Load);
			this.panel_background.ResumeLayout(false);
			this.panel_background.PerformLayout();
			this.groupBox_general.ResumeLayout(false);
			this.groupBox_general.PerformLayout();
			this.panel_mineForChillinroom.ResumeLayout(false);
			this.panel_mineForChillinroom.PerformLayout();
			this.panel_minerInfo.ResumeLayout(false);
			this.panel_minerInfo.PerformLayout();
			this.panel_minerSettings.ResumeLayout(false);
			this.panel_minerSettings.PerformLayout();
			this.panel_tray.ResumeLayout(false);
			this.panel_tray.PerformLayout();
			this.panel_sharesNotification.ResumeLayout(false);
			this.panel_sharesNotification.PerformLayout();
			this.groupBox_runOnInactivity.ResumeLayout(false);
			this.groupBox_runOnInactivity.PerformLayout();
			this.panel_automineDelay.ResumeLayout(false);
			this.panel_automineDelay.PerformLayout();
			this.panel_automineNotifications.ResumeLayout(false);
			this.panel_automineNotifications.PerformLayout();
			this.panel_buttons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_background;
		private Controls.PixelTitleBar titleBar;
		private System.Windows.Forms.GroupBox groupBox_general;
		private System.Windows.Forms.GroupBox groupBox_runOnInactivity;
		private System.Windows.Forms.Label label_delay;
		private Controls.PixelSlider pixelSlider_autoMine;
		private Controls.PixelNumberPicker pixelNumberPicker_minutes;
		private System.Windows.Forms.Label label_minutes;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_save;
		private Controls.PixelCheckBox pixelCheckBox_mineForChillinroom;
		private System.Windows.Forms.Label label_mineForChillinroom;
		private Controls.PixelCheckBox pixelCheckBox_closeToTray;
		private System.Windows.Forms.Label label_closeToTray;
		private Controls.PixelCheckBox pixelCheckBox_minimizeToTray;
		private System.Windows.Forms.Label label_minimizeToTray;
		private Controls.PixelCheckBox pixelCheckBox_automineEnableNotification;
		private System.Windows.Forms.Label label_automineEnableNotification;
		private Controls.PixelCheckBox pixelCheckBox_automineDisableNotification;
		private System.Windows.Forms.Label label_automineDisableNotification;
		private System.Windows.Forms.Label label_automineDesktopNotification;
		private System.Windows.Forms.Panel panel_minerInfo;
		private System.Windows.Forms.Label label_walletAddress;
		private System.Windows.Forms.TextBox textBox_walletAddress;
		private System.Windows.Forms.Label label_minerName;
		private System.Windows.Forms.LinkLabel linkLabel_theWhatLink;
		private System.Windows.Forms.TextBox textBox_minerName;
		private System.Windows.Forms.Panel panel_minerSettings;
		private Controls.PixelCheckBox pixelCheckBox_initializeMinerOnStartup;
		private System.Windows.Forms.Label label_initializeMinerOnStartup;
		private Controls.PixelCheckBox pixelCheckBox_terminateOnPause;
		private System.Windows.Forms.Label label_terminateOnPause;
		private System.Windows.Forms.Panel panel_tray;
		private System.Windows.Forms.Panel panel_sharesNotification;
		private System.Windows.Forms.Label label_invalidShareNotification;
		private System.Windows.Forms.Label label_sharesNotification;
		private Controls.PixelNumberPicker pixelNumberPicker_invalidShareNotificationCount;
		private Controls.PixelCheckBox pixelCheckBox_validShareNotification;
		private Controls.PixelCheckBox pixelCheckBox_invalidShareNotification;
		private Controls.PixelNumberPicker pixelNumberPicker_validShareNotificationCount;
		private System.Windows.Forms.Label label_validShareNotification;
		private System.Windows.Forms.Panel panel_automineDelay;
		private System.Windows.Forms.Panel panel_automineNotifications;
		private System.Windows.Forms.Panel panel_buttons;
		private System.Windows.Forms.Panel panel_mineForChillinroom;
		private System.Windows.Forms.ComboBox comboBox_timeUnit;
	}
}