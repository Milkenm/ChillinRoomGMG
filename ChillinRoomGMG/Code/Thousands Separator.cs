using System.Text;

namespace ChillinRoomGMG
{
	internal static partial class Code
	{
		internal static string ThousandsSeparator(object number)
		{
			string[] numString = number.ToString().Replace(".", ",").Split(',');

			StringBuilder sb = new StringBuilder();

			int loop = 3 - (numString[0].Length % 3);
			if (loop == 3)
			{
				loop = 0;
			}

			foreach (char c in numString[0])
			{
				if (c == '.')
				{
					break;
				}
				else if (loop != 0 && loop % 3 == 0)
				{
					sb.Append(',');
				}
				sb.Append(c);

				loop++;
			}
			if (numString.Length > 1)
			{
				sb.Append('.').Append(numString[1]);
			}

			return sb.ToString();
		}
	}
}