namespace ChillinRoomGMG.Forms
{
	partial class Message
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
			this.label_message = new System.Windows.Forms.Label();
			this.button_hybrid = new System.Windows.Forms.Button();
			this.button_yes = new System.Windows.Forms.Button();
			this.panel_background = new System.Windows.Forms.Panel();
			this.pixelTitleBar1 = new ChillinRoomGMG.Controls.PixelTitleBar();
			this.panel_background.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_message
			// 
			this.label_message.AutoEllipsis = true;
			this.label_message.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_message.ForeColor = System.Drawing.Color.Snow;
			this.label_message.Location = new System.Drawing.Point(12, 34);
			this.label_message.Name = "label_message";
			this.label_message.Size = new System.Drawing.Size(392, 163);
			this.label_message.TabIndex = 1;
			this.label_message.Text = "<message>";
			this.label_message.UseMnemonic = false;
			// 
			// button_hybrid
			// 
			this.button_hybrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_hybrid.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_hybrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_hybrid.Location = new System.Drawing.Point(323, 209);
			this.button_hybrid.Name = "button_hybrid";
			this.button_hybrid.Size = new System.Drawing.Size(81, 28);
			this.button_hybrid.TabIndex = 8;
			this.button_hybrid.Text = "NO";
			this.button_hybrid.UseVisualStyleBackColor = true;
			this.button_hybrid.Click += new System.EventHandler(this.button_hybrid_Click);
			// 
			// button_yes
			// 
			this.button_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_yes.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(222)))));
			this.button_yes.Location = new System.Drawing.Point(226, 209);
			this.button_yes.Name = "button_yes";
			this.button_yes.Size = new System.Drawing.Size(81, 28);
			this.button_yes.TabIndex = 10;
			this.button_yes.Text = "YES";
			this.button_yes.UseVisualStyleBackColor = true;
			this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
			// 
			// panel_background
			// 
			this.panel_background.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_background.Controls.Add(this.pixelTitleBar1);
			this.panel_background.Controls.Add(this.label_message);
			this.panel_background.Controls.Add(this.button_hybrid);
			this.panel_background.Controls.Add(this.button_yes);
			this.panel_background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_background.Location = new System.Drawing.Point(0, 0);
			this.panel_background.Name = "panel_background";
			this.panel_background.Size = new System.Drawing.Size(416, 249);
			this.panel_background.TabIndex = 12;
			// 
			// pixelTitleBar1
			// 
			this.pixelTitleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.pixelTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pixelTitleBar1.Location = new System.Drawing.Point(0, 0);
			this.pixelTitleBar1.Name = "pixelTitleBar1";
			this.pixelTitleBar1.ShowMinimizeButton = true;
			this.pixelTitleBar1.Size = new System.Drawing.Size(414, 22);
			this.pixelTitleBar1.TabIndex = 11;
			this.pixelTitleBar1.TitleExtension = null;
			// 
			// Message
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
			this.ClientSize = new System.Drawing.Size(416, 249);
			this.Controls.Add(this.panel_background);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Message";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Message";
			this.panel_background.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label_message;
		private System.Windows.Forms.Button button_hybrid;
		private System.Windows.Forms.Button button_yes;
		private System.Windows.Forms.Panel panel_background;
		private Controls.PixelTitleBar pixelTitleBar1;
	}
}