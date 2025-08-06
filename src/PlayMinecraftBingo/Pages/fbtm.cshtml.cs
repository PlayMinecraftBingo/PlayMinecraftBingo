using libFetchr;
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

		public List<FetchrCategory> CategoryList { get; set; } = new Fetchr(CurrentVersions.Fetchr).GetItemPool(ItemPoolSorting.ByCountDescendingThenWeightDescending);

		public void OnGet()
        {
        }

		public string RenderItem(FetchrItem item)
		{
			string itemName = item.Name;
			string invIcon = item.InventoryIcon.ToLower();
			string itemId = item.Id;

			string htmlOut = "<img class=\"mcitem\" data-mcitem=\"" + itemId + "\" src=\"/images/mc-items/" + invIcon.ToLower() + "\" alt=\"" + itemName + "\" title=\"" + itemName + "\" />";
			return htmlOut;
		}
	}
}
