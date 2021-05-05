using System.Management;

namespace GMG_Core.Utils
{
	public static class CPU
	{
		public static uint GetCacheSize()
		{
			using (ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'"))
			{
				return (uint)Mo["L3CacheSize"] / 1024;
			}
		}
	}
}
