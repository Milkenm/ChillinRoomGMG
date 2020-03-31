using ChillinRoomGMG.Properties;

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChillinRoomGMG.Controls
{
	[DefaultEvent("CheckedChanged")]
	public partial class PixelCheckBox : UserControl
	{
		public delegate void EventDelegate();

		public event EventDelegate CheckedChanged;

		private bool @checked;

		public bool Checked
		{
			get { return @checked; }
			set
			{
				@checked = value;
				CheckedChanged?.Invoke();
				UpdateCheckBox();
			}
		}

		// PREVENT WINDOW WIDTH/HEIGHT CHANGE ## https://stackoverflow.com/a/47005249/10601212 ##
		protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
		{
			base.SetBoundsCore(x, y, 20, 20, specified);
		}

		public PixelCheckBox()
		{
			InitializeComponent();
		}

		private void PixelCheckBox_Load(object sender, EventArgs e)
		{
			UpdateCheckBox();
		}

		private void PixelCheckBox_Click(object sender, EventArgs e)
		{
			Checked = !Checked;
		}

		private void UpdateCheckBox()
		{
			BackgroundImage = @checked ? Resources.PixelCheckBoxChecked_PNG : Resources.PixelCheckBoxUnchecked_PNG;
		}
	}
}