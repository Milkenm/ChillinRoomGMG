using Newtonsoft.Json;

using System;

using static ScriptsLib.Network.Requests;

namespace GMG_Core.APIs
{
	public static class CryptonatorAPI
	{
		public static decimal GetXMRPrice(Currency currency)
		{
			string request = GET("https://api.cryptonator.com/api/ticker/xmr-" + currency.ToString().ToLower());
			XmrRequest response = JsonConvert.DeserializeObject<XmrRequest>(request);

			return Convert.ToDecimal(response.Ticker.Price.Replace(".", ","));
		}

		public class XmrRequest
		{
			[JsonProperty("ticker")] public Ticker Ticker;
			[JsonProperty("success")] public bool Success;
		}

		public class Ticker
		{
			[JsonProperty("price")] public string Price;
			[JsonProperty("volume")] public string Volume;
			[JsonProperty("change")] public string Change;
		}

		public enum Currency
		{
			EUR,
			USD,
		}
	}
}
