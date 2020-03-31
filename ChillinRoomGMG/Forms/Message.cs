using System;
using System.Windows.Forms;

namespace ChillinRoomGMG.Forms
{
	public partial class Message : Form
	{
		public bool ConfirmValue { get; private set; }

		public Message(string message, bool isConfirmationMessage)
		{
			InitializeComponent();

			label_message.Text = message;

			if (!isConfirmationMessage)
			{
				button_yes.Visible = false;
				button_hybrid.Text = "OK";
			}
		}

		private void button_hybrid_Click(object sender, EventArgs e)
		{
			ConfirmValue = false;
			Close();
		}

		private void button_yes_Click(object sender, EventArgs e)
		{
			ConfirmValue = true;
			Close();
		}
	}
}