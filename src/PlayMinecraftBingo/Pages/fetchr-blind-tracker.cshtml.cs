using libFetchrActiveItems;
using libFetchrActiveItems.DataStructures;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace PlayMinecraftBingo.Pages
{
	public class fetchr_blind_trackerModel : PageModel
    {
		public Dictionary<ItemPoolCategory, List<ItemData>> CategoryList { get; set; } = ItemPool.GetSortedItemPool(new(CurrentVersions.Fetchr, CurrentVersions.Minecraft));

		public void OnGet()
        {
        }

        public int CategoryCount => CategoryList.Count;

        public int ItemCount
        {
            get
            {
                int count = 0;
                foreach (List<ItemData> items in CategoryList.Values) count += items.Count;
                return count;
            }
        }

        public int UniqueItemCount
        {
            get
            {
                List<ItemData> allItems = [];
                foreach (List<ItemData> items in CategoryList.Values) allItems.AddRange(items);
                return allItems.DistinctBy(x => x.Id).Count();
            }
        }

        public string RenderItem(ItemData item)
		{
			FetchrItem fetchrItem = new(item);

			string itemName = fetchrItem.Label;
			string invIcon = fetchrItem.InvIcon;

			bool isInMultipleCats = (item.Categories.Count > 1);

			string htmlOut = "<img src=\"/images/mc-items/" + invIcon.ToLower() + "\" alt=\"" + itemName + "\" title=\"" + itemName + "\" /></td><td";
			if (isInMultipleCats) htmlOut += " class=\"inmultiplecats\"";
			htmlOut += ">" + itemName;

			return htmlOut;
		}
    }
}
