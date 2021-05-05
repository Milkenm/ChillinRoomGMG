using GMG_Core;
using GMG_Core.APIs;

using System;

namespace GMG_WPF.Utils
{
	public static class XMR
	{
		public static decimal GetPrice()
		{
			decimal price = CryptonatorAPI.GetXMRPrice(GData.SettingsManager.Settings.Currency);
			decimal round = Math.Round(price, 2, MidpointRounding.ToEven);

			return round;
		}
	}
}
