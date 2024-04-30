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
                string InvIcon = GetInvIcon(item);
                string Label = GetLabel(item);
                htmlOut += "<td";
                htmlOut += "><img src=\"/images/mc-items/invicon_" + InvIcon + "\" alt=\"" + Label + "\" title=\"" + Label + "\" /></td>";
                if (slot % 5 == 4) htmlOut += "</tr>";
            }

            htmlOut += "</table>";

            return htmlOut;
        }

        private static string GetInvIcon(string item)
        {
            return item switch
            {
                "amethyst_block" => "block_of_amethyst.png",
                "axolotl_bucket" => "bucket_of_axolotl.png",
                "cherry_chest_boat" => "cherry_boat_with_chest.png",
                "chest_minecart" => "minecart_with_chest.png",
                "cod" => "raw_cod.png",
                "cod_bucket" => "bucket_of_cod.png",
                "copper_block" => "block_of_copper.png",
                "enchanted_book" => "enchanted_book.gif",
                "furnace_minecart" => "minecart_with_furnace.png",
                "golden_apple" => "enchanted_apple.png",
                "gold_block" => "block_of_gold.png",
                "hay_block" => "hay_bale.png",
                "hopper_minecart" => "minecart_with_hopper.png",
                "iron_block" => "block_of_iron.png",
                "jack_o_lantern" => "jack_o'lantern.png",
                "lapis_block" => "block_of_lapis_lazuli.png",
                "leather_boots" => "lapis_trim_leather_boots.png",
                "magma_block" => "magma_block.gif",
                "map" => "empty_locator_map.png",
                "milk_bucket" => "milk.png",
                "mossy_stone_bricks" => "infested_mossy_stone_bricks.png",
                "raw_copper_block" => "block_of_raw_copper.png",
                "raw_gold_block" => "block_of_raw_gold.png",
                "raw_iron_block" => "block_of_raw_iron.png",
                "redstone_block" => "block_of_redstone.png",
                "repeater" => "redstone_repeater.png",
                "salmon" => "raw_salmon.png",
                "salmon_bucket" => "bucket_of_salmon.png",
                "slime_ball" => "slimeball.png",
                "stonecutter" => "stonecutter.gif",
                "tipped_arrow" => "arrow_of_slowness.png",
                "tnt_minecart" => "minecart_with_tnt.png",
                "tropical_fish_bucket" => "bucket_of_tropical_fish.png",
                "vine" => "vines.png",
                "writable_book" => "book_and_quill.png",
                _ => item.Replace(" ", "_") + ".png"
            };
        }

        private static string GetLabel(string item)
        {
            return item switch
            {
                "acacia_hanging_sign" => "Acacia Hanging Sign",
                "acacia_sapling" => "Acacia Sapling",
                "activator_rail" => "Activator Rail",
                "amethyst_block" => "Block of Amethyst",
                "amethyst_shard" => "Amethyst Shard",
                "apple" => "Apple",
                "arrow" => "Arrow",
                "axolotl_bucket" => "Bucket of Axolotl",
                "bamboo" => "Bamboo",
                "big_dripleaf" => "Big Dripleaf",
                "birch_sapling" => "Birch Sapling",
                "blast_furnace" => "Blast Furnace",
                "bone" => "Bone",
                "bone_block" => "Bone Block",
                "book" => "Book",
                "bookshelf" => "Bookshelf",
                "brick" => "Brick",
                "brush" => "Brush",
                "cake" => "Cake",
                "calcite" => "Calcite",
                "cauldron" => "Cauldron",
                "cherry_chest_boat" => "Cherry Boat with Chest",
                "cherry_sapling" => "Cherry Sapling",
                "chest_minecart" => "Minecart with Chest",
                "clock" => "Clock",
                "cocoa_beans" => "Cocoa Beans",
                "cod" => "Raw Cod",
                "cod_bucket" => "Bucket of Cod",
                "compass" => "Compass",
                "cooked_rabbit" => "Cooked Rabbit",
                "cookie" => "Cookie",
                "copper_block" => "Block of Copper",
                "cracked_deepslate_bricks" => "Cracked Deepslate Bricks",
                "crossbow" => "Crossbow",
                "cyan_dye" => "Cyan Dye",
                "dark_oak_sapling" => "Dark Oak Sapling",
                "dead_bush" => "Dead Bush",
                "deepslate" => "Deepslate",
                "deepslate_tile_wall" => "Deepslate Tile Wall",
                "detector_rail" => "Detector Rail",
                "diamond_axe" => "Diamond Axe",
                "diamond_hoe" => "Diamond Hoe",
                "diamond_pickaxe" => "Diamond Pickaxe",
                "diamond_shovel" => "Diamond Shovel",
                "diamond_sword" => "Diamond Sword",
                "dispenser" => "Dispenser",
                "dried_kelp" => "Dried Kelp",
                "dried_kelp_block" => "Dried Kelp Block",
                "dripstone_block" => "Dripstone Block",
                "egg" => "Egg",
                "emerald" => "Emerald",
                "enchanted_book" => "Enchanted Book",
                "ender_pearl" => "Ender Pearl",
                "exposed_cut_copper" => "Exposed Cut Copper",
                "fermented_spider_eye" => "Fermented Spider Eye",
                "fern" => "Fern",
                "firework_rocket" => "Firework Rocket",
                "fletching_table" => "Fletching Table",
                "flint" => "Flint",
                "flint_and_steel" => "Flint and Steel",
                "flowering_azalea" => "Flowering Azalea",
                "flower_pot" => "Flower Pot",
                "furnace_minecart" => "Minecart with Furnace",
                "glass_bottle" => "Glass Bottle",
                "glistering_melon_slice" => "Glistering Melon Slice",
                "glow_berries" => "Glow Berries",
                "glow_ink_sac" => "Glow Ink Sac",
                "glow_item_frame" => "Glow Item Frame",
                "glow_lichen" => "Glow Lichen",
                "golden_apple" => "Golden Apple",
                "golden_axe" => "Golden Axe",
                "golden_hoe" => "Golden Hoe",
                "golden_pickaxe" => "Golden Pickaxe",
                "golden_shovel" => "Golden Shovel",
                "golden_sword" => "Golden Sword",
                "gold_block" => "Block of Gold",
                "gray_dye" => "Gray Dye",
                "green_dye" => "Green Dye",
                "gunpowder" => "Gunpowder",
                "hanging_roots" => "Hanging Roots",
                "hay_block" => "Hay Bale",
                "heart_of_the_sea" => "Heart of the Sea",
                "hopper" => "Hopper",
                "hopper_minecart" => "Minecart with Hopper",
                "ink_sac" => "Ink Sac",
                "iron_block" => "Block of Iron",
                "item_frame" => "Item Frame",
                "jack_o_lantern" => "Jack o'Lantern",
                "jukebox" => "Jukebox",
                "lapis_block" => "Block of Lapis Lazuli",
                "lapis_lazuli" => "Lapis Lazuli",
                "lead" => "Lead",
                "leather_boots" => "Blue Trimmed Leather Boots",
                "lectern" => "Lectern",
                "lime_dye" => "Lime Dye",
                "magma_block" => "Magma Block",
                "mangrove_propagule" => "Mangrove Propagule",
                "map" => "Empty Map",
                "melon" => "Melon",
                "melon_slice" => "Melon Slice",
                "milk_bucket" => "Milk Bucket",
                "mossy_stone_bricks" => "Mossy Stone Bricks",
                "moss_carpet" => "Moss Carpet",
                "muddy_mangrove_roots" => "Muddy Mangrove Roots",
                "mud_bricks" => "Mud Bricks",
                "mushroom_stew" => "Mushroom Stew",
                "obsidian" => "Obsidian",
                "orange_concrete" => "Orange Concrete",
                "packed_mud" => "Packed Mud",
                "painting" => "Painting",
                "pink_glazed_terracotta" => "Pink Glazed Terracotta",
                "pink_petals" => "Pink Petals",
                "piston" => "Piston",
                "pointed_dripstone" => "Pointed Dripstone",
                "powered_rail" => "Powered Rail",
                "pumpkin_pie" => "Pumpkin Pie",
                "pumpkin_seeds" => "Pumpkin Seeds",
                "purple_dye" => "Purple Dye",
                "rabbit_hide" => "Rabbit Hide",
                "rail" => "Rail",
                "raw_copper_block" => "Block of Raw Copper",
                "raw_gold_block" => "Block of Raw Gold",
                "raw_iron_block" => "Block of Raw Iron",
                "redstone_block" => "Block of Redstone",
                "red_bed" => "Red Bed",
                "repeater" => "Redstone Repeater",
                "rooted_dirt" => "Rooted Dirt",
                "salmon" => "Raw Salmon",
                "salmon_bucket" => "Bucket of Salmon",
                "scaffolding" => "Scaffolding",
                "seagrass" => "Seagrass",
                "sea_pickle" => "Sea Pickle",
                "slime_ball" => "Slimeball",
                "smoker" => "Smoker",
                "snow" => "Snow",
                "spider_eye" => "Spider Eye",
                "spore_blossom" => "Spore Blossom",
                "spruce_sapling" => "Spruce Sapling",
                "spyglass" => "Spyglass",
                "sticky_piston" => "Sticky Piston",
                "stonecutter" => "Stonecutter",
                "suspicious_stew" => "Suspicious Stew",
                "sweet_berries" => "Sweet Berries",
                "target" => "Target",
                "tipped_arrow" => "Arrow of Slowness",
                "tnt" => "TNT",
                "tnt_minecart" => "Minecart with TNT",
                "tropical_fish" => "Tropical Fish",
                "tropical_fish_bucket" => "Bucket of Tropical Fish",
                "tuff" => "Tuff",
                "vine" => "Vines",
                "writable_book" => "Book and Quill",
                _ => throw new NotImplementedException("There is currently no mapping for that item.")
            };
        }
    }
}
