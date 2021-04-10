using Newtonsoft.Json;

using ScriptsLib.Network;

using System.Windows.Forms;

namespace GMG_Core
{
	public class SupportXmrAPI
	{
		private string ApiUrl { get { return "https://supportxmr.com/api/"; } }
		private string ApiAddressStats { get { return this.ApiUrl + "miner/{0}/stats"; } }

		private string XmrAddress { get; set; }

		public SupportXmrAPI(string xmrAddress)
		{
			this.XmrAddress = xmrAddress;
		}

		public AddressStats GetAddressStats()
		{
			try
			{
				string response = Requests.GET(string.Format(this.ApiAddressStats, this.XmrAddress));

				AddressStats stats = JsonConvert.DeserializeObject<AddressStats>(response);
				stats.AmountPaid /= 1000000000000;
				stats.AmountDue /= 1000000000000;

				return stats;
			}
			catch
			{
				throw new System.Exception();
			}
		}
	}

	public class AddressStats
	{
		[JsonProperty("hash")] public int Hash;
		[JsonProperty("identifier")] public string Identifier;
		[JsonProperty("lastHash")] public long LastHash;
		[JsonProperty("totalHashes")] public long TotalHashes;
		[JsonProperty("validShares")] public int ValidShares;
		[JsonProperty("invalidShares")] public int InvalidShares;
		[JsonProperty("expiry")] public long Expiry;
		[JsonProperty("amtPaid")] public decimal AmountPaid;
		[JsonProperty("amtDue")] public decimal AmountDue;
		[JsonProperty("txnCount")] public int TxnCount;
	}
}
