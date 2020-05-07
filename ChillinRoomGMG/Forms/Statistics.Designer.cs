namespace ChillinRoomGMG.Forms
{
	partial class Statistics
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
			this.panel_background = new System.Windows.Forms.Panel();
			this.titleBar = new ChillinRoomGMG.Controls.PixelTitleBar();
			this.groupBox_totalShares = new System.Windows.Forms.GroupBox();
			this.label_totalShares = new System.Windows.Forms.Label();
			this.label_totalSharesInfo = new System.Windows.Forms.Label();
			this.groupBox_hashRateRecord = new System.Windows.Forms.GroupBox();
			this.label_hashRateRecord = new System.Windows.Forms.Label();
			this.label_hashRateRecordInfo = new System.Windows.Forms.Label();
			this.groupBox_timeMined = new System.Windows.Forms.GroupBox();
			this.label_timeMined = new System.Windows.Forms.Label();
			this.label_timeMinedInfo = new System.Windows.Forms.Label();
			this.timer_refresh = new System.Windows.Forms.Timer(this.components);
			this.panel_background.SuspendLayout();
			this.groupBox_totalShares.SuspendLayout();
			this.groupBox_hashRateRecord.SuspendLayout();
			this.groupBox_timeMined.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_background
			// 
			this.panel_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_background.Controls.Add(this.titleBar);
			this.panel_background.Controls.Add(this.groupBox_totalShares);
			this.panel_background.Controls.Add(this.groupBox_hashRateRecord);
			this.panel_background.Controls.Add(this.groupBox_timeMined);
			this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_background.Location = new System.Drawing.Point(0, 0);
			this.panel_background.Name = "panel_background";
			this.panel_background.Size = new System.Drawing.Size(267, 294);
			this.panel_background.TabIndex = 1;
			// 
			// titleBar
			// 
			this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Name = "titleBar";
			this.titleBar.ShowMinimizeButton = false;
			this.titleBar.Size = new System.Drawing.Size(265, 22);
			this.titleBar.TabIndex = 16;
			this.titleBar.TitleExtension = "Options";
			// 
			// groupBox_totalShares
			// 
			this.groupBox_totalShares.Controls.Add(this.label_totalShares);
			this.groupBox_totalShares.Controls.Add(this.label_totalSharesInfo);
			this.groupBox_totalShares.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_totalShares.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_totalShares.Location = new System.Drawing.Point(12, 28);
			this.groupBox_totalShares.Name = "groupBox_totalShares";
			this.groupBox_totalShares.Size = new System.Drawing.Size(240, 80);
			this.groupBox_totalShares.TabIndex = 22;
			this.groupBox_totalShares.TabStop = false;
			this.groupBox_totalShares.Text = "Total shares";
			// 
			// label_totalShares
			// 
			this.label_totalShares.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_totalShares.ForeColor = System.Drawing.Color.Snow;
			this.label_totalShares.Location = new System.Drawing.Point(6, 19);
			this.label_totalShares.Name = "label_totalShares";
			this.label_totalShares.Size = new System.Drawing.Size(228, 34);
			this.label_totalShares.TabIndex = 20;
			this.label_totalShares.Text = "0 / 0";
			this.label_totalShares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_totalSharesInfo
			// 
			this.label_totalSharesInfo.AutoSize = true;
			this.label_totalSharesInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_totalSharesInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_totalSharesInfo.Location = new System.Drawing.Point(83, 53);
			this.label_totalSharesInfo.Name = "label_totalSharesInfo";
			this.label_totalSharesInfo.Size = new System.Drawing.Size(75, 13);
			this.label_totalSharesInfo.TabIndex = 17;
			this.label_totalSharesInfo.Text = "Valid / Invalid";
			// 
			// groupBox_hashRateRecord
			// 
			this.groupBox_hashRateRecord.Controls.Add(this.label_hashRateRecord);
			this.groupBox_hashRateRecord.Controls.Add(this.label_hashRateRecordInfo);
			this.groupBox_hashRateRecord.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_hashRateRecord.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_hashRateRecord.Location = new System.Drawing.Point(12, 114);
			this.groupBox_hashRateRecord.Name = "groupBox_hashRateRecord";
			this.groupBox_hashRateRecord.Size = new System.Drawing.Size(240, 80);
			this.groupBox_hashRateRecord.TabIndex = 23;
			this.groupBox_hashRateRecord.TabStop = false;
			this.groupBox_hashRateRecord.Text = "Hash Rate record";
			// 
			// label_hashRateRecord
			// 
			this.label_hashRateRecord.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_hashRateRecord.ForeColor = System.Drawing.Color.Snow;
			this.label_hashRateRecord.Location = new System.Drawing.Point(6, 19);
			this.label_hashRateRecord.Name = "label_hashRateRecord";
			this.label_hashRateRecord.Size = new System.Drawing.Size(228, 34);
			this.label_hashRateRecord.TabIndex = 20;
			this.label_hashRateRecord.Text = "0.0 H/s";
			this.label_hashRateRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_hashRateRecordInfo
			// 
			this.label_hashRateRecordInfo.AutoSize = true;
			this.label_hashRateRecordInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_hashRateRecordInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_hashRateRecordInfo.Location = new System.Drawing.Point(88, 53);
			this.label_hashRateRecordInfo.Name = "label_hashRateRecordInfo";
			this.label_hashRateRecordInfo.Size = new System.Drawing.Size(64, 13);
			this.label_hashRateRecordInfo.TabIndex = 17;
			this.label_hashRateRecordInfo.Text = "Record H/s";
			// 
			// groupBox_timeMined
			// 
			this.groupBox_timeMined.Controls.Add(this.label_timeMined);
			this.groupBox_timeMined.Controls.Add(this.label_timeMinedInfo);
			this.groupBox_timeMined.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_timeMined.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_timeMined.Location = new System.Drawing.Point(12, 200);
			this.groupBox_timeMined.Name = "groupBox_timeMined";
			this.groupBox_timeMined.Size = new System.Drawing.Size(240, 80);
			this.groupBox_timeMined.TabIndex = 24;
			this.groupBox_timeMined.TabStop = false;
			this.groupBox_timeMined.Text = "Total time spent in mining";
			// 
			// label_timeMined
			// 
			this.label_timeMined.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_timeMined.ForeColor = System.Drawing.Color.Snow;
			this.label_timeMined.Location = new System.Drawing.Point(6, 19);
			this.label_timeMined.Name = "label_timeMined";
			this.label_timeMined.Size = new System.Drawing.Size(228, 34);
			this.label_timeMined.TabIndex = 20;
			this.label_timeMined.Text = "000 - 00:00:00";
			this.label_timeMined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_timeMinedInfo
			// 
			this.label_timeMinedInfo.AutoSize = true;
			this.label_timeMinedInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_timeMinedInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_timeMinedInfo.Location = new System.Drawing.Point(34, 53);
			this.label_timeMinedInfo.Name = "label_timeMinedInfo";
			this.label_timeMinedInfo.Size = new System.Drawing.Size(172, 13);
			this.label_timeMinedInfo.TabIndex = 17;
			this.label_timeMinedInfo.Text = "Days - Hours : Minutes : Seconds";
			// 
			// timer_refresh
			// 
			this.timer_refresh.Enabled = true;
			this.timer_refresh.Interval = 1000;
			this.timer_refresh.Tick += new System.EventHandler(this.RefreshStatistics);
			// 
			// Statistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.ClientSize = new System.Drawing.Size(267, 294);
			this.Controls.Add(this.panel_background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Statistics";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Statistics";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Statistics_FormClosed);
			this.Load += new System.EventHandler(this.RefreshStatistics);
			this.panel_background.ResumeLayout(false);
			this.groupBox_totalShares.ResumeLayout(false);
			this.groupBox_totalShares.PerformLayout();
			this.groupBox_hashRateRecord.ResumeLayout(false);
			this.groupBox_hashRateRecord.PerformLayout();
			this.groupBox_timeMined.ResumeLayout(false);
			this.groupBox_timeMined.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel_background;
		private Controls.PixelTitleBar titleBar;
		private System.Windows.Forms.Label label_totalSharesInfo;
		private System.Windows.Forms.Label label_totalShares;
		private System.Windows.Forms.GroupBox groupBox_totalShares;
		private System.Windows.Forms.GroupBox groupBox_hashRateRecord;
		private System.Windows.Forms.Label label_hashRateRecordInfo;
		private System.Windows.Forms.Label label_hashRateRecord;
		private System.Windows.Forms.GroupBox groupBox_timeMined;
		private System.Windows.Forms.Label label_timeMinedInfo;
		private System.Windows.Forms.Label label_timeMined;
		private System.Windows.Forms.Timer timer_refresh;
	}
}