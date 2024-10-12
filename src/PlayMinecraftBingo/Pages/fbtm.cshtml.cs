using libFetchrActiveItems.DataStructures;
using libFetchrActiveItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace PlayMinecraftBingo.Pages
{
	public class fbtmModel : PageModel
    {
		[BindProperty(SupportsGet = true)]
		public required int Seed { get; set; }

		[BindProperty(SupportsGet = true)]
		public required string Team { get; set; }

		[BindProperty(SupportsGet = true)]
		public string? View { get; set; } = "grid";

		public Dictionary<string, List<ItemData>> CategoryList { get; set; } = ItemPool.GetSortedItemPool(CurrentVersions.Fetchr);

		public void OnGet()
        {
        }

		public string RenderItem(ItemData item)
		{
			string itemName = Translate.ItemName(item);
			string invIcon = MinecraftItems.GetInvIconByName(itemName);
			string itemId = item.Item.Id[(item.Item.Id.LastIndexOf(':') + 1)..];

			string htmlOut = "<img class=\"mcitem\" data-mcitem=\"" + itemId + "\" src=\"/images/mc-items/invicon_" + invIcon.ToLower() + "\" alt=\"" + itemName + "\" title=\"" + itemName + "\" />";
			return htmlOut;
		}
	}
}
