using Newtonsoft.Json;

using System;

namespace GMG_Core.Xmrig
{
	/// <summary>JSON config file is the preferred way to configure XMRig.</summary>
	[Serializable]
	public class XMRigConfigJSON
	{
		/// <summary>Options contained in api object in the config file.</summary>
		[JsonProperty("api")] public API API { get; set; } = new API();
		/// <summary>Options contained in http object in the config file.</summary>
		[JsonProperty("http")] public HTTP HTTP { get; set; } = new HTTP();
		/// <summary>Enable or disable automatic config save if new mining profiles are generated.</summary>
		[JsonProperty("autosave")] public bool AutoSave { get; set; } = true;
		/// <summary>Run XMRig in the foreground or background.</summary>
		[JsonProperty("background")] public bool Background { get; set; } = false;
		/// <summary>Enable or disable colored output.</summary>
		[JsonProperty("colors")] public bool Colors { get; set; } = false;
		/// <summary>This option controls the title of the console window on Windows.</summary>
		[JsonProperty("title")] public bool Title { get; set; } = true;
		/// <summary>Options contained in randomx object in the config file.</summary>
		[JsonProperty("randomx")] public RandomX RandomX { get; set; } = new RandomX();
		/// <summary>Options contained in cpu object in the config file.</summary>
		[JsonProperty("cpu")] public CPU CPU { get; set; } = new CPU();
		[JsonProperty("opencl")] public OpenCL OpenCL { get; set; } = new OpenCL();
		[JsonProperty("cuda")] public CUDA CUDA { get; set; } = new CUDA();
		[JsonProperty("donate-level")] public int DonateLevel { get; set; } = 1;
		[JsonProperty("donate-over-proxy")] public int DonateOverProxy { get; set; } = 1;
		[JsonProperty("log-file")] public string LogFile { get; set; } = null;
		[JsonProperty("pools")] public Pool[] Pools { get; set; } = new Pool[] { new Pool() };
		[JsonProperty("print-time")] public int PrintTime { get; set; } = 1;
		[JsonProperty("health-print-time")] public int HealthPrintTime { get; set; } = 99999;
		[JsonProperty("dmi")] public bool DMI { get; set; } = true;
		[JsonProperty("retries")] public int Retries { get; set; } = 5;
		[JsonProperty("retry-pause")] public int RetryPause { get; set; } = 5;
		[JsonProperty("syslog")] public bool SysLog { get; set; } = false;
		[JsonProperty("tls")] public TLS TLS { get; set; } = new TLS();
		[JsonProperty("user-agent")] public string UserAgent { get; set; } = null;
		[JsonProperty("verbose")] public int Verbose { get; set; } = 0;
		[JsonProperty("watch")] public bool Watch { get; set; } = true;
		[JsonProperty("pause-on-battery")] public bool PauseOnBattery { get; set; } = false;
		[JsonProperty("pause-on-active")] public bool PauseOnActive { get; set; } = false;
	}

	/// <summary>Options contained in api object in the config file.</summary>
	[Serializable]
	public class API
	{
		/// <summary>Instance ID for API.</summary>
		[JsonProperty("id")] public string ID { get; set; } = null;
		/// <summary>Worker ID, hostname if not specified. This option supports environment variables.</summary>
		[JsonProperty("worker-id")] public string WorkerID { get; set; } = null;
	}

	/// <summary>Options contained in http object in the config file.</summary>
	[Serializable]
	public class HTTP
	{
		/// <summary>Enable or disable HTTP API.</summary>
		[JsonProperty("enabled")] public bool Enabled { get; set; } = false;
		/// <summary>Bind host (IP address) for HTTP API.</summary>
		[JsonProperty("host")] public string Host { get; set; } = "127.0.0.1";
		/// <summary>Bind port.</summary>
		[JsonProperty("port")] public int Port { get; set; } = 0;
		/// <summary>Access token.</summary>
		[JsonProperty("access-token")] public string AccessToken { get; set; } = null;
		/// <summary>Enable (only if access token set) or disable full access to HTTP API.</summary>
		[JsonProperty("restricted")] public bool Restricted { get; set; } = true;
	}

