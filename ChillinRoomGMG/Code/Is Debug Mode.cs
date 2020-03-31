namespace ChillinRoomGMG
{
	internal static partial class Code
	{
		internal static bool IsDebugMode()
		{
#if DEBUG
			return true;
#else
			return false;
#endif
		}
	}
}