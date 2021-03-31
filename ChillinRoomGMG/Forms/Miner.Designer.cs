namespace ChillinRoomGMG.Forms
{
	partial class Miner
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miner));
			this.panel_background = new System.Windows.Forms.Panel();
			this.titleBar = new ChillinRoomGMG.Controls.PixelTitleBar();
			this.button_options = new System.Windows.Forms.Button();
			this.listBox_log = new System.Windows.Forms.ListBox();
			this.panel_controls = new System.Windows.Forms.Panel();
			this.button_mine = new System.Windows.Forms.Button();
			this.groupBox_hashRate = new System.Windows.Forms.GroupBox();
			this.label_hashRate = new System.Windows.Forms.Label();
			this.label_maxHashRate = new System.Windows.Forms.Label();
			this.groupBox_shares = new System.Windows.Forms.GroupBox();
			this.label_lastValid = new System.Windows.Forms.Label();
			this.label_shares = new System.Windows.Forms.Label();
			this.label_sharesInfo = new System.Windows.Forms.Label();
			this.label_xmrValue = new System.Windows.Forms.Label();
			this.button_statistics = new System.Windows.Forms.Button();
			this.timer_refreshLatestShareTimer = new System.Windows.Forms.Timer(this.components);
			this.timer_miningTimeCounter = new System.Windows.Forms.Timer(this.components);
			this.timer_save = new System.Windows.Forms.Timer(this.components);
			this.timer_refreshXmrPrice = new System.Windows.Forms.Timer(this.components);
			this.panel_background.SuspendLayout();
			this.panel_controls.SuspendLayout();
			this.groupBox_hashRate.SuspendLayout();
			this.groupBox_shares.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_background
			// 
			this.panel_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_background.Controls.Add(this.titleBar);
			this.panel_background.Controls.Add(this.button_options);
			this.panel_background.Controls.Add(this.listBox_log);
			this.panel_background.Controls.Add(this.panel_controls);
			this.panel_background.Controls.Add(this.label_xmrValue);
			this.panel_background.Controls.Add(this.button_statistics);
			this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_background.Location = new System.Drawing.Point(0, 0);
			this.panel_background.Name = "panel_background";
			this.panel_background.Size = new System.Drawing.Size(747, 422);
			this.panel_background.TabIndex = 0;
			// 
			// titleBar
			// 
			this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Name = "titleBar";
			this.titleBar.ShowMinimizeButton = true;
			this.titleBar.Size = new System.Drawing.Size(745, 22);
			this.titleBar.TabIndex = 16;
			this.titleBar.TitleExtension = "Options";
			// 
			// button_options
			// 
			this.button_options.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_options.BackgroundImage")));
			this.button_options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button_options.FlatAppearance.BorderSize = 0;
			this.button_options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
			this.button_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.button_options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_options.Location = new System.Drawing.Point(569, 384);
			this.button_options.Name = "button_options";
			this.button_options.Size = new System.Drawing.Size(34, 34);
			this.button_options.TabIndex = 18;
			this.button_options.UseVisualStyleBackColor = true;
			this.button_options.Click += new System.EventHandler(this.button_options_Click);
			// 
			// listBox_log
			// 
			this.listBox_log.BackColor = System.Drawing.Color.Black;
			this.listBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox_log.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox_log.ForeColor = System.Drawing.Color.DimGray;
			this.listBox_log.FormattingEnabled = true;
			this.listBox_log.Location = new System.Drawing.Point(0, 22);
			this.listBox_log.Name = "listBox_log";
			this.listBox_log.ScrollAlwaysVisible = true;
			this.listBox_log.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBox_log.Size = new System.Drawing.Size(762, 260);
			this.listBox_log.TabIndex = 15;
			this.listBox_log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_log_KeyDown);
			// 
			// panel_controls
			// 
			this.panel_controls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_controls.Controls.Add(this.button_mine);
			this.panel_controls.Controls.Add(this.groupBox_hashRate);
			this.panel_controls.Controls.Add(this.groupBox_shares);
			this.panel_controls.Location = new System.Drawing.Point(-1, 288);
			this.panel_controls.Name = "panel_controls";
			this.panel_controls.Size = new System.Drawing.Size(747, 94);
			this.panel_controls.TabIndex = 20;
			// 
			// button_mine
			// 
			this.button_mine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.button_mine.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.button_mine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_mine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
			this.button_mine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_mine.Location = new System.Drawing.Point(273, 21);
			this.button_mine.Name = "button_mine";
			this.button_mine.Size = new System.Drawing.Size(198, 51);
			this.button_mine.TabIndex = 21;
			this.button_mine.Text = "START MINING";
			this.button_mine.UseVisualStyleBackColor = false;
			this.button_mine.Click += new System.EventHandler(this.button_mine_Click);
			// 
			// groupBox_hashRate
			// 
			this.groupBox_hashRate.Controls.Add(this.label_hashRate);
			this.groupBox_hashRate.Controls.Add(this.label_maxHashRate);
			this.groupBox_hashRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_hashRate.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_hashRate.Location = new System.Drawing.Point(11, 6);
			this.groupBox_hashRate.Name = "groupBox_hashRate";
			this.groupBox_hashRate.Size = new System.Drawing.Size(240, 80);
			this.groupBox_hashRate.TabIndex = 21;
			this.groupBox_hashRate.TabStop = false;
			this.groupBox_hashRate.Text = "Hash rate";
			// 
			// label_hashRate
			// 
			this.label_hashRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_hashRate.ForeColor = System.Drawing.Color.Snow;
			this.label_hashRate.Location = new System.Drawing.Point(6, 17);
			this.label_hashRate.Name = "label_hashRate";
			this.label_hashRate.Size = new System.Drawing.Size(228, 34);
			this.label_hashRate.TabIndex = 19;
			this.label_hashRate.Text = "- H/s";
			this.label_hashRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_maxHashRate
			// 
			this.label_maxHashRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_maxHashRate.ForeColor = System.Drawing.Color.Snow;
			this.label_maxHashRate.Location = new System.Drawing.Point(6, 51);
			this.label_maxHashRate.Name = "label_maxHashRate";
			this.label_maxHashRate.Size = new System.Drawing.Size(228, 12);
			this.label_maxHashRate.TabIndex = 19;
			this.label_maxHashRate.Text = "Session record: - H/s";
			this.label_maxHashRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox_shares
			// 
			this.groupBox_shares.Controls.Add(this.label_lastValid);
			this.groupBox_shares.Controls.Add(this.label_shares);
			this.groupBox_shares.Controls.Add(this.label_sharesInfo);
			this.groupBox_shares.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_shares.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_shares.Location = new System.Drawing.Point(494, 6);
			this.groupBox_shares.Name = "groupBox_shares";
			this.groupBox_shares.Size = new System.Drawing.Size(240, 80);
			this.groupBox_shares.TabIndex = 20;
			this.groupBox_shares.TabStop = false;
			this.groupBox_shares.Text = "Shares";
			// 
			// label_lastValid
			// 
			this.label_lastValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_lastValid.ForeColor = System.Drawing.Color.Snow;
			this.label_lastValid.Location = new System.Drawing.Point(6, 59);
			this.label_lastValid.Name = "label_lastValid";
			this.label_lastValid.Size = new System.Drawing.Size(228, 12);
			this.label_lastValid.TabIndex = 20;
			this.label_lastValid.Text = "Last valid: - s ago";
			this.label_lastValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_shares
			// 
			this.label_shares.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_shares.ForeColor = System.Drawing.Color.Snow;
			this.label_shares.Location = new System.Drawing.Point(6, 10);
			this.label_shares.Name = "label_shares";
			this.label_shares.Size = new System.Drawing.Size(228, 34);
			this.label_shares.TabIndex = 19;
			this.label_shares.Text = "- / -";
			this.label_shares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_sharesInfo
			// 
			this.label_sharesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_sharesInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_sharesInfo.Location = new System.Drawing.Point(6, 43);
			this.label_sharesInfo.Name = "label_sharesInfo";
			this.label_sharesInfo.Size = new System.Drawing.Size(228, 12);
			this.label_sharesInfo.TabIndex = 19;
			this.label_sharesInfo.Text = "Valid / Invalid";
			this.label_sharesInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_xmrValue
			// 
			this.label_xmrValue.AutoEllipsis = true;
			this.label_xmrValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_xmrValue.ForeColor = System.Drawing.Color.Snow;
			this.label_xmrValue.Location = new System.Drawing.Point(4, 388);
			this.label_xmrValue.Name = "label_xmrValue";
			this.label_xmrValue.Size = new System.Drawing.Size(559, 25);
			this.label_xmrValue.TabIndex = 12;
			this.label_xmrValue.Text = "XMR Value: 0.00 (+0.00) EUR";
			this.label_xmrValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label_xmrValue.Paint += new System.Windows.Forms.PaintEventHandler(this.label_xmrValue_Paint);
			// 
			// button_statistics
			// 
			this.button_statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_statistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_statistics.Location = new System.Drawing.Point(609, 387);
			this.button_statistics.Name = "button_statistics";
			this.button_statistics.Size = new System.Drawing.Size(132, 28);
			this.button_statistics.TabIndex = 23;
			this.button_statistics.Text = "STATISTICS";
			this.button_statistics.UseVisualStyleBackColor = true;
			this.button_statistics.Click += new System.EventHandler(this.button_statistics_Click);
			// 
			// timer_refreshLatestShareTimer
			// 
			this.timer_refreshLatestShareTimer.Interval = 1000;
			this.timer_refreshLatestShareTimer.Tick += new System.EventHandler(this.timer_refreshLatestShareTimer_Tick);
			// 
			// timer_miningTimeCounter
			// 
			this.timer_miningTimeCounter.Interval = 1000;
			this.timer_miningTimeCounter.Tick += new System.EventHandler(this.timer_miningTimeCounter_Tick);
			// 
			// timer_save
			// 
			this.timer_save.Enabled = true;
			this.timer_save.Interval = 30000;
			this.timer_save.Tick += new System.EventHandler(this.timer_save_Tick);
			// 
			// timer_refreshXmrPrice
			// 
			this.timer_refreshXmrPrice.Enabled = true;
			this.timer_refreshXmrPrice.Interval = 10000;
			this.timer_refreshXmrPrice.Tick += new System.EventHandler(this.timer_refreshXmrPrice_Tick);
			// 
			// Miner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.ClientSize = new System.Drawing.Size(747, 422);
			this.Controls.Add(this.panel_background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Miner";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChillinRoom GMG";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Miner_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.panel_background.ResumeLayout(false);
			this.panel_controls.ResumeLayout(false);
			this.groupBox_hashRate.ResumeLayout(false);
			this.groupBox_shares.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_background;
		private Controls.PixelTitleBar titleBar;
		private System.Windows.Forms.ListBox listBox_log;
		private System.Windows.Forms.Label label_shares;
		private System.Windows.Forms.Label label_sharesInfo;
		private System.Windows.Forms.Panel panel_controls;
		private System.Windows.Forms.GroupBox groupBox_shares;
		private System.Windows.Forms.GroupBox groupBox_hashRate;
		private System.Windows.Forms.Label label_hashRate;
		private System.Windows.Forms.Label label_maxHashRate;
		private System.Windows.Forms.Label label_lastValid;
		private System.Windows.Forms.Timer timer_refreshLatestShareTimer;
		private System.Windows.Forms.Button button_mine;
		private System.Windows.Forms.Button button_statistics;
		private System.Windows.Forms.Timer timer_miningTimeCounter;
		private System.Windows.Forms.Button button_options;
		private System.Windows.Forms.Timer timer_save;
		private System.Windows.Forms.Timer timer_refreshXmrPrice;
		private System.Windows.Forms.Label label_xmrValue;
	}
}

