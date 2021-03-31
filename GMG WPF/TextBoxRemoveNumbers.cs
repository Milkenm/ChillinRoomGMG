using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace GMG_WPF
{
	public static class TextBoxRemoveNumbers
	{
		public static void RemoveNumbers(TextBox tb)
		{
			string numbersOnly = Regex.Replace(tb.Text, @"[^\d]", "");
			if (numbersOnly == "")
			{
				numbersOnly = "0";
			}
			else if (numbersOnly.Length > 1 && numbersOnly.StartsWith("0"))
			{
				numbersOnly = numbersOnly.Substring(1);
			}
			tb.Text = numbersOnly;
			tb.CaretIndex = tb.Text.Length;
		}
	}
}
