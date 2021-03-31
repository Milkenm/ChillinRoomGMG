using System.Management;

namespace GMG_Core
{
	public static class Utils
	{
		public static uint GetCPUCacheSize()
		{
			using (ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'"))
			{
				return (uint)Mo["L3CacheSize"] / 1024;
			}
		}
	}
}
