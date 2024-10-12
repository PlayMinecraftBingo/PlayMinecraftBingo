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
			string invIcon = MinecraftItems.GetInvIconByName(itemName);

			bool isInMultipleCats = (item.Categories.Count > 1);

			string htmlOut = "<img src=\"/images/mc-items/invicon_" + invIcon.ToLower() + "\" alt=\"" + itemName + "\" title=\"" + itemName + "\" /></td><td";
			if (isInMultipleCats) htmlOut += " class=\"inmultiplecats\"";
			htmlOut += ">" + itemName;

			return htmlOut;
		}
    }
}
