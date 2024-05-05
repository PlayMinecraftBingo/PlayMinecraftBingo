function ResetAll()
{
	catStates = catStates.fill(0);
	itemStates = itemStates.fill(0);

	document.getElementById("hidecompletedcats").checked = false;

	RefreshDisplay();
}

function HaveItem(i)
{
	itemStates[i] = 3;
	RefreshDisplay();
}

function NotItem(i)
{
	itemStates[i] = 2;
	RefreshDisplay();
}

function ClearItem(i)
{
	itemStates[i] = 0;
	RefreshDisplay();
}

function RefreshDisplay()
{
	for (const i in itemStates)
	{
		if (itemStates[i] < 2) itemStates[i] = 0;
	}
	for (const i in catStates)
	{
		catStates[i] = 0;
	}

	CheckCats();

	for (const i in catStates)
	{
		if (i > 0)
		{
			var itemCatId = "itemcat";
			if (i < 100) itemCatId += "0";
			if (i < 10) itemCatId += "0";
			itemCatId += i;

			if (document.getElementById("hidecompletedcats").checked)
			{
				if (catStates[i] == 1) {
					document.getElementById(itemCatId).style.display = "none";
				} else {
					document.getElementById(itemCatId).style.display = "";
				}
			} else {
				document.getElementById(itemCatId).style.display = "";
			}
		}
	}

	for (const i in itemStates)
	{
		if (i > 0)
		{
			var itemRowId = "itemrow";
			if (i < 100) itemRowId += "0";
			if (i < 10) itemRowId += "0";
			itemRowId += i;

			switch (itemStates[i])
			{
				case 1:
					document.getElementById(itemRowId).className = "havecat";
					document.getElementById(itemRowId + "yes").style.display = "none";
					document.getElementById(itemRowId + "no").style.display = "none";
					document.getElementById(itemRowId + "clear").style.display = "none";
					break;
				case 2:
					document.getElementById(itemRowId).className = "notitem";
					document.getElementById(itemRowId + "yes").style.display = "none";
					document.getElementById(itemRowId + "no").style.display = "none";
					document.getElementById(itemRowId + "clear").style.display = "";
					break;
				case 3:
					document.getElementById(itemRowId).className = "haveitem";
					document.getElementById(itemRowId + "yes").style.display = "none";
					document.getElementById(itemRowId + "no").style.display = "none";
					document.getElementById(itemRowId + "clear").style.display = "";
					break;
				default:
					document.getElementById(itemRowId).className = "";
					document.getElementById(itemRowId + "yes").style.display = "";
					document.getElementById(itemRowId + "no").style.display = "";
					document.getElementById(itemRowId + "clear").style.display = "none";
					break;
			}
		}
	}
}

RefreshDisplay();
