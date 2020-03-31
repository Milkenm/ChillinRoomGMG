namespace ChillinRoomGMG.Controls
{
	partial class PixelCheckBox
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
			this.SuspendLayout();
			// 
			// PixelCheckBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ChillinRoomGMG.Properties.Resources.PixelCheckBoxUnchecked_PNG;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DoubleBuffered = true;
			this.Name = "PixelCheckBox";
			this.Size = new System.Drawing.Size(20, 20);
			this.Load += new System.EventHandler(this.PixelCheckBox_Load);
			this.Click += new System.EventHandler(this.PixelCheckBox_Click);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
