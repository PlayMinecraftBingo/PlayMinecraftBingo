<?php

function RenderItem($item)
{

	switch ($item)
	{
		case "Blue Trimmed Leather Boots":
			$invicon = "Lapis_Trim_Leather_Boots.png";
			break;
		case "Empty Map":
			$invicon = "Empty_Locator_Map.png";
			break;
		case "Golden Apple":
			$invicon = "Enchanted_Apple.png";
			break;
		case "Magma Block":
			$invicon = "Magma_Block.gif";
			break;
		case "Milk Bucket":
			$invicon = "Milk.png";
			break;
		case "Mossy Stone Bricks":
			$invicon = "Infested_Mossy_Stone_Bricks.png";
			break;
		case "Stonecutter":
			$invicon = "Stonecutter.gif";
			break;
		default:
			$invicon = str_replace(" ", "_", $item) . ".png";
			break;
	}

	switch ($item)
	{
		case "Glow Item Frame":
		case "Fern":
		case "Arrow of Slowness":
		case "Sticky Piston":
		case "TNT":
		case "Minecart with TNT":
		case "Pumpkin Pie":
		case "Cake":
		case "Lime Dye":
			$css = " class='duplicateItem'";
			break;
		default:
			$css = "";
			break;
	}

	echo '<img src="../images/mc-items/Invicon_' . $invicon . '" alt="' . $item . '" title="' . $item . '" /></td><td' . $css . '>' . $item;
}

