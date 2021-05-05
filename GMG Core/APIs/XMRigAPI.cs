using Newtonsoft.Json;

namespace GMG_Core.APIs
{
	public class XMRigAPI
	{
		public class XMRigHTTPAPI
		{
			[JsonProperty("id")] public string ID;
			[JsonProperty("worker_id")] public string WorkerID;
			[JsonProperty("uptime")] public long Uptime;
			[JsonProperty("restricted")] public bool Restricted;
			[JsonProperty("resources")] public Resources Resources;
			[JsonProperty("features")] public string[] Features;
			[JsonProperty("results")] public Results Results;
			[JsonProperty("algo")] public string Algo;
			[JsonProperty("connection")] public Connection Connection;
			[JsonProperty("version")] public string Version;
			[JsonProperty("kind")] public string Kind;
			[JsonProperty("ua")] public string UA;
			[JsonProperty("cpu")] public CPU CPU;
			[JsonProperty("donate_level")] public int DonateLevel;
			[JsonProperty("paused")] public bool Paused;
			[JsonProperty("algorithms")] public string[] Algorithms;
			[JsonProperty("hashrate")] public Hashrate Hashrate;
			[JsonProperty("hugepages")] public bool HugePages;
		}

		public class Resources
		{
			[JsonProperty("memory")] public Memory Memory;
			[JsonProperty("load_average")] public decimal[] LoadAverage;
			[JsonProperty("hardware_concurrency")] public int HardwareConcurrency;
		}

		public class Memory
		{
			[JsonProperty("free")] public long Free;
			[JsonProperty("total")] public long Total;
			[JsonProperty("resident_set_memory")] public long ResidentSetMemory;
		}

		public class Results
		{
			[JsonProperty("diff_current")] public long DiffCurrent;
			[JsonProperty("shares_good")] public int SharesGood;
			[JsonProperty("shares_total")] public int SharesTotal;
			[JsonProperty("avg_time")] public int AvgTime;
			[JsonProperty("avg_time_ms")] public long AvgTimeMs;
			[JsonProperty("hashes_total")] public long HashesTotal;
			[JsonProperty("best")] public int[] Best;
			[JsonProperty("error_log")] public object ErrorLog;
		}

		public class Connection
		{
			[JsonProperty("pool")] public string Pool;
			[JsonProperty("ip")] public string IP;
			[JsonProperty("ping")] public int Ping;
			[JsonProperty("failures")] public int Failures;
			[JsonProperty("tls")] public object Tls;
			[JsonProperty("tls-fingerprint")] public object TlsFingerprint;
			[JsonProperty("algo")] public string Algo;
			[JsonProperty("accepted")] public int Accepted;
			[JsonProperty("rejected")] public int Rejected;
			[JsonProperty("avg_time")] public int AvgTime;
			[JsonProperty("avg_time_ms")] public long AvgTimeMs;
			[JsonProperty("hashes_total")] public long HashesTotal;
			[JsonProperty("error_log")] public object ErrorLog;
		}

		public class CPU
		{
			[JsonProperty("brand")] public string Brand;
			[JsonProperty("family")] public int Family;
			[JsonProperty("model")] public int Model;
			[JsonProperty("stepping")] public int Stepping;
			[JsonProperty("proc_info")] public int ProcInfo;
			[JsonProperty("aes")] public bool AES;
			[JsonProperty("avx2")] public bool AVX2;
			[JsonProperty("x64")] public bool X64;
			[JsonProperty("64_bit")] public bool X64Bit;
			[JsonProperty("l2")] public int L2;
			[JsonProperty("l3")] public int L3;
			[JsonProperty("cores")] public int Cores;
			[JsonProperty("threads")] public int Threads;
			[JsonProperty("packages")] public int Packages;
			[JsonProperty("nodes")] public int Nodes;
			[JsonProperty("backend")] public string Backend;
			[JsonProperty("msr")] public string MSR;
			[JsonProperty("assembly")] public string Assembly;
			[JsonProperty("arch")] public string Arch;
			[JsonProperty("flags")] public string[] Flags;
		}

		public class Hashrate
		{
			[JsonProperty("total")] public decimal?[] Total;
			[JsonProperty("highest")] public decimal? Highest;
			[JsonProperty("threads")] public decimal?[][] Threads;
		}
	}
}