	/// <summary>Options contained in randomx object in the config file.</summary>
	[Serializable]
	public class RandomX
	{
		/// <summary>Thread count to initialize RandomX dataset. Auto-detect (-1) or number of threads.</summary>
		[JsonProperty("init")] public int Init { get; set; } = -1;
		/// <summary>Use AVX2 for dataset initialization. Faster on some CPUs. Auto-detect (-1), disabled (0), always enabled on CPUs that support AVX2 (1).</summary>
		[JsonProperty("init-avx2")] public int InitAVX2 { get; set; } = -1;
		/// <summary>RandomX mining mode: "auto", "fast" (2 GB memory), "light" (256 MB memory).</summary>
		[JsonProperty("mode")] public string Mode { get; set; } = "auto";
		/// <summary>Use 1GB hugepages for RandomX dataset (Linux only). It gives 1-3% speedup.</summary>
		[JsonProperty("1gb-pages")] public bool OneGBPages { get; set; } = false;
		/// <summary>Restore MSR register values to their original values on exit. Used together with wrmsr.</summary>
		[JsonProperty("rdmsr")] public bool RdMSR { get; set; } = true;
		/// <summary>Enable or disable MSR mod. It gives up to 15% speedup depending on your system. For advanced values follow MSR documentation.</summary>
		[JsonProperty("wrmsr")] public bool WrMSR { get; set; } = true;
		/// <summary>Enable or disable Cache QoS. It's useful when you can't or don't want to mine on all CPU cores to make mining hashrate more stable.</summary>
		[JsonProperty("cache_qos")] public bool CacheQoS { get; set; } = false;
		/// <summary>Enable or disable NUMA support (better hashrate on multi-CPU servers and Ryzen Threadripper).</summary>
		[JsonProperty("numa")] public bool NUMA { get; set; } = true;
		/// <summary>Which instruction to use in RandomX loop to prefetch data from scratchpad. 1 is default and fastest in most cases. Can be off (0), prefetcht0 instruction (1), prefetchnta instruction (2, a bit faster on Coffee Lake and a few other CPUs), mov instruction (3).</summary>
		[JsonProperty("scratchpad_prefetch_mode")] public int ScratchpadPrefetchMode { get; set; } = 1;
	}

	/// <summary>Options contained in cpu object in the config file.</summary>
	[Serializable]
	public class CPU
	{
		[JsonProperty("enabled")] public bool Enabled { get; set; } = true;
		[JsonProperty("huge-pages")] public bool HugePages { get; set; } = true;
		[JsonProperty("huge-pages-jit")] public bool HugePagesJit { get; set; } = false;
		[JsonProperty("hw-aes")] public bool? HwAES { get; set; } = null;
		[JsonProperty("priority")] public int? Priority { get; set; } = null;
		[JsonProperty("memory-pool")] public bool MemoryPool { get; set; } = false;
		[JsonProperty("yield")] public bool Yield { get; set; } = true;
		[JsonProperty("asm")] public bool ASM { get; set; } = true;
		[JsonProperty("argon2-impl")] public string Argon2Impl { get; set; } = null;
		[JsonProperty("astrobwt-max-size")] public int AstroBWTMaxSize { get; set; } = 550;
		[JsonProperty("astrobwt-avx2")] public bool AstroBWTAVX2 { get; set; } = false;
		[JsonProperty("argon2")] public int[] Argon2 { get; set; } = { 0 };
		[JsonProperty("astrobwt")] public int[] AstroBWT { get; set; } = { 0 };
		[JsonProperty("cn")] public int[,] CN { get; set; } = { { 1, 0 } };
		[JsonProperty("cn-heavy")] public int[,] CNHeavy { get; set; } = { { 1, 0 } };
		[JsonProperty("cn-lite")] public int[,] CNLite { get; set; } = { { 1, 0 } };
		[JsonProperty("cn-pico")] public int[,] CNPico { get; set; } = { { 2, 0 } };
		[JsonProperty("rx")] public int[] RX { get; set; } = { 0 };
		[JsonProperty("rx/wow")] public int[] RXWoW { get; set; } = { 0 };
		[JsonProperty("cn/0")] public bool CN0 { get; set; } = false;
		[JsonProperty("cn-lite/0")] public bool CNLite0 { get; set; } = false;
		[JsonProperty("rx/arq")] public string RXArq { get; set; } = "rx/wow";
		[JsonProperty("rx/keva")] public string RXKeva { get; set; } = "rx/wow";
	}