$catList['Ruined Portals and Gold'] = array(
	'Magma Block' => 30,
	'Powered Rail' => 5,
	'Clock' => 5,
	'Block of Raw Gold' => 5,
	'Block of Gold' => 5,
	'Golden Shovel' => 2,
	'Golden Sword' => 2,
	'Golden Axe' => 2,
	'Golden Pickaxe' => 2,
	'Golden Hoe' => 2
);
$catList['Diamond'] = array(
	'Jukebox' => 10,
	'Enchanted Book' => 5,
	'Obsidian' => 5,
	'Diamond Shovel' => 2,
	'Diamond Hoe' => 2,
	'Diamond Axe' => 2,
	'Diamond Sword' => 2,
	'Diamond Pickaxe' => 2
);
$catList['Lush Cave'] = array(
	'Bucket of Axolotl' => 3,
	'Glow Berries' => 3,
	'Moss Carpet' => 3,
	'Spore Blossom' => 3,
	'Big Dripleaf' => 3,
	'Hanging Roots' => 1,
	'Rooted Dirt' => 1,
	'Flowering Azalea' => 1
);
$catList['Jungle'] = array(
	'Scaffolding' => 3,
	'Bamboo' => 3,
	'Cookie' => 3,
	'Cocoa Beans' => 3,
	'Melon' => 2,
	'Glistering Melon Slice' => 2,
	'Melon Slice' => 2
);
$catList['Leather'] = array(
	'Glow Item Frame' => 2,
	'Item Frame' => 2,
	'Lectern' => 1,
	'Bookshelf' => 1,
	'Book and Quill' => 1,
	'Book' => 1
);
$catList['Fish'] = array(
	'Bucket of Tropical Fish' => 1,
	'Tropical Fish' => 1,
	'Bucket of Salmon' => 1,
	'Raw Salmon' => 1,
	'Bucket of Cod' => 1,
	'Raw Cod' => 1
);
$catList['Shearables'] = array(
	'Glow Lichen' => 2,
	'Seagrass' => 2,
	'Fern' => 2,
	'Dead Bush' => 2,
	'Mossy Stone Bricks' => 1,
	'Vines' => 1
);
$catList['Nighttime Mob Drops'] = array(
	'Arrow of Slowness' => 3,
	'Ender Pearl' => 3,
	'Sticky Piston' => 1,
	'Lead' => 1,
	'Slimeball' => 1
);
$catList['Sapling'] = array(
	'Dark Oak Sapling' => 1,
	'Birch Sapling' => 1,
	'Mangrove Propagule' => 1,
	'Spruce Sapling' => 1,
	'Acacia Sapling' => 1
);
$catList['Basic Iron'] = array(
	'Stonecutter' => 3,
	'Acacia Hanging Sign' => 3,
	'Block of Raw Iron' => 1,
	'Block of Iron' => 1,
	'Cauldron' => 1
);
$catList['Amethyst'] = array(
	'Calcite' => 2,
	'Block of Amethyst' => 2,
	'Spyglass' => 1,
	'Amethyst Shard' => 1
);
$catList['Lapis Lazuli'] = array(
	'Purple Dye' => 2,
	'Cyan Dye' => 2,
	'Block of Lapis Lazuli' => 1,
	'Lapis Lazuli' => 1
);
$catList['Skeleton Drops'] = array(
	'Bone Block' => 1,
	'Arrow of Slowness' => 1,
	'Bone' => 1,
	'Arrow' => 1
);
$catList['Deepslate'] = array(
	'Tuff' => 3,
	'Deepslate Tile Wall' => 1,
	'Cracked Deepslate Bricks' => 1,
	'Deepslate' => 1
);
$catList['Copper'] = array(	
	'Brush' => 3,
	'Exposed Cut Copper' => 1,
	'Block of Copper' => 1,
	'Block of Raw Copper' => 1
);
$catList['Gunpowder'] = array(
	'Gunpowder' => 2,
	'Firework Rocket' => 2,
	'TNT' => 1,
	'Minecart with TNT' => 1
);
$catList['Sand'] = array(
	'Orange Concrete' => 2,
	'Glass Bottle' => 2,
	'TNT' => 1,
	'Minecart with TNT' => 1
);
$catList['Flint'] = array(
	'Flint' => 1,
	'Flint and Steel' => 1,
	'Fletching Table' => 1
);
$catList['Mud'] = array(
	'Muddy Mangrove Roots' => 1,
	'Packed Mud' => 1,
	'Mud Bricks' => 1
);
$catList['Pumpkin'] = array(
	'Pumpkin Seeds' => 1,
	'Pumpkin Pie' => 1,
	'Jack o\'Lantern' => 1
);
$catList['Clay'] = array(
	'Pink Glazed Terracotta' => 2,
	'Flower Pot' => 1,
	'Brick' => 1
);
$catList['Egg'] = array(
	'Pumpkin Pie' => 1,
	'Egg' => 1,
	'Cake' => 1
);
$catList['Cherry'] = array(
	'Cherry Boat with Chest' => 1,
	'Pink Petals' => 1,
	'Cherry Sapling' => 1
);
$catList['Iron with Chest'] = array(
	'Hopper' => 1,
	'Minecart with Hopper' => 1,
	'Minecart with Chest' => 1
);
$catList['Shipwreck Loot'] = array(
	'Emerald' => 1,
	'Heart of the Sea' => 1,
	'Blue Trimmed Leather Boots' => 1
);
$catList['Furnace'] = array(
	'Minecart with Furnace' => 1,
	'Blast Furnace' => 1,
	'Smoker' => 1
);
$catList['Iron Rails'] = array(
	'Rail' => 1,
	'Detector Rail' => 1,
	'Activator Rail' => 1
);
$catList['Piston'] = array(
	'Piston' => 1,
	'Sticky Piston' => 1
);
$catList['Compass'] = array(
	'Compass' => 1,
	'Empty Map' => 1
);
$catList['Spider Eye'] = array(
	'Spider Eye' => 1,
	'Fermented Spider Eye' => 1
);
$catList['Rabbit'] = array(
	'Rabbit Hide' => 1,
	'Cooked Rabbit' => 1
);
$catList['Mushroom'] = array(
	'Mushroom Stew' => 1,
	'Suspicious Stew' => 1
);
$catList['Bow'] = array(
	'Crossbow' => 1,
	'Dispenser' => 1
);
$catList['Dripstone'] = array(
	'Pointed Dripstone' => 1,
	'Dripstone Block' => 1
);
$catList['Milk'] = array(
	'Cake' => 1,
	'Milk Bucket' => 1
);
$catList['Ink'] = array(
	'Ink Sac' => 1,
	'Gray Dye' => 1
);
$catList['Glow Ink'] = array(
	'Glow Ink Sac' => 1,
	'Glow Item Frame' => 1
);
$catList['Simple Redstone'] = array(
	'Redstone Repeater' => 1,
	'Block of Redstone' => 1
);
$catList['Kelp'] = array(
	'Dried Kelp' => 1,
	'Dried Kelp Block' => 1
);
$catList['Taiga'] = array(
	'Fern' => 1,
	'Sweet Berries' => 1
);
$catList['Lime'] = array(
	'Lime Dye' => 1,
	'Sea Pickle' => 1
);
$catList['Cactus'] = array(
	'Green Dye' => 1,
	'Lime Dye' => 1
);
$catList['Wheat'] = array(
	'Target' => 1,
	'Hay Bale' => 1
);
$catList['Wool'] = array(
	'Painting' => 1,
	'Red Bed' => 1
);
$catList['Apple'] = array(
	'Apple' => 1,
	'Golden Apple' => 1
);
$catList['Snow'] = array(
	'Snow' => 1
);

?>
<html>
	<head>
		<title>Fetchr Default Item Pool</title>
		<link rel="stylesheet" type="text/css" href="styles.css">
		<link rel="icon" type="image/png" href="../images/mc-items/Invicon_Buried_Treasure_Map.png">
	</head>
	<body>
		<p class="pagetitle">Fetchr Default Item Pool</p>
		<p class="version">Version 5.1.1 for Minecraft 1.20.2</p>

		<p>There are 161 items (152 unique) listed within 46 categories.</p>
		<p>Once an item has been selected from a category, no other items can be selected from the same category.</p>
		<p>This also includes other categories that the same item is also listed in.</p>
		<p>Items listed in multiple categories are <span class="duplicateItem">highlighted in blue</span>.</p>

		<div class="itemcats">
			<?php foreach($catList as $catName => $itemArray) { ?>
			<div class="itemcat">
				<p class="catheading"><?php echo $catName; ?></p>
				<table class="itemcat">
					<tr>
						<th>&nbsp;</th>
						<th>Item</th>
						<th class="weight">Weight</th>
					</tr>
					<?php foreach($itemArray as $itemName => $itemWeight) { ?>
					<tr>
						<td class="invicon"><?php RenderItem($itemName); ?></td>
						<td class="weight"><?php echo $itemWeight; ?></td>
					</tr>
					<?php } ?>
				</table>
			</div>
			<?php } ?>
		</div>
	</body>
</html>
