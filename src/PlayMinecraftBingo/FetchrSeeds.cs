using System;

namespace PlayMinecraftBingo
{
	internal class FetchrSeeds
	{
		internal static int Random()
		{
			Random r = new();
			int seed = 0;

			while (seed == 0) seed = r.Next(int.MinValue, int.MaxValue);

			return seed;
		}
	}
}