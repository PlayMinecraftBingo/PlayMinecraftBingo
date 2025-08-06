using libFetchr;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace PlayMinecraftBingo.Pages
{
	public class fetchr_item_poolModel : PageModel
    {
		public List<FetchrCategory> CategoryList { get; set; } = new Fetchr(CurrentVersions.Fetchr).GetItemPool(ItemPoolSorting.ByCountDescendingThenWeightDescending);

		public void OnGet()
        {
        }

        public int CategoryCount => CategoryList.Count;

        public int ItemCount => CategoryList.Sum(c => c.Items.Count);

        public int UniqueItemCount
        {
            get
            {
                List<FetchrItem> allItems = [];
                foreach (FetchrCategory category in CategoryList)
                {
                    allItems.AddRange(category.Items);
                }
                return allItems.DistinctBy(i => i.Id).Count();
            }
        }

        public string RenderItem(FetchrItem item, List<FetchrCategory> categories)
		{
			string itemName = item.Name;
			string invIcon = item.InventoryIcon.ToLower();

			string htmlOut = "<img src=\"/images/mc-items/" + invIcon.ToLower() + "\" alt=\"" + itemName + "\" title=\"" + itemName + "\" /></td><td";
			if (item.InMultipleCategories(categories)) htmlOut += " class=\"inmultiplecats\"";
			htmlOut += ">" + itemName;

			return htmlOut;
		}
    }
}
