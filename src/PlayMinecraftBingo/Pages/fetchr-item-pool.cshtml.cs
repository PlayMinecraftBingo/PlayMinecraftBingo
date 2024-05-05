using libFetchrActiveItems;
using libFetchrActiveItems.DataStructures;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace PlayMinecraftBingo.Pages
{
	public class fetchr_item_poolModel : PageModel
    {
		public Dictionary<string, List<ItemData>> CategoryList { get; set; } = ItemPool.GetSortedItemPool(CurrentVersions.Fetchr);

		public void OnGet()
        {
        }

		public string RenderItem(ItemData item)
		{
			string itemName = Translate.ItemName(item);

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

			bool isInMultipleCats = (item.Categories.Count > 1);

			string htmlOut = "<img src=\"/images/mc-items/invicon_" + invIcon.ToLower() + "\" alt=\"" + itemName + "\" title=\"" + itemName + "\" /></td><td";
			if (isInMultipleCats) htmlOut += " class=\"inmultiplecats\"";
			htmlOut += ">" + itemName;

			return htmlOut;
		}
    }
}
