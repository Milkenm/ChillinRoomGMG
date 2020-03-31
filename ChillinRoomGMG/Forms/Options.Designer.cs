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
			this.groupBox_general = new System.Windows.Forms.GroupBox();
			this.label_mineForChillinroom = new System.Windows.Forms.Label();
			this.label_walletAddress = new System.Windows.Forms.Label();
			this.textBox_walletAddress = new System.Windows.Forms.TextBox();
			this.label_minerName = new System.Windows.Forms.Label();
			this.linkLabel_theWhatLink = new System.Windows.Forms.LinkLabel();
			this.textBox_minerName = new System.Windows.Forms.TextBox();
			this.label_initializeMinerOnStartup = new System.Windows.Forms.Label();
			this.label_terminateOnPause = new System.Windows.Forms.Label();
			this.label_closeToTray = new System.Windows.Forms.Label();
			this.label_minimizeToTray = new System.Windows.Forms.Label();
			this.groupBox_runOnInactivity = new System.Windows.Forms.GroupBox();
			this.label_minutes = new System.Windows.Forms.Label();
			this.label_delay = new System.Windows.Forms.Label();
			this.button_save = new System.Windows.Forms.Button();
			this.button_cancel = new System.Windows.Forms.Button();
			this.titleBar = new ChillinRoomGMG.Controls.PixelTitleBar();
			this.pixelCheckBox_mineForChillinroom = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.pixelCheckBox_initializeMinerOnStartup = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.pixelCheckBox_terminateOnPause = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.pixelCheckBox_closeToTray = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.pixelCheckBox_minimizeToTray = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.pixelNumberPicker_minutes = new ChillinRoomGMG.Controls.PixelNumberPicker();
			this.pixelSlider_autoMine = new ChillinRoomGMG.Controls.PixelSlider();
			this.panel_background.SuspendLayout();
			this.groupBox_general.SuspendLayout();
			this.groupBox_runOnInactivity.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_background
			// 
			this.panel_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.panel_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_background.Controls.Add(this.titleBar);
			this.panel_background.Controls.Add(this.groupBox_general);
			this.panel_background.Controls.Add(this.groupBox_runOnInactivity);
			this.panel_background.Controls.Add(this.button_save);
			this.panel_background.Controls.Add(this.button_cancel);
			this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_background.Location = new System.Drawing.Point(0, 0);
			this.panel_background.Name = "panel_background";
			this.panel_background.Size = new System.Drawing.Size(750, 349);
			this.panel_background.TabIndex = 0;
			// 
			// groupBox_general
			// 
			this.groupBox_general.Controls.Add(this.pixelCheckBox_mineForChillinroom);
			this.groupBox_general.Controls.Add(this.label_mineForChillinroom);
			this.groupBox_general.Controls.Add(this.label_walletAddress);
			this.groupBox_general.Controls.Add(this.textBox_walletAddress);
			this.groupBox_general.Controls.Add(this.label_minerName);
			this.groupBox_general.Controls.Add(this.linkLabel_theWhatLink);
			this.groupBox_general.Controls.Add(this.textBox_minerName);
			this.groupBox_general.Controls.Add(this.pixelCheckBox_initializeMinerOnStartup);
			this.groupBox_general.Controls.Add(this.label_initializeMinerOnStartup);
			this.groupBox_general.Controls.Add(this.pixelCheckBox_terminateOnPause);
			this.groupBox_general.Controls.Add(this.label_terminateOnPause);
			this.groupBox_general.Controls.Add(this.pixelCheckBox_closeToTray);
			this.groupBox_general.Controls.Add(this.label_closeToTray);
			this.groupBox_general.Controls.Add(this.pixelCheckBox_minimizeToTray);
			this.groupBox_general.Controls.Add(this.label_minimizeToTray);
			this.groupBox_general.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_general.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_general.Location = new System.Drawing.Point(11, 28);
			this.groupBox_general.Name = "groupBox_general";
			this.groupBox_general.Size = new System.Drawing.Size(726, 204);
			this.groupBox_general.TabIndex = 19;
			this.groupBox_general.TabStop = false;
			this.groupBox_general.Text = "General";
			// 
			// label_mineForChillinroom
			// 
			this.label_mineForChillinroom.AutoSize = true;
			this.label_mineForChillinroom.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mineForChillinroom.ForeColor = System.Drawing.Color.Snow;
			this.label_mineForChillinroom.Location = new System.Drawing.Point(37, 22);
			this.label_mineForChillinroom.Name = "label_mineForChillinroom";
			this.label_mineForChillinroom.Size = new System.Drawing.Size(127, 15);
			this.label_mineForChillinroom.TabIndex = 22;
			this.label_mineForChillinroom.Text = "Mine for Chillin\'Room";
			// 
			// label_walletAddress
			// 
			this.label_walletAddress.AutoSize = true;
			this.label_walletAddress.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_walletAddress.ForeColor = System.Drawing.Color.Snow;
			this.label_walletAddress.Location = new System.Drawing.Point(6, 48);
			this.label_walletAddress.Name = "label_walletAddress";
			this.label_walletAddress.Size = new System.Drawing.Size(121, 15);
			this.label_walletAddress.TabIndex = 13;
			this.label_walletAddress.Text = "XMR wallet address";
			// 
			// textBox_walletAddress
			// 
			this.textBox_walletAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.textBox_walletAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox_walletAddress.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.textBox_walletAddress.Location = new System.Drawing.Point(6, 66);
			this.textBox_walletAddress.MaxLength = 95;
			this.textBox_walletAddress.Name = "textBox_walletAddress";
			this.textBox_walletAddress.Size = new System.Drawing.Size(714, 23);
			this.textBox_walletAddress.TabIndex = 14;
			// 
			// label_minerName
			// 
			this.label_minerName.AutoSize = true;
			this.label_minerName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_minerName.ForeColor = System.Drawing.Color.Snow;
			this.label_minerName.Location = new System.Drawing.Point(6, 96);
			this.label_minerName.Name = "label_minerName";
			this.label_minerName.Size = new System.Drawing.Size(75, 15);
			this.label_minerName.TabIndex = 17;
			this.label_minerName.Text = "Miner name";
			// 
			// linkLabel_theWhatLink
			// 
			this.linkLabel_theWhatLink.AutoSize = true;
			this.linkLabel_theWhatLink.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel_theWhatLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.linkLabel_theWhatLink.Location = new System.Drawing.Point(103, 97);
			this.linkLabel_theWhatLink.Name = "linkLabel_theWhatLink";
			this.linkLabel_theWhatLink.Size = new System.Drawing.Size(116, 13);
			this.linkLabel_theWhatLink.TabIndex = 30;
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
			this.textBox_minerName.Location = new System.Drawing.Point(6, 114);
			this.textBox_minerName.MaxLength = 50;
			this.textBox_minerName.Name = "textBox_minerName";
			this.textBox_minerName.Size = new System.Drawing.Size(714, 23);
			this.textBox_minerName.TabIndex = 18;
			this.textBox_minerName.TextChanged += new System.EventHandler(this.textBox_minerName_TextChanged);
			this.textBox_minerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_minerName_KeyDown);
			// 
			// label_initializeMinerOnStartup
			// 
			this.label_initializeMinerOnStartup.AutoSize = true;
			this.label_initializeMinerOnStartup.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_initializeMinerOnStartup.Location = new System.Drawing.Point(37, 149);
			this.label_initializeMinerOnStartup.Name = "label_initializeMinerOnStartup";
			this.label_initializeMinerOnStartup.Size = new System.Drawing.Size(205, 15);
			this.label_initializeMinerOnStartup.TabIndex = 19;
			this.label_initializeMinerOnStartup.Text = "Auto initialize miner on app startup";
			// 
			// label_terminateOnPause
			// 
			this.label_terminateOnPause.AutoSize = true;
			this.label_terminateOnPause.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_terminateOnPause.Location = new System.Drawing.Point(37, 175);
			this.label_terminateOnPause.Name = "label_terminateOnPause";
			this.label_terminateOnPause.Size = new System.Drawing.Size(325, 15);
			this.label_terminateOnPause.TabIndex = 24;
			this.label_terminateOnPause.Text = "Terminate miner on pause (free up RAM, but slow start)";
			// 
			// label_closeToTray
			// 
			this.label_closeToTray.AutoSize = true;
			this.label_closeToTray.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_closeToTray.Location = new System.Drawing.Point(423, 149);
			this.label_closeToTray.Name = "label_closeToTray";
			this.label_closeToTray.Size = new System.Drawing.Size(127, 15);
			this.label_closeToTray.TabIndex = 28;
			this.label_closeToTray.Text = "Close window to tray";
			// 
			// label_minimizeToTray
			// 
			this.label_minimizeToTray.AutoSize = true;
			this.label_minimizeToTray.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_minimizeToTray.Location = new System.Drawing.Point(423, 175);
			this.label_minimizeToTray.Name = "label_minimizeToTray";
			this.label_minimizeToTray.Size = new System.Drawing.Size(146, 15);
			this.label_minimizeToTray.TabIndex = 29;
			this.label_minimizeToTray.Text = "Minimize window to tray";
			// 
			// groupBox_runOnInactivity
			// 
			this.groupBox_runOnInactivity.Controls.Add(this.label_minutes);
			this.groupBox_runOnInactivity.Controls.Add(this.pixelNumberPicker_minutes);
			this.groupBox_runOnInactivity.Controls.Add(this.label_delay);
			this.groupBox_runOnInactivity.Controls.Add(this.pixelSlider_autoMine);
			this.groupBox_runOnInactivity.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_runOnInactivity.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_runOnInactivity.Location = new System.Drawing.Point(11, 238);
			this.groupBox_runOnInactivity.Name = "groupBox_runOnInactivity";
			this.groupBox_runOnInactivity.Size = new System.Drawing.Size(726, 63);
			this.groupBox_runOnInactivity.TabIndex = 20;
			this.groupBox_runOnInactivity.TabStop = false;
			this.groupBox_runOnInactivity.Text = "Auto-mine";
			// 
			// label_minutes
			// 
			this.label_minutes.AutoSize = true;
			this.label_minutes.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_minutes.Location = new System.Drawing.Point(184, 26);
			this.label_minutes.Name = "label_minutes";
			this.label_minutes.Size = new System.Drawing.Size(162, 15);
			this.label_minutes.TabIndex = 18;
			this.label_minutes.Text = "minute of system inactivity";
			// 
			// label_delay
			// 
			this.label_delay.AutoSize = true;
			this.label_delay.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_delay.ForeColor = System.Drawing.Color.Snow;
			this.label_delay.Location = new System.Drawing.Point(8, 26);
			this.label_delay.Name = "label_delay";
			this.label_delay.Size = new System.Drawing.Size(83, 15);
			this.label_delay.TabIndex = 13;
			this.label_delay.Text = "Enable after :";
			// 
			// button_save
			// 
			this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_save.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_save.Location = new System.Drawing.Point(559, 311);
			this.button_save.Name = "button_save";
			this.button_save.Size = new System.Drawing.Size(81, 28);
			this.button_save.TabIndex = 22;
			this.button_save.Text = "SAVE";
			this.button_save.UseVisualStyleBackColor = true;
			this.button_save.Click += new System.EventHandler(this.button_save_Click);
			// 
			// button_cancel
			// 
			this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_cancel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_cancel.Location = new System.Drawing.Point(656, 311);
			this.button_cancel.Name = "button_cancel";
			this.button_cancel.Size = new System.Drawing.Size(81, 28);
			this.button_cancel.TabIndex = 21;
			this.button_cancel.Text = "CANCEL";
			this.button_cancel.UseVisualStyleBackColor = true;
			this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
			// 
			// titleBar
			// 
			this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Name = "titleBar";
			this.titleBar.ShowMinimizeButton = true;
			this.titleBar.Size = new System.Drawing.Size(748, 22);
			this.titleBar.TabIndex = 0;
			this.titleBar.TitleExtension = "Options";
			// 
			// pixelCheckBox_mineForChillinroom
			// 
			this.pixelCheckBox_mineForChillinroom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_mineForChillinroom.BackgroundImage")));
			this.pixelCheckBox_mineForChillinroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_mineForChillinroom.Checked = false;
			this.pixelCheckBox_mineForChillinroom.Location = new System.Drawing.Point(11, 19);
			this.pixelCheckBox_mineForChillinroom.Name = "pixelCheckBox_mineForChillinroom";
			this.pixelCheckBox_mineForChillinroom.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_mineForChillinroom.TabIndex = 21;
			this.pixelCheckBox_mineForChillinroom.CheckedChanged += new ChillinRoomGMG.Controls.PixelCheckBox.EventDelegate(this.pixelCheckBox_mineForChillinroom_CheckedChanged);
			// 
			// pixelCheckBox_initializeMinerOnStartup
			// 
			this.pixelCheckBox_initializeMinerOnStartup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_initializeMinerOnStartup.BackgroundImage")));
			this.pixelCheckBox_initializeMinerOnStartup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_initializeMinerOnStartup.Checked = false;
			this.pixelCheckBox_initializeMinerOnStartup.Location = new System.Drawing.Point(11, 146);
			this.pixelCheckBox_initializeMinerOnStartup.Name = "pixelCheckBox_initializeMinerOnStartup";
			this.pixelCheckBox_initializeMinerOnStartup.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_initializeMinerOnStartup.TabIndex = 23;
			// 
			// pixelCheckBox_terminateOnPause
			// 
			this.pixelCheckBox_terminateOnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_terminateOnPause.BackgroundImage")));
			this.pixelCheckBox_terminateOnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_terminateOnPause.Checked = false;
			this.pixelCheckBox_terminateOnPause.Location = new System.Drawing.Point(11, 172);
			this.pixelCheckBox_terminateOnPause.Name = "pixelCheckBox_terminateOnPause";
			this.pixelCheckBox_terminateOnPause.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_terminateOnPause.TabIndex = 25;
			// 
			// pixelCheckBox_closeToTray
			// 
			this.pixelCheckBox_closeToTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_closeToTray.BackgroundImage")));
			this.pixelCheckBox_closeToTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_closeToTray.Checked = false;
			this.pixelCheckBox_closeToTray.Location = new System.Drawing.Point(397, 146);
			this.pixelCheckBox_closeToTray.Name = "pixelCheckBox_closeToTray";
			this.pixelCheckBox_closeToTray.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_closeToTray.TabIndex = 26;
			// 
			// pixelCheckBox_minimizeToTray
			// 
			this.pixelCheckBox_minimizeToTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_minimizeToTray.BackgroundImage")));
			this.pixelCheckBox_minimizeToTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_minimizeToTray.Checked = false;
			this.pixelCheckBox_minimizeToTray.Location = new System.Drawing.Point(397, 172);
			this.pixelCheckBox_minimizeToTray.Name = "pixelCheckBox_minimizeToTray";
			this.pixelCheckBox_minimizeToTray.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_minimizeToTray.TabIndex = 27;
			// 
			// pixelNumberPicker_minutes
			// 
			this.pixelNumberPicker_minutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pixelNumberPicker_minutes.Location = new System.Drawing.Point(97, 20);
			this.pixelNumberPicker_minutes.MaximumValue = ((long)(60));
			this.pixelNumberPicker_minutes.MinimumValue = ((long)(1));
			this.pixelNumberPicker_minutes.Name = "pixelNumberPicker_minutes";
			this.pixelNumberPicker_minutes.Size = new System.Drawing.Size(81, 29);
			this.pixelNumberPicker_minutes.TabIndex = 17;
			this.pixelNumberPicker_minutes.Value = ((long)(1));
			this.pixelNumberPicker_minutes.ValueChanged += new ChillinRoomGMG.Controls.PixelNumberPicker.EventDelegate(this.numberPicker_minutes_ValueChanged);
			// 
			// pixelSlider_autoMine
			// 
			this.pixelSlider_autoMine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelSlider_autoMine.BackgroundImage")));
			this.pixelSlider_autoMine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelSlider_autoMine.Location = new System.Drawing.Point(68, 0);
			this.pixelSlider_autoMine.Name = "pixelSlider_autoMine";
			this.pixelSlider_autoMine.Size = new System.Drawing.Size(28, 14);
			this.pixelSlider_autoMine.Slided = false;
			this.pixelSlider_autoMine.TabIndex = 15;
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 349);
			this.Controls.Add(this.panel_background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Options";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.Options_Load);
			this.panel_background.ResumeLayout(false);
			this.groupBox_general.ResumeLayout(false);
			this.groupBox_general.PerformLayout();
			this.groupBox_runOnInactivity.ResumeLayout(false);
			this.groupBox_runOnInactivity.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_background;
		private Controls.PixelTitleBar titleBar;
		private System.Windows.Forms.TextBox textBox_walletAddress;
		private System.Windows.Forms.Label label_walletAddress;
		private System.Windows.Forms.TextBox textBox_minerName;
		private System.Windows.Forms.Label label_minerName;
		private System.Windows.Forms.GroupBox groupBox_general;
		private System.Windows.Forms.GroupBox groupBox_runOnInactivity;
		private System.Windows.Forms.Label label_delay;
		private Controls.PixelSlider pixelSlider_autoMine;
		private Controls.PixelNumberPicker pixelNumberPicker_minutes;
		private System.Windows.Forms.Label label_minutes;
		private System.Windows.Forms.Button button_cancel;
		private System.Windows.Forms.Button button_save;
		private System.Windows.Forms.Label label_initializeMinerOnStartup;
		private Controls.PixelCheckBox pixelCheckBox_mineForChillinroom;
		private System.Windows.Forms.Label label_mineForChillinroom;
		private Controls.PixelCheckBox pixelCheckBox_initializeMinerOnStartup;
		private Controls.PixelCheckBox pixelCheckBox_terminateOnPause;
		private System.Windows.Forms.Label label_terminateOnPause;
		private Controls.PixelCheckBox pixelCheckBox_closeToTray;
		private System.Windows.Forms.Label label_closeToTray;
		private Controls.PixelCheckBox pixelCheckBox_minimizeToTray;
		private System.Windows.Forms.Label label_minimizeToTray;
		private System.Windows.Forms.LinkLabel linkLabel_theWhatLink;
	}
}