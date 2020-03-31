namespace ChillinRoomGMG.Forms
{
	partial class Setup
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
			this.panel_background = new System.Windows.Forms.Panel();
			this.label_winring = new System.Windows.Forms.Label();
			this.pixelCheckBox_winring = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.label_xmrig = new System.Windows.Forms.Label();
			this.titleBar = new ChillinRoomGMG.Controls.PixelTitleBar();
			this.pixelCheckBox_xmrig = new ChillinRoomGMG.Controls.PixelCheckBox();
			this.panel_info = new System.Windows.Forms.Panel();
			this.linkLabel_info = new System.Windows.Forms.LinkLabel();
			this.label_path = new System.Windows.Forms.Label();
			this.textBox_path = new System.Windows.Forms.TextBox();
			this.button_search = new System.Windows.Forms.Button();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.panel_background.SuspendLayout();
			this.panel_info.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_background
			// 
			this.panel_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_background.Controls.Add(this.label_winring);
			this.panel_background.Controls.Add(this.pixelCheckBox_winring);
			this.panel_background.Controls.Add(this.label_xmrig);
			this.panel_background.Controls.Add(this.titleBar);
			this.panel_background.Controls.Add(this.pixelCheckBox_xmrig);
			this.panel_background.Controls.Add(this.panel_info);
			this.panel_background.Controls.Add(this.label_path);
			this.panel_background.Controls.Add(this.textBox_path);
			this.panel_background.Controls.Add(this.button_search);
			this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_background.Location = new System.Drawing.Point(0, 0);
			this.panel_background.Name = "panel_background";
			this.panel_background.Size = new System.Drawing.Size(644, 254);
			this.panel_background.TabIndex = 0;
			// 
			// label_winring
			// 
			this.label_winring.AutoSize = true;
			this.label_winring.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_winring.ForeColor = System.Drawing.Color.Snow;
			this.label_winring.Location = new System.Drawing.Point(393, 222);
			this.label_winring.Name = "label_winring";
			this.label_winring.Size = new System.Drawing.Size(53, 15);
			this.label_winring.TabIndex = 30;
			this.label_winring.Text = "WinRing";
			// 
			// pixelCheckBox_winring
			// 
			this.pixelCheckBox_winring.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_winring.BackgroundImage")));
			this.pixelCheckBox_winring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_winring.Checked = false;
			this.pixelCheckBox_winring.Enabled = false;
			this.pixelCheckBox_winring.Location = new System.Drawing.Point(369, 219);
			this.pixelCheckBox_winring.Name = "pixelCheckBox_winring";
			this.pixelCheckBox_winring.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_winring.TabIndex = 28;
			// 
			// label_xmrig
			// 
			this.label_xmrig.AutoSize = true;
			this.label_xmrig.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.label_xmrig.ForeColor = System.Drawing.Color.Snow;
			this.label_xmrig.Location = new System.Drawing.Point(220, 222);
			this.label_xmrig.Name = "label_xmrig";
			this.label_xmrig.Size = new System.Drawing.Size(44, 15);
			this.label_xmrig.TabIndex = 29;
			this.label_xmrig.Text = "XMRig";
			// 
			// titleBar
			// 
			this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Name = "titleBar";
			this.titleBar.ShowMinimizeButton = true;
			this.titleBar.Size = new System.Drawing.Size(642, 22);
			this.titleBar.TabIndex = 15;
			this.titleBar.TitleExtension = "Setup";
			// 
			// pixelCheckBox_xmrig
			// 
			this.pixelCheckBox_xmrig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pixelCheckBox_xmrig.BackgroundImage")));
			this.pixelCheckBox_xmrig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pixelCheckBox_xmrig.Checked = false;
			this.pixelCheckBox_xmrig.Enabled = false;
			this.pixelCheckBox_xmrig.Location = new System.Drawing.Point(196, 219);
			this.pixelCheckBox_xmrig.Name = "pixelCheckBox_xmrig";
			this.pixelCheckBox_xmrig.Size = new System.Drawing.Size(20, 20);
			this.pixelCheckBox_xmrig.TabIndex = 27;
			// 
			// panel_info
			// 
			this.panel_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_info.Controls.Add(this.linkLabel_info);
			this.panel_info.Location = new System.Drawing.Point(-1, 31);
			this.panel_info.Name = "panel_info";
			this.panel_info.Size = new System.Drawing.Size(644, 120);
			this.panel_info.TabIndex = 26;
			// 
			// linkLabel_info
			// 
			this.linkLabel_info.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.linkLabel_info.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold);
			this.linkLabel_info.ForeColor = System.Drawing.Color.Snow;
			this.linkLabel_info.LinkArea = new System.Windows.Forms.LinkArea(49, 4);
			this.linkLabel_info.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.linkLabel_info.Location = new System.Drawing.Point(15, 5);
			this.linkLabel_info.Name = "linkLabel_info";
			this.linkLabel_info.Size = new System.Drawing.Size(613, 108);
			this.linkLabel_info.TabIndex = 25;
			this.linkLabel_info.TabStop = true;
			this.linkLabel_info.Text = resources.GetString("linkLabel_info.Text");
			this.linkLabel_info.UseCompatibleTextRendering = true;
			this.linkLabel_info.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.linkLabel_info.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_info_LinkClicked);
			// 
			// label_path
			// 
			this.label_path.AutoSize = true;
			this.label_path.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_path.ForeColor = System.Drawing.Color.Snow;
			this.label_path.Location = new System.Drawing.Point(50, 164);
			this.label_path.Name = "label_path";
			this.label_path.Size = new System.Drawing.Size(85, 13);
			this.label_path.TabIndex = 24;
			this.label_path.Text = "XMRig ZIP path";
			// 
			// textBox_path
			// 
			this.textBox_path.BackColor = System.Drawing.Color.Snow;
			this.textBox_path.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_path.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold);
			this.textBox_path.Location = new System.Drawing.Point(53, 180);
			this.textBox_path.Name = "textBox_path";
			this.textBox_path.ReadOnly = true;
			this.textBox_path.Size = new System.Drawing.Size(450, 26);
			this.textBox_path.TabIndex = 16;
			// 
			// button_search
			// 
			this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_search.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_search.Location = new System.Drawing.Point(509, 180);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(81, 26);
			this.button_search.TabIndex = 17;
			this.button_search.Text = "SEARCH";
			this.button_search.UseVisualStyleBackColor = true;
			this.button_search.Click += new System.EventHandler(this.button_search_Click);
			// 
			// fileDialog
			// 
			this.fileDialog.Filter = "ZIP Files | *.zip";
			this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
			// 
			// Setup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.ClientSize = new System.Drawing.Size(644, 254);
			this.Controls.Add(this.panel_background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Setup";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Setup";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setup_FormClosing);
			this.panel_background.ResumeLayout(false);
			this.panel_background.PerformLayout();
			this.panel_info.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_background;
		private Controls.PixelTitleBar titleBar;
		private System.Windows.Forms.TextBox textBox_path;
		private System.Windows.Forms.Button button_search;
		private System.Windows.Forms.Label label_path;
		private System.Windows.Forms.LinkLabel linkLabel_info;
		private System.Windows.Forms.Panel panel_info;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.Label label_winring;
		private Controls.PixelCheckBox pixelCheckBox_winring;
		private System.Windows.Forms.Label label_xmrig;
		private Controls.PixelCheckBox pixelCheckBox_xmrig;
	}
}