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

		public Dictionary<ItemPoolCategory, List<ItemData>> CategoryList { get; set; } = ItemPool.GetSortedItemPool(new(CurrentVersions.Fetchr, CurrentVersions.Minecraft));

		public void OnGet()
        {
        }

		public string RenderItem(ItemData item)
		{
			return RenderItem(new FetchrItem(item));
		}

		public string RenderItem(FetchrItem item)
		{
			string itemName = item.Label;
			string invIcon = item.InvIcon;
			string itemId = item.FetchrId;

			string htmlOut = "<img class=\"mcitem\" data-mcitem=\"" + itemId + "\" src=\"/images/mc-items/" + invIcon.ToLower() + "\" alt=\"" + itemName + "\" title=\"" + itemName + "\" />";
			return htmlOut;
		}
	}
}
