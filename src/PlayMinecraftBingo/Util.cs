using System;

namespace PlayMinecraftBingo
{
	internal class Util
	{
		internal static DateTime FromUnixTimestamp(uint unixTimestamp)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTimestamp);
		}
	}
}