	[Serializable]
	public class OpenCL
	{
		[JsonProperty("enabled")] public bool Enabled { get; set; } = false;
		[JsonProperty("cache")] public bool Cache { get; set; } = true;
		[JsonProperty("loader")] public string Loader { get; set; } = null;
		[JsonProperty("platform")] public string Platform { get; set; } = "AMD";
		[JsonProperty("adl")] public bool ADL { get; set; } = true;
		[JsonProperty("cn/0")] public bool CN0 { get; set; } = false;
		[JsonProperty("cn-lite/0")] public bool CNLite0 { get; set; } = false;
	}

	[Serializable]
	public class CUDA
	{
		[JsonProperty("enabled")] public bool Enabled { get; set; } = false;
		[JsonProperty("loader")] public string Loader { get; set; } = null;
		[JsonProperty("nvml")] public bool NVML { get; set; } = true;
		[JsonProperty("cn/0")] public bool CN0 { get; set; } = false;
		[JsonProperty("cn-lite/0")] public bool CNLite0 { get; set; } = false;
	}

	[Serializable]
	public class Pool
	{
		[JsonProperty("algo")] public string Algo { get; set; } = null;
		[JsonProperty("coin")] public string Coin { get; set; } = null;
		[JsonProperty("url")] public string URL { get; set; } = "pool.supportxmr.com:3333";
		[JsonProperty("user")] public string User { get; set; } = "48tEUtNaBiYCVjJarf2W4RHMM5FNx42Vm1qU6Wp7BbnRCGEwpyoiJMAPaGmYQRhGzwdwQq2xhJmAFPqLLeMwmuj18Vmksd8";
		[JsonProperty("pass")] public string Pass { get; set; } = "GMG Miner";
		[JsonProperty("rig-id")] public string RigID { get; set; } = null;
		[JsonProperty("nicehash")] public bool NiceHash { get; set; } = false;
		[JsonProperty("keepalive")] public bool KeepAlive { get; set; } = false;
		[JsonProperty("enabled")] public bool Enabled { get; set; } = true;
		[JsonProperty("tls")] public bool TLS { get; set; } = false;
		[JsonProperty("tls-fingerprint")] public string TLSFingerPrint { get; set; } = null;
		[JsonProperty("daemon")] public bool Daemon { get; set; } = false;
		[JsonProperty("socks5")] public int? Socks5 { get; set; } = null;
		[JsonProperty("self-select")] public string SelfSelect { get; set; } = null;
		[JsonProperty("submit-to-origin")] public bool SubmitToOrigin { get; set; } = false;
	}

	[Serializable]
	public class TLS
	{
		[JsonProperty("enabled")] public bool Enabled { get; set; } = false;
		[JsonProperty("protocols")] public string Protocols { get; set; } = null;
		[JsonProperty("cert")] public string Cert { get; set; } = null;
		[JsonProperty("cert_key")] public string CertKey { get; set; } = null;
		[JsonProperty("ciphers")] public string Ciphers { get; set; } = null;
		[JsonProperty("ciphersuites")] public string CipherSuites { get; set; } = null;
		[JsonProperty("dhparam")] public string DHParam { get; set; } = null;
	}
}
