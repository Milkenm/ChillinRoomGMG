using Newtonsoft.Json;

using ScriptsLib.Network;

using System.Numerics;

namespace GMG_Core.APIs
{
	public static class MoneroBlocksAPI
	{
		public static MoneroInfo GetXMRInfo()
		{
			string request = Requests.GET("https://moneroblocks.info/api/get_stats");
			MoneroInfo moneroInfo = JsonConvert.DeserializeObject<MoneroInfo>(request);
			return moneroInfo;
		}

		public class MoneroInfo
		{
			public BigInteger difficulty;
			public float height;
			public float hashrate;
			public float total_emission;
			public float last_reward;
		}
	}
}
