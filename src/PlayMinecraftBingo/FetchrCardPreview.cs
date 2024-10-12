using libFetchrCardGen;
using libFetchrVersion;
using System;
using System.Collections.Generic;

namespace PlayMinecraftBingo
{
	public class FetchrCardPreview
    {
		public static string Render(FetchrVersion version, int seed)
		{
			if ((version != FetchrVersion.Fetchr511) && (version != FetchrVersion.Fetchr513)) throw new NotImplementedException("Only cards for Fetchr 5.1.1 and 5.1.3 are supported at this time.");

            if (seed == 0) return "";

            string htmlOut = "<table class=\"bingocard\">";

            List<string> card = FetchrCardGen.GenerateFromSeed(version, seed);

            for (int slot = 0; slot < 25; slot++)
            {
                if (slot % 5 == 0) htmlOut += "<tr>";

                string item = card[slot];
                string InvIcon = MinecraftItems.GetInvIcon(item);
                string Label = MinecraftItems.GetLabel(item);
                htmlOut += "<td";
                htmlOut += "><img src=\"/images/mc-items/invicon_" + InvIcon.ToLower() + "\" alt=\"" + Label + "\" title=\"" + Label + "\" /></td>";
                if (slot % 5 == 4) htmlOut += "</tr>";
            }

            htmlOut += "</table>";

            return htmlOut;
        }
    }
}
