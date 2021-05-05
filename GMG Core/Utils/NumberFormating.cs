using System;
using System.Text;

namespace GMG_Core.Utils
{
	public static partial class NumberFormating
	{
		public static string ThousandsSeparator(object number)
		{
			string[] numString = number.ToString().Replace(".", ",").Split(',');

			StringBuilder sb = new StringBuilder();

			int loop = 3 - numString[0].Length % 3;
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

		public static string AbbreviateNumber(decimal number, bool decimals = true, bool noDecimalsRoundUp = false, bool addSpaceAtEndIfNotRounded = false)
		{
			string[] numSplit = ThousandsSeparator(number.ToString("F4").Split('.')[0]).Split(',');

			if (numSplit.Length > 1)
			{
				StringBuilder numString = new StringBuilder(numSplit[0]);

				if (decimals)
				{
					if (numSplit[1][1] != '0')
					{
						numString.Append('.').Append(numSplit[1][0]).Append(numSplit[1][1]);
					}
				}
				else
				{
					if (noDecimalsRoundUp && Convert.ToInt16(numSplit[1][0]) >= 5)
					{
						numString = new StringBuilder((Convert.ToInt64(numSplit[0]) + 1).ToString());
					}
				}

				numString.Append(' ').Append(new char[] { 'K', 'M', 'B', 'T' }[numSplit.Length - 2]);

				return numString.ToString();
			}
			else
			{
				return numSplit[0].Split('.', ',')[0] + (addSpaceAtEndIfNotRounded ? " " : "");
			}
		}
	}
}