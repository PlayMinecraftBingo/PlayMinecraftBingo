using libFetchrCardGen;
using libFetchrVersion;
using System;
using System.Collections.Generic;

namespace PlayMinecraftBingo
{
	public class FetchrCardPreview
    {
		public static string Render(FetchrVersion version, int seed, bool highlightBad = false)
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
                if (highlightBad && IsSlowMobDrop(item)) htmlOut += " class=\"slowmobdrop\"";
                else if (highlightBad && IsBad(item)) htmlOut += " class=\"bad\"";
                htmlOut += "><img src=\"/images/mc-items/invicon_" + InvIcon.ToLower() + "\" alt=\"" + Label + "\" title=\"" + Label + "\" /></td>";
                if (slot % 5 == 4) htmlOut += "</tr>";
            }

            htmlOut += "</table>";

            return htmlOut;
        }

        public static bool IsSlowMobDrop(string item)
        {
            return item switch
            {
                "bone" or
                "cake" or
                "egg" or
                "ender_pearl" or
                "fermented_spider_eye" or
                "firework_rocket" or
                "gunpowder" or
                "lead" or
                "slime_ball" or
                "spider_eye" or
                "sticky_piston" or
                "tipped_arrow" or
                "tnt" or
                "tnt_minecart" => true,
                _ => false
            };
        }

        public static bool IsBad(string item)
        {
            return item switch
            {
                "activator_rail" or
                "amethyst_block" or
                "amethyst_shard" or
                "axolotl_bucket" or
                "big_dripleaf" or
                "clock" or
                "compass" or
                "detector_rail" or
                "diamond_axe" or
                "diamond_hoe" or
                "diamond_pickaxe" or
                "diamond_shovel" or
                "diamond_sword" or
                "dispenser" or
                "ender_pearl" or
                "exposed_cut_copper" or
                "flowering_azalea" or
                "glow_berries" or
                "glow_ink_sac" or
                "glow_item_frame" or
                "hanging_roots" or
                "jukebox" or
                "lapis_block" or
                "lead" or
                "leather_boots" or
                "piston" or
                "powered_rail" or
                "redstone_block" or
                "repeater" or
                "rooted_dirt" or
                "slime_ball" or
                "spore_blossom" or
                "spyglass" or
                "sticky_piston" or
                "target" or
                "tipped_arrow" or
                "tnt" or
                "tnt_minecart" => true,
                _ => false
            };
        }
    }
}
