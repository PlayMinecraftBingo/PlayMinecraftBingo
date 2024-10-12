using libFetchrActiveItems;
using System;

namespace PlayMinecraftBingo
{
	internal class MinecraftItems
	{
		internal static string GetInvIconByName(string itemName)
		{
			return itemName switch
			{
				"Blue Trimmed Leather Boots" => "lapis_trim_leather_boots.png",
				"Empty Map" => "empty_locator_map.png",
				"Enchanted Book" => "enchanted_book.gif",
				"Magma Block" => "magma_block.gif",
				"Milk Bucket" => "milk.png",
				"Stonecutter" => "stonecutter.gif",
				_ => itemName.Replace(" ", "_") + ".png"
			};
		}

		internal static string GetInvIcon(string item)
		{
			return GetInvIconByName(GetLabel(item));
		}

		internal static string GetLabel(string item)
		{
			if (item == "leather_boots") return GetLabel("fetchr.item.blue_trimmed_leather_boots");
			if (item == "tipped_arrow") return GetLabel("item.minecraft.tipped_arrow.effect.slowness");
			return Translate.ItemName(item) ?? throw new NotImplementedException("There is currently no mapping for that item.");
		}
	}
}
