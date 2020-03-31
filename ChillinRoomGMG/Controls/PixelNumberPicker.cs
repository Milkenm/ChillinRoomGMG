using System;
using System.Windows.Forms;

namespace ChillinRoomGMG.Controls
{
	public partial class PixelNumberPicker : UserControl
	{
		public delegate void EventDelegate();

		public event EventDelegate ValueChanged;

		private long value;

		public long Value
		{
			get { return value; }
			set
			{
				this.value = value;
				ValueChanged?.Invoke();
				UpdateValue();
			}
		}

		private long minimumValue = 0;

		public long MinimumValue
		{
			get { return minimumValue; }
			set
			{
				minimumValue = value;
				CheckValue();
			}
		}

		private long maximumValue = 1000;

		public long MaximumValue
		{
			get { return maximumValue; }
			set
			{
				maximumValue = value;
				if (maximumValue <= minimumValue)
				{
					maximumValue = minimumValue + 1;
				}
				CheckValue();
			}
		}

		public PixelNumberPicker()
		{
			InitializeComponent();
		}

		// PREVENT WINDOW HEIGHT CHANGE ## https://stackoverflow.com/a/47005249/10601212 ##
		protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
		{
			base.SetBoundsCore(x, y, width, 29, specified);
		}

		private void pictureBox_buttonUp_Click(object sender, EventArgs e)
		{
			Value++;
		}

		private void pictureBox_buttonDown_Click(object sender, EventArgs e)
		{
			Value--;
		}

		private void NumberPicker_Load(object sender, EventArgs e)
		{
			UpdateValue();
		}

		private void UpdateValue()
		{
			CheckValue();
			label_value.Text = Value.ToString();
		}

		private void CheckValue()
		{
			if (Value < MinimumValue)
			{
				Value = minimumValue;
				UpdateValue();
			}
			else if (Value > maximumValue)
			{
				Value = maximumValue;
				UpdateValue();
			}
		}
	}
}