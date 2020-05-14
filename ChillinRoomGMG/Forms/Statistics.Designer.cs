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
			this.groupBox_totalPoolShares = new System.Windows.Forms.GroupBox();
			this.label_totalPoolShares = new System.Windows.Forms.Label();
			this.label_totalPoolSharesInfo = new System.Windows.Forms.Label();
			this.groupBox_averageHashRate = new System.Windows.Forms.GroupBox();
			this.label_averageHashRate = new System.Windows.Forms.Label();
			this.label_averageHashRateInfo = new System.Windows.Forms.Label();
			this.groupBox_hashRateRecord = new System.Windows.Forms.GroupBox();
			this.label_hashRateRecord = new System.Windows.Forms.Label();
			this.label_hashRateRecordInfo = new System.Windows.Forms.Label();
			this.groupBox_timeMined = new System.Windows.Forms.GroupBox();
			this.label_timeMined = new System.Windows.Forms.Label();
			this.label_timeMinedInfo = new System.Windows.Forms.Label();
			this.groupBox_totalHashes = new System.Windows.Forms.GroupBox();
			this.label_totalHashes = new System.Windows.Forms.Label();
			this.label_totalHashesInfo = new System.Windows.Forms.Label();
			this.groupBox_calculator = new System.Windows.Forms.GroupBox();
			this.label_earningsHashRate = new System.Windows.Forms.Label();
			this.numeric_hashRate = new System.Windows.Forms.NumericUpDown();
			this.comboBox_hashRates = new System.Windows.Forms.ComboBox();
			this.label_hourly = new System.Windows.Forms.Label();
			this.label_daily = new System.Windows.Forms.Label();
			this.label_weekly = new System.Windows.Forms.Label();
			this.label_monthly = new System.Windows.Forms.Label();
			this.label_yearly = new System.Windows.Forms.Label();
			this.panel_earnings = new System.Windows.Forms.Panel();
			this.panel_hourlyEarnings = new System.Windows.Forms.Panel();
			this.label_hourlyEarnings = new System.Windows.Forms.Label();
			this.label_hourlyInfo = new System.Windows.Forms.Label();
			this.panel_dailyEarnings = new System.Windows.Forms.Panel();
			this.label_dailyEarnings = new System.Windows.Forms.Label();
			this.label_dailyInfo = new System.Windows.Forms.Label();
			this.panel_weeklyEarnings = new System.Windows.Forms.Panel();
			this.label_weeklyEarnings = new System.Windows.Forms.Label();
			this.label_weeklyInfo = new System.Windows.Forms.Label();
			this.panel_monthlyEarnings = new System.Windows.Forms.Panel();
			this.label_monthlyEarnings = new System.Windows.Forms.Label();
			this.label_monthlyInfo = new System.Windows.Forms.Label();
			this.panel_yearlyEarnings = new System.Windows.Forms.Panel();
			this.label_yearlyEarnings = new System.Windows.Forms.Label();
			this.label_yearlyInfo = new System.Windows.Forms.Label();
			this.timer_refresh = new System.Windows.Forms.Timer(this.components);
			this.panel_background.SuspendLayout();
			this.groupBox_totalShares.SuspendLayout();
			this.groupBox_totalPoolShares.SuspendLayout();
			this.groupBox_averageHashRate.SuspendLayout();
			this.groupBox_hashRateRecord.SuspendLayout();
			this.groupBox_timeMined.SuspendLayout();
			this.groupBox_totalHashes.SuspendLayout();
			this.groupBox_calculator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_hashRate)).BeginInit();
			this.panel_earnings.SuspendLayout();
			this.panel_hourlyEarnings.SuspendLayout();
			this.panel_dailyEarnings.SuspendLayout();
			this.panel_weeklyEarnings.SuspendLayout();
			this.panel_monthlyEarnings.SuspendLayout();
			this.panel_yearlyEarnings.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel_background
			// 
			this.panel_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_background.Controls.Add(this.titleBar);
			this.panel_background.Controls.Add(this.groupBox_totalShares);
			this.panel_background.Controls.Add(this.groupBox_totalPoolShares);
			this.panel_background.Controls.Add(this.groupBox_averageHashRate);
			this.panel_background.Controls.Add(this.groupBox_hashRateRecord);
			this.panel_background.Controls.Add(this.groupBox_timeMined);
			this.panel_background.Controls.Add(this.groupBox_totalHashes);
			this.panel_background.Controls.Add(this.groupBox_calculator);
			this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_background.Location = new System.Drawing.Point(0, 0);
			this.panel_background.Name = "panel_background";
			this.panel_background.Size = new System.Drawing.Size(524, 432);
			this.panel_background.TabIndex = 1;
			// 
			// titleBar
			// 
			this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleBar.Location = new System.Drawing.Point(0, 0);
			this.titleBar.Name = "titleBar";
			this.titleBar.ShowMinimizeButton = false;
			this.titleBar.Size = new System.Drawing.Size(522, 22);
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
			// groupBox_totalPoolShares
			// 
			this.groupBox_totalPoolShares.Controls.Add(this.label_totalPoolShares);
			this.groupBox_totalPoolShares.Controls.Add(this.label_totalPoolSharesInfo);
			this.groupBox_totalPoolShares.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_totalPoolShares.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_totalPoolShares.Location = new System.Drawing.Point(270, 28);
			this.groupBox_totalPoolShares.Name = "groupBox_totalPoolShares";
			this.groupBox_totalPoolShares.Size = new System.Drawing.Size(240, 80);
			this.groupBox_totalPoolShares.TabIndex = 26;
			this.groupBox_totalPoolShares.TabStop = false;
			this.groupBox_totalPoolShares.Text = "Total pool shares (according to pool)";
			// 
			// label_totalPoolShares
			// 
			this.label_totalPoolShares.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_totalPoolShares.ForeColor = System.Drawing.Color.Snow;
			this.label_totalPoolShares.Location = new System.Drawing.Point(6, 19);
			this.label_totalPoolShares.Name = "label_totalPoolShares";
			this.label_totalPoolShares.Size = new System.Drawing.Size(228, 34);
			this.label_totalPoolShares.TabIndex = 20;
			this.label_totalPoolShares.Text = "0 / 0";
			this.label_totalPoolShares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_totalPoolSharesInfo
			// 
			this.label_totalPoolSharesInfo.AutoSize = true;
			this.label_totalPoolSharesInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_totalPoolSharesInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_totalPoolSharesInfo.Location = new System.Drawing.Point(88, 53);
			this.label_totalPoolSharesInfo.Name = "label_totalPoolSharesInfo";
			this.label_totalPoolSharesInfo.Size = new System.Drawing.Size(75, 13);
			this.label_totalPoolSharesInfo.TabIndex = 17;
			this.label_totalPoolSharesInfo.Text = "Valid / Invalid";
			// 
			// groupBox_averageHashRate
			// 
			this.groupBox_averageHashRate.Controls.Add(this.label_averageHashRate);
			this.groupBox_averageHashRate.Controls.Add(this.label_averageHashRateInfo);
			this.groupBox_averageHashRate.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_averageHashRate.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_averageHashRate.Location = new System.Drawing.Point(12, 114);
			this.groupBox_averageHashRate.Name = "groupBox_averageHashRate";
			this.groupBox_averageHashRate.Size = new System.Drawing.Size(240, 80);
			this.groupBox_averageHashRate.TabIndex = 24;
			this.groupBox_averageHashRate.TabStop = false;
			this.groupBox_averageHashRate.Text = "Average Hash Rate (according to pool)";
			// 
			// label_averageHashRate
			// 
			this.label_averageHashRate.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_averageHashRate.ForeColor = System.Drawing.Color.Snow;
			this.label_averageHashRate.Location = new System.Drawing.Point(6, 19);
			this.label_averageHashRate.Name = "label_averageHashRate";
			this.label_averageHashRate.Size = new System.Drawing.Size(228, 34);
			this.label_averageHashRate.TabIndex = 20;
			this.label_averageHashRate.Text = "0.0 H/s";
			this.label_averageHashRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_averageHashRateInfo
			// 
			this.label_averageHashRateInfo.AutoSize = true;
			this.label_averageHashRateInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_averageHashRateInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_averageHashRateInfo.Location = new System.Drawing.Point(88, 53);
			this.label_averageHashRateInfo.Name = "label_averageHashRateInfo";
			this.label_averageHashRateInfo.Size = new System.Drawing.Size(69, 13);
			this.label_averageHashRateInfo.TabIndex = 17;
			this.label_averageHashRateInfo.Text = "Average H/s";
			// 
			// groupBox_hashRateRecord
			// 
			this.groupBox_hashRateRecord.Controls.Add(this.label_hashRateRecord);
			this.groupBox_hashRateRecord.Controls.Add(this.label_hashRateRecordInfo);
			this.groupBox_hashRateRecord.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_hashRateRecord.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_hashRateRecord.Location = new System.Drawing.Point(270, 114);
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
			// groupBox_totalHashes
			// 
			this.groupBox_totalHashes.Controls.Add(this.label_totalHashes);
			this.groupBox_totalHashes.Controls.Add(this.label_totalHashesInfo);
			this.groupBox_totalHashes.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_totalHashes.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_totalHashes.Location = new System.Drawing.Point(270, 200);
			this.groupBox_totalHashes.Name = "groupBox_totalHashes";
			this.groupBox_totalHashes.Size = new System.Drawing.Size(240, 80);
			this.groupBox_totalHashes.TabIndex = 25;
			this.groupBox_totalHashes.TabStop = false;
			this.groupBox_totalHashes.Text = "Total hashes (according to pool)";
			// 
			// label_totalHashes
			// 
			this.label_totalHashes.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_totalHashes.ForeColor = System.Drawing.Color.Snow;
			this.label_totalHashes.Location = new System.Drawing.Point(6, 19);
			this.label_totalHashes.Name = "label_totalHashes";
			this.label_totalHashes.Size = new System.Drawing.Size(228, 34);
			this.label_totalHashes.TabIndex = 20;
			this.label_totalHashes.Text = "0 H";
			this.label_totalHashes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_totalHashesInfo
			// 
			this.label_totalHashesInfo.AutoSize = true;
			this.label_totalHashesInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_totalHashesInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_totalHashesInfo.Location = new System.Drawing.Point(88, 53);
			this.label_totalHashesInfo.Name = "label_totalHashesInfo";
			this.label_totalHashesInfo.Size = new System.Drawing.Size(73, 13);
			this.label_totalHashesInfo.TabIndex = 17;
			this.label_totalHashesInfo.Text = "Total Hashes";
			// 
			// groupBox_calculator
			// 
			this.groupBox_calculator.Controls.Add(this.label_earningsHashRate);
			this.groupBox_calculator.Controls.Add(this.numeric_hashRate);
			this.groupBox_calculator.Controls.Add(this.comboBox_hashRates);
			this.groupBox_calculator.Controls.Add(this.label_hourly);
			this.groupBox_calculator.Controls.Add(this.label_daily);
			this.groupBox_calculator.Controls.Add(this.label_weekly);
			this.groupBox_calculator.Controls.Add(this.label_monthly);
			this.groupBox_calculator.Controls.Add(this.label_yearly);
			this.groupBox_calculator.Controls.Add(this.panel_earnings);
			this.groupBox_calculator.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox_calculator.ForeColor = System.Drawing.Color.Snow;
			this.groupBox_calculator.Location = new System.Drawing.Point(12, 286);
			this.groupBox_calculator.Name = "groupBox_calculator";
			this.groupBox_calculator.Size = new System.Drawing.Size(499, 134);
			this.groupBox_calculator.TabIndex = 25;
			this.groupBox_calculator.TabStop = false;
			this.groupBox_calculator.Text = "Calculator";
			// 
			// label_earningsHashRate
			// 
			this.label_earningsHashRate.AutoSize = true;
			this.label_earningsHashRate.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_earningsHashRate.ForeColor = System.Drawing.Color.Snow;
			this.label_earningsHashRate.Location = new System.Drawing.Point(28, 23);
			this.label_earningsHashRate.Name = "label_earningsHashRate";
			this.label_earningsHashRate.Size = new System.Drawing.Size(88, 13);
			this.label_earningsHashRate.TabIndex = 21;
			this.label_earningsHashRate.Text = "Your Hash Rate:";
			// 
			// numeric_hashRate
			// 
			this.numeric_hashRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.numeric_hashRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numeric_hashRate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
			this.numeric_hashRate.Location = new System.Drawing.Point(122, 18);
			this.numeric_hashRate.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.numeric_hashRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numeric_hashRate.Name = "numeric_hashRate";
			this.numeric_hashRate.Size = new System.Drawing.Size(127, 23);
			this.numeric_hashRate.TabIndex = 36;
			this.numeric_hashRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numeric_hashRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numeric_hashRate.ValueChanged += new System.EventHandler(this.CalculateEarnings);
			// 
			// comboBox_hashRates
			// 
			this.comboBox_hashRates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.comboBox_hashRates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_hashRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBox_hashRates.ForeColor = System.Drawing.Color.Snow;
			this.comboBox_hashRates.FormattingEnabled = true;
			this.comboBox_hashRates.Items.AddRange(new object[] {
            "H/s",
            "kH/s",
            "MH/s"});
			this.comboBox_hashRates.Location = new System.Drawing.Point(255, 19);
			this.comboBox_hashRates.Name = "comboBox_hashRates";
			this.comboBox_hashRates.Size = new System.Drawing.Size(90, 21);
			this.comboBox_hashRates.TabIndex = 35;
			this.comboBox_hashRates.TextChanged += new System.EventHandler(this.CalculateEarnings);
			// 
			// label_hourly
			// 
			this.label_hourly.AutoSize = true;
			this.label_hourly.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_hourly.ForeColor = System.Drawing.Color.Snow;
			this.label_hourly.Location = new System.Drawing.Point(20, 49);
			this.label_hourly.Name = "label_hourly";
			this.label_hourly.Size = new System.Drawing.Size(69, 19);
			this.label_hourly.TabIndex = 24;
			this.label_hourly.Text = "HOURLY";
			this.label_hourly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_daily
			// 
			this.label_daily.AutoSize = true;
			this.label_daily.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_daily.ForeColor = System.Drawing.Color.Snow;
			this.label_daily.Location = new System.Drawing.Point(125, 49);
			this.label_daily.Name = "label_daily";
			this.label_daily.Size = new System.Drawing.Size(52, 19);
			this.label_daily.TabIndex = 23;
			this.label_daily.Text = "DAILY";
			this.label_daily.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_weekly
			// 
			this.label_weekly.AutoSize = true;
			this.label_weekly.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_weekly.ForeColor = System.Drawing.Color.Snow;
			this.label_weekly.Location = new System.Drawing.Point(212, 49);
			this.label_weekly.Name = "label_weekly";
			this.label_weekly.Size = new System.Drawing.Size(68, 19);
			this.label_weekly.TabIndex = 22;
			this.label_weekly.Text = "WEEKLY";
			this.label_weekly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_monthly
			// 
			this.label_monthly.AutoSize = true;
			this.label_monthly.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_monthly.ForeColor = System.Drawing.Color.Snow;
			this.label_monthly.Location = new System.Drawing.Point(304, 49);
			this.label_monthly.Name = "label_monthly";
			this.label_monthly.Size = new System.Drawing.Size(83, 19);
			this.label_monthly.TabIndex = 21;
			this.label_monthly.Text = "MONTHLY";
			this.label_monthly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_yearly
			// 
			this.label_yearly.AutoSize = true;
			this.label_yearly.Font = new System.Drawing.Font("Roboto", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_yearly.ForeColor = System.Drawing.Color.Snow;
			this.label_yearly.Location = new System.Drawing.Point(409, 49);
			this.label_yearly.Name = "label_yearly";
			this.label_yearly.Size = new System.Drawing.Size(66, 19);
			this.label_yearly.TabIndex = 22;
			this.label_yearly.Text = "YEARLY";
			this.label_yearly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel_earnings
			// 
			this.panel_earnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_earnings.Controls.Add(this.panel_hourlyEarnings);
			this.panel_earnings.Controls.Add(this.panel_dailyEarnings);
			this.panel_earnings.Controls.Add(this.panel_weeklyEarnings);
			this.panel_earnings.Controls.Add(this.panel_monthlyEarnings);
			this.panel_earnings.Controls.Add(this.panel_yearlyEarnings);
			this.panel_earnings.Location = new System.Drawing.Point(7, 71);
			this.panel_earnings.Name = "panel_earnings";
			this.panel_earnings.Size = new System.Drawing.Size(484, 52);
			this.panel_earnings.TabIndex = 34;
			// 
			// panel_hourlyEarnings
			// 
			this.panel_hourlyEarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_hourlyEarnings.Controls.Add(this.label_hourlyEarnings);
			this.panel_hourlyEarnings.Controls.Add(this.label_hourlyInfo);
			this.panel_hourlyEarnings.Location = new System.Drawing.Point(-1, -1);
			this.panel_hourlyEarnings.Name = "panel_hourlyEarnings";
			this.panel_hourlyEarnings.Size = new System.Drawing.Size(96, 52);
			this.panel_hourlyEarnings.TabIndex = 0;
			// 
			// label_hourlyEarnings
			// 
			this.label_hourlyEarnings.AutoEllipsis = true;
			this.label_hourlyEarnings.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_hourlyEarnings.ForeColor = System.Drawing.Color.Snow;
			this.label_hourlyEarnings.Location = new System.Drawing.Point(4, 7);
			this.label_hourlyEarnings.Name = "label_hourlyEarnings";
			this.label_hourlyEarnings.Size = new System.Drawing.Size(86, 19);
			this.label_hourlyEarnings.TabIndex = 25;
			this.label_hourlyEarnings.Text = "0.0000000";
			this.label_hourlyEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_hourlyInfo
			// 
			this.label_hourlyInfo.AutoSize = true;
			this.label_hourlyInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_hourlyInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_hourlyInfo.Location = new System.Drawing.Point(18, 30);
			this.label_hourlyInfo.Name = "label_hourlyInfo";
			this.label_hourlyInfo.Size = new System.Drawing.Size(58, 13);
			this.label_hourlyInfo.TabIndex = 21;
			this.label_hourlyInfo.Text = "XMR/hour";
			// 
			// panel_dailyEarnings
			// 
			this.panel_dailyEarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_dailyEarnings.Controls.Add(this.label_dailyEarnings);
			this.panel_dailyEarnings.Controls.Add(this.label_dailyInfo);
			this.panel_dailyEarnings.Location = new System.Drawing.Point(96, -1);
			this.panel_dailyEarnings.Name = "panel_dailyEarnings";
			this.panel_dailyEarnings.Size = new System.Drawing.Size(96, 52);
			this.panel_dailyEarnings.TabIndex = 1;
			// 
			// label_dailyEarnings
			// 
			this.label_dailyEarnings.AutoEllipsis = true;
			this.label_dailyEarnings.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_dailyEarnings.ForeColor = System.Drawing.Color.Snow;
			this.label_dailyEarnings.Location = new System.Drawing.Point(4, 7);
			this.label_dailyEarnings.Name = "label_dailyEarnings";
			this.label_dailyEarnings.Size = new System.Drawing.Size(86, 19);
			this.label_dailyEarnings.TabIndex = 26;
			this.label_dailyEarnings.Text = "0.0000000";
			this.label_dailyEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_dailyInfo
			// 
			this.label_dailyInfo.AutoSize = true;
			this.label_dailyInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_dailyInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_dailyInfo.Location = new System.Drawing.Point(21, 30);
			this.label_dailyInfo.Name = "label_dailyInfo";
			this.label_dailyInfo.Size = new System.Drawing.Size(53, 13);
			this.label_dailyInfo.TabIndex = 26;
			this.label_dailyInfo.Text = "XMR/day";
			// 
			// panel_weeklyEarnings
			// 
			this.panel_weeklyEarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_weeklyEarnings.Controls.Add(this.label_weeklyEarnings);
			this.panel_weeklyEarnings.Controls.Add(this.label_weeklyInfo);
			this.panel_weeklyEarnings.Location = new System.Drawing.Point(193, -1);
			this.panel_weeklyEarnings.Name = "panel_weeklyEarnings";
			this.panel_weeklyEarnings.Size = new System.Drawing.Size(96, 52);
			this.panel_weeklyEarnings.TabIndex = 35;
			// 
			// label_weeklyEarnings
			// 
			this.label_weeklyEarnings.AutoEllipsis = true;
			this.label_weeklyEarnings.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_weeklyEarnings.ForeColor = System.Drawing.Color.Snow;
			this.label_weeklyEarnings.Location = new System.Drawing.Point(4, 7);
			this.label_weeklyEarnings.Name = "label_weeklyEarnings";
			this.label_weeklyEarnings.Size = new System.Drawing.Size(86, 19);
			this.label_weeklyEarnings.TabIndex = 27;
			this.label_weeklyEarnings.Text = "0.0000000";
			this.label_weeklyEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_weeklyInfo
			// 
			this.label_weeklyInfo.AutoSize = true;
			this.label_weeklyInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_weeklyInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_weeklyInfo.Location = new System.Drawing.Point(16, 30);
			this.label_weeklyInfo.Name = "label_weeklyInfo";
			this.label_weeklyInfo.Size = new System.Drawing.Size(62, 13);
			this.label_weeklyInfo.TabIndex = 27;
			this.label_weeklyInfo.Text = "XMR/week";
			// 
			// panel_monthlyEarnings
			// 
			this.panel_monthlyEarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_monthlyEarnings.Controls.Add(this.label_monthlyEarnings);
			this.panel_monthlyEarnings.Controls.Add(this.label_monthlyInfo);
			this.panel_monthlyEarnings.Location = new System.Drawing.Point(290, -1);
			this.panel_monthlyEarnings.Name = "panel_monthlyEarnings";
			this.panel_monthlyEarnings.Size = new System.Drawing.Size(96, 52);
			this.panel_monthlyEarnings.TabIndex = 1;
			// 
			// label_monthlyEarnings
			// 
			this.label_monthlyEarnings.AutoEllipsis = true;
			this.label_monthlyEarnings.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_monthlyEarnings.ForeColor = System.Drawing.Color.Snow;
			this.label_monthlyEarnings.Location = new System.Drawing.Point(4, 7);
			this.label_monthlyEarnings.Name = "label_monthlyEarnings";
			this.label_monthlyEarnings.Size = new System.Drawing.Size(86, 19);
			this.label_monthlyEarnings.TabIndex = 28;
			this.label_monthlyEarnings.Text = "0.0000000";
			this.label_monthlyEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_monthlyInfo
			// 
			this.label_monthlyInfo.AutoSize = true;
			this.label_monthlyInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_monthlyInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_monthlyInfo.Location = new System.Drawing.Point(13, 30);
			this.label_monthlyInfo.Name = "label_monthlyInfo";
			this.label_monthlyInfo.Size = new System.Drawing.Size(68, 13);
			this.label_monthlyInfo.TabIndex = 28;
			this.label_monthlyInfo.Text = "XMR/month";
			// 
			// panel_yearlyEarnings
			// 
			this.panel_yearlyEarnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_yearlyEarnings.Controls.Add(this.label_yearlyEarnings);
			this.panel_yearlyEarnings.Controls.Add(this.label_yearlyInfo);
			this.panel_yearlyEarnings.Location = new System.Drawing.Point(387, -1);
			this.panel_yearlyEarnings.Name = "panel_yearlyEarnings";
			this.panel_yearlyEarnings.Size = new System.Drawing.Size(96, 52);
			this.panel_yearlyEarnings.TabIndex = 1;
			// 
			// label_yearlyEarnings
			// 
			this.label_yearlyEarnings.AutoEllipsis = true;
			this.label_yearlyEarnings.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_yearlyEarnings.ForeColor = System.Drawing.Color.Snow;
			this.label_yearlyEarnings.Location = new System.Drawing.Point(4, 7);
			this.label_yearlyEarnings.Name = "label_yearlyEarnings";
			this.label_yearlyEarnings.Size = new System.Drawing.Size(86, 19);
			this.label_yearlyEarnings.TabIndex = 29;
			this.label_yearlyEarnings.Text = "0.0000000";
			this.label_yearlyEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label_yearlyInfo
			// 
			this.label_yearlyInfo.AutoSize = true;
			this.label_yearlyInfo.Font = new System.Drawing.Font("Roboto", 8.25F);
			this.label_yearlyInfo.ForeColor = System.Drawing.Color.Snow;
			this.label_yearlyInfo.Location = new System.Drawing.Point(19, 30);
			this.label_yearlyInfo.Name = "label_yearlyInfo";
			this.label_yearlyInfo.Size = new System.Drawing.Size(57, 13);
			this.label_yearlyInfo.TabIndex = 29;
			this.label_yearlyInfo.Text = "XMR/year";
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
			this.ClientSize = new System.Drawing.Size(524, 432);
			this.Controls.Add(this.panel_background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Statistics";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Statistics";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Statistics_FormClosed);
			this.Load += new System.EventHandler(this.Statistics_Load);
			this.panel_background.ResumeLayout(false);
			this.groupBox_totalShares.ResumeLayout(false);
			this.groupBox_totalShares.PerformLayout();
			this.groupBox_totalPoolShares.ResumeLayout(false);
			this.groupBox_totalPoolShares.PerformLayout();
			this.groupBox_averageHashRate.ResumeLayout(false);
			this.groupBox_averageHashRate.PerformLayout();
			this.groupBox_hashRateRecord.ResumeLayout(false);
			this.groupBox_hashRateRecord.PerformLayout();
			this.groupBox_timeMined.ResumeLayout(false);
			this.groupBox_timeMined.PerformLayout();
			this.groupBox_totalHashes.ResumeLayout(false);
			this.groupBox_totalHashes.PerformLayout();
			this.groupBox_calculator.ResumeLayout(false);
			this.groupBox_calculator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numeric_hashRate)).EndInit();
			this.panel_earnings.ResumeLayout(false);
			this.panel_hourlyEarnings.ResumeLayout(false);
			this.panel_hourlyEarnings.PerformLayout();
			this.panel_dailyEarnings.ResumeLayout(false);
			this.panel_dailyEarnings.PerformLayout();
			this.panel_weeklyEarnings.ResumeLayout(false);
			this.panel_weeklyEarnings.PerformLayout();
			this.panel_monthlyEarnings.ResumeLayout(false);
			this.panel_monthlyEarnings.PerformLayout();
			this.panel_yearlyEarnings.ResumeLayout(false);
			this.panel_yearlyEarnings.PerformLayout();
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
		private System.Windows.Forms.GroupBox groupBox_averageHashRate;
		private System.Windows.Forms.Label label_averageHashRate;
		private System.Windows.Forms.Label label_averageHashRateInfo;
		private System.Windows.Forms.GroupBox groupBox_totalHashes;
		private System.Windows.Forms.Label label_totalHashes;
		private System.Windows.Forms.Label label_totalHashesInfo;
		private System.Windows.Forms.GroupBox groupBox_totalPoolShares;
		private System.Windows.Forms.Label label_totalPoolShares;
		private System.Windows.Forms.Label label_totalPoolSharesInfo;
		private System.Windows.Forms.GroupBox groupBox_calculator;
		private System.Windows.Forms.Panel panel_earnings;
		private System.Windows.Forms.Panel panel_hourlyEarnings;
		private System.Windows.Forms.Panel panel_dailyEarnings;
		private System.Windows.Forms.Panel panel_weeklyEarnings;
		private System.Windows.Forms.Panel panel_monthlyEarnings;
		private System.Windows.Forms.Panel panel_yearlyEarnings;
		private System.Windows.Forms.Label label_earningsHashRate;
		private System.Windows.Forms.ComboBox comboBox_hashRates;
		private System.Windows.Forms.Label label_hourly;
		private System.Windows.Forms.Label label_daily;
		private System.Windows.Forms.Label label_weekly;
		private System.Windows.Forms.Label label_monthly;
		private System.Windows.Forms.Label label_yearly;
		private System.Windows.Forms.Label label_hourlyEarnings;
		private System.Windows.Forms.Label label_dailyEarnings;
		private System.Windows.Forms.Label label_weeklyEarnings;
		private System.Windows.Forms.Label label_monthlyEarnings;
		private System.Windows.Forms.Label label_yearlyEarnings;
		private System.Windows.Forms.Label label_hourlyInfo;
		private System.Windows.Forms.Label label_dailyInfo;
		private System.Windows.Forms.Label label_weeklyInfo;
		private System.Windows.Forms.Label label_monthlyInfo;
		private System.Windows.Forms.Label label_yearlyInfo;
		private System.Windows.Forms.NumericUpDown numeric_hashRate;
	}
}