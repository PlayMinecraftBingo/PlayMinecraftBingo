using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace PlayMinecraftBingo.Pages
{
	public class fetchr_item_poolModel : PageModel
    {
		public Dictionary<string, Dictionary<string, byte>> CategoryList { get; set; } = new()
		{
			{
				"Ruined Portals and Gold", new()
				{
					{"Magma Block", 30},
					{"Powered Rail", 5},
					{"Clock", 5},
					{"Block of Raw Gold", 5},
					{"Block of Gold", 5},
					{"Golden Shovel", 2},
					{"Golden Sword", 2},
					{"Golden Axe", 2},
					{"Golden Pickaxe", 2},
					{"Golden Hoe", 2}
				}
			},
			{
				"Diamond", new()
				{
					{"Jukebox", 10},
					{"Enchanted Book", 5},
					{"Obsidian", 5},
					{"Diamond Shovel", 2},
					{"Diamond Hoe", 2},
					{"Diamond Axe", 2},
					{"Diamond Sword", 2},
					{"Diamond Pickaxe", 2}
				}
			},
			{
				"Lush Cave", new()
				{
					{"Bucket of Axolotl", 3},
					{"Glow Berries", 3},
					{"Moss Carpet", 3},
					{"Spore Blossom", 3},
					{"Big Dripleaf", 3},
					{"Hanging Roots", 1},
					{"Rooted Dirt", 1},
					{"Flowering Azalea", 1}
				}
			},
			{
				"Jungle", new()
				{
					{"Scaffolding", 3},
					{"Bamboo", 3},
					{"Cookie", 3},
					{"Cocoa Beans", 3},
					{"Melon", 2},
					{"Glistering Melon Slice", 2},
					{"Melon Slice", 2}
				}
			},
			{
				"Leather", new()
				{
					{"Glow Item Frame", 2},
					{"Item Frame", 2},
					{"Lectern", 1},
					{"Bookshelf", 1},
					{"Book and Quill", 1},
					{"Book", 1}
				}
			},
			{
				"Fish", new()
				{
					{"Bucket of Tropical Fish", 1},
					{"Tropical Fish", 1},
					{"Bucket of Salmon", 1},
					{"Raw Salmon", 1},
					{"Bucket of Cod", 1},
					{"Raw Cod", 1}
				}
			},
			{
				"Shearables", new()
				{
					{"Glow Lichen", 2},
					{"Seagrass", 2},
					{"Fern", 2},
					{"Dead Bush", 2},
					{"Mossy Stone Bricks", 1},
					{"Vines", 1}
				}
			},
			{
				"Nighttime Mob Drops", new()
				{
					{"Arrow of Slowness", 3},
					{"Ender Pearl", 3},
					{"Sticky Piston", 1},
					{"Lead", 1},
					{"Slimeball", 1}
				}
			},
			{
				"Sapling", new()
				{
					{"Dark Oak Sapling", 1},
					{"Birch Sapling", 1},
					{"Mangrove Propagule", 1},
					{"Spruce Sapling", 1},
					{"Acacia Sapling", 1}
				}
			},
			{
				"Basic Iron", new()
				{
					{"Stonecutter", 3},
					{"Acacia Hanging Sign", 3},
					{"Block of Raw Iron", 1},
					{"Block of Iron", 1},
					{"Cauldron", 1}
				}
			},
			{
				"Amethyst", new()
				{
					{"Calcite", 2},
					{"Block of Amethyst", 2},
					{"Spyglass", 1},
					{"Amethyst Shard", 1}
				}
			},
			{
				"Lapis Lazuli", new()
				{
					{"Purple Dye", 2},
					{"Cyan Dye", 2},
					{"Block of Lapis Lazuli", 1},
					{"Lapis Lazuli", 1}
				}
			},
			{
				"Skeleton Drops", new()
				{
					{"Bone Block", 1},
					{"Arrow of Slowness", 1},
					{"Bone", 1},
					{"Arrow", 1}
				}
			},
			{
				"Deepslate", new()
				{
					{"Tuff", 3},
					{"Deepslate Tile Wall", 1},
					{"Cracked Deepslate Bricks", 1},
					{"Deepslate", 1}
				}
			},
			{
				"Copper", new()
				{
					{"Brush", 3},
					{"Exposed Cut Copper", 1},
					{"Block of Copper", 1},
					{"Block of Raw Copper", 1}
				}
			},
			{
				"Gunpowder", new()
				{
					{"Gunpowder", 2},
					{"Firework Rocket", 2},
					{"TNT", 1},
					{"Minecart with TNT", 1}
				}
			},
			{
				"Sand", new()
				{
					{"Orange Concrete", 2},
					{"Glass Bottle", 2},
					{"TNT", 1},
					{"Minecart with TNT", 1}
				}
			},
			{
				"Flint", new()
				{
					{"Flint", 1},
					{"Flint and Steel", 1},
					{"Fletching Table", 1}
				}
			},
			{
				"Mud", new()
				{
					{"Muddy Mangrove Roots", 1},
					{"Packed Mud", 1},
					{"Mud Bricks", 1}
				}
			},
			{
				"Pumpkin", new()
				{
					{"Pumpkin Seeds", 1},
					{"Pumpkin Pie", 1},
					{"Jack o'Lantern", 1}
				}
			},
			{
				"Clay", new()
				{
					{"Pink Glazed Terracotta", 2},
					{"Flower Pot", 1},
					{"Brick", 1}
				}
			},
			{
				"Egg", new()
				{
					{"Pumpkin Pie", 1},
					{"Egg", 1},
					{"Cake", 1}
				}
			},
			{
				"Cherry", new()
				{
					{"Cherry Boat with Chest", 1},
					{"Pink Petals", 1},
					{"Cherry Sapling", 1}
				}
			},
			{
				"Iron with Chest", new()
				{
					{"Hopper", 1},
					{"Minecart with Hopper", 1},
					{"Minecart with Chest", 1}
				}
			},
			{
				"Shipwreck Loot", new()
				{
					{"Emerald", 1},
					{"Heart of the Sea", 1},
					{"Blue Trimmed Leather Boots", 1}
				}
			},
			{
				"Furnace", new()
				{
					{"Minecart with Furnace", 1},
					{"Blast Furnace", 1},
					{"Smoker", 1}
				}
			},
			{
				"Iron Rails", new()
				{
					{"Rail", 1},
					{"Detector Rail", 1},
					{"Activator Rail", 1}
				}
			},
			{
				"Piston", new()
				{
					{"Piston", 1},
					{"Sticky Piston", 1}
				}
			},
			{
				"Compass", new()
				{
					{"Compass", 1},
					{"Empty Map", 1}
				}
			},
			{
				"Spider Eye", new()
				{
					{"Spider Eye", 1},
					{"Fermented Spider Eye", 1}
				}
			},
			{
				"Rabbit", new()
				{
					{"Rabbit Hide", 1},
					{"Cooked Rabbit", 1}
				}
			},
			{
				"Mushroom", new()
				{
					{"Mushroom Stew", 1},
					{"Suspicious Stew", 1}
				}
			},
			{
				"Bow", new()
				{
					{"Crossbow", 1},
					{"Dispenser", 1}
				}
			},
			{
				"Dripstone", new()
				{
					{"Pointed Dripstone", 1},
					{"Dripstone Block", 1}
				}
			},
			{
				"Milk", new()
				{
					{"Cake", 1},
					{"Milk Bucket", 1}
				}
			},
			{
				"Ink", new()
				{
					{"Ink Sac", 1},
					{"Gray Dye", 1}
				}
			},
			{
				"Glow Ink", new()
				{
					{"Glow Ink Sac", 1},
					{"Glow Item Frame", 1}
				}
			},
			{
				"Simple Redstone", new()
				{
					{"Redstone Repeater", 1},
					{"Block of Redstone", 1}
				}
			},
			{
				"Kelp", new()
				{
					{"Dried Kelp", 1},
					{"Dried Kelp Block", 1}
				}
			},
			{
				"Taiga", new()
				{
					{"Fern", 1},
					{"Sweet Berries", 1}
				}
			},
			{
				"Lime", new()
				{
					{"Lime Dye", 1},
					{"Sea Pickle", 1}
				}
			},
			{
				"Cactus", new()
				{
					{"Green Dye", 1},
					{"Lime Dye", 1}
				}
			},
			{
				"Wheat", new()
				{
					{"Target", 1},
					{"Hay Bale", 1}
				}
			},
			{
				"Wool", new()
				{
					{"Painting", 1},
					{"Red Bed", 1}
				}
			},
			{
				"Apple", new()
				{
					{"Apple", 1},
					{"Golden Apple", 1}
				}
			},
			{
				"Snow", new()
				{
					{"Snow", 1}
				}
			}
		};

		public void OnGet()
        {
        }

		public string RenderItem(string itemName)
		{
			string invIcon = itemName switch
			{
				"Blue Trimmed Leather Boots" => "lapis_trim_leather_boots.png",
				"Empty Map" => "empty_locator_map.png",
				"Enchanted Book" => "enchanted_book.gif",
				"Golden Apple" => "enchanted_apple.png",
				"Magma Block" => "magma_block.gif",
				"Milk Bucket" => "milk.png",
				"Mossy Stone Bricks" => "infested_mossy_stone_bricks.png",
				"Stonecutter" => "stonecutter.gif",
				_ => itemName.Replace(" ", "_") + ".png"
			};

			bool isDuplicate = itemName switch
			{
				"Glow Item Frame" or
				"Fern" or
				"Arrow of Slowness" or
				"Sticky Piston" or
				"TNT" or
				"Minecart with TNT" or
				"Pumpkin Pie" or
				"Cake" or
				"Lime Dye" => true,
				_ => false,
			};

			string htmlOut = "<img src=\"/images/mc-items/invicon_" + invIcon.ToLower() + "\" alt=\"" + itemName + "\" title=\"" + itemName + "\" /></td><td";
			if (isDuplicate) htmlOut += " class=\"duplicateItem\"";
			htmlOut += ">" + itemName;

			return htmlOut;
		}
    }
}
