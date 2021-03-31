using GMG_Core;

using System;

namespace GMG_WPF
{
	public static class GetXmrPrice
	{
		public static decimal GetPrice()
		{
			decimal price = XMR.GetPrice(GData.SettingsManager.Settings.Currency);
			decimal round = Math.Round(price, 2, MidpointRounding.ToEven);

			return round;
		}
	}
}
