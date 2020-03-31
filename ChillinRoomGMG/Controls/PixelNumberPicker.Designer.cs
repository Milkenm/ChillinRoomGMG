namespace ChillinRoomGMG.Controls
{
	partial class PixelNumberPicker
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label_value = new System.Windows.Forms.Label();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.panel_buttons = new System.Windows.Forms.Panel();
			this.pictureBox_buttonUp = new System.Windows.Forms.PictureBox();
			this.pictureBox_buttonDown = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.panel_buttons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buttonUp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buttonDown)).BeginInit();
			this.SuspendLayout();
			// 
			// label_value
			// 
			this.label_value.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_value.Location = new System.Drawing.Point(0, 0);
			this.label_value.Name = "label_value";
			this.label_value.Size = new System.Drawing.Size(61, 29);
			this.label_value.TabIndex = 4;
			this.label_value.Text = "0";
			this.label_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.label_value);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.panel_buttons);
			this.splitContainer.Size = new System.Drawing.Size(90, 29);
			this.splitContainer.SplitterDistance = 61;
			this.splitContainer.TabIndex = 5;
			// 
			// panel_buttons
			// 
			this.panel_buttons.Controls.Add(this.pictureBox_buttonUp);
			this.panel_buttons.Controls.Add(this.pictureBox_buttonDown);
			this.panel_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_buttons.Location = new System.Drawing.Point(0, 0);
			this.panel_buttons.Name = "panel_buttons";
			this.panel_buttons.Size = new System.Drawing.Size(25, 29);
			this.panel_buttons.TabIndex = 6;
			// 
			// pictureBox_buttonUp
			// 
			this.pictureBox_buttonUp.Image = global::ChillinRoomGMG.Properties.Resources.PixelArrowUp_PNG;
			this.pictureBox_buttonUp.Location = new System.Drawing.Point(3, 3);
			this.pictureBox_buttonUp.Name = "pictureBox_buttonUp";
			this.pictureBox_buttonUp.Size = new System.Drawing.Size(19, 10);
			this.pictureBox_buttonUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_buttonUp.TabIndex = 2;
			this.pictureBox_buttonUp.TabStop = false;
			this.pictureBox_buttonUp.Click += new System.EventHandler(this.pictureBox_buttonUp_Click);
			// 
			// pictureBox_buttonDown
			// 
			this.pictureBox_buttonDown.Image = global::ChillinRoomGMG.Properties.Resources.PixelArrowDown_PNG;
			this.pictureBox_buttonDown.Location = new System.Drawing.Point(3, 15);
			this.pictureBox_buttonDown.Name = "pictureBox_buttonDown";
			this.pictureBox_buttonDown.Size = new System.Drawing.Size(19, 10);
			this.pictureBox_buttonDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox_buttonDown.TabIndex = 3;
			this.pictureBox_buttonDown.TabStop = false;
			this.pictureBox_buttonDown.Click += new System.EventHandler(this.pictureBox_buttonDown_Click);
			// 
			// NumberPicker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "NumberPicker";
			this.Size = new System.Drawing.Size(90, 29);
			this.Load += new System.EventHandler(this.NumberPicker_Load);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.panel_buttons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buttonUp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_buttonDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label_value;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Panel panel_buttons;
		private System.Windows.Forms.PictureBox pictureBox_buttonUp;
		private System.Windows.Forms.PictureBox pictureBox_buttonDown;
	}
}
