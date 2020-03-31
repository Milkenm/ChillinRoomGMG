using ChillinRoomGMG.Properties;

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChillinRoomGMG.Controls
{
	[DefaultEvent("Click")]
	public partial class PixelSlider : UserControl
	{
		private bool slided;

		public bool Slided
		{
			get { return slided; }
			set
			{
				slided = value;

				BackgroundImage = slided ? Resources.PixelSlideButtonOn_PNG : Resources.PixelSlideButtonOff_PNG;
			}
		}

		public PixelSlider()
		{
			InitializeComponent();

			BackgroundImage = Slided ? Resources.PixelSlideButtonOn_PNG : Resources.PixelSlideButtonOff_PNG;
		}

		private void PixelSlider_Click(object sender, EventArgs e)
		{
			BackgroundImage = slided ? Resources.PixelSlideButtonOff_PNG : Resources.PixelSlideButtonOn_PNG;

			slided = !slided;
		}
	}
}