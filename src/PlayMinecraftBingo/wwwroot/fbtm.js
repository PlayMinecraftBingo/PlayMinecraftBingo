var itemStates = null;
var itemStateKeys = null;

//var UrlBase = "http://localhost:5183";
var UrlBase = "https://api.playminecraftbingo.com";

async function GetJObjectFromUrl(url)
{
    var request = new Request(url);
    var response = await window.fetch(request);
    var json = await response.text();
    return JSON.parse(json);
}

async function ReloadItemStates()
{
    itemStates = await GetJObjectFromUrl(UrlBase + "/fbtm/item-states/" + seed + "/fetchr." + team);

    var items = document.getElementsByClassName("mcitem");
    Array.prototype.forEach.call(items, function (item) { SetItemState(item); });

    setTimeout(ReloadItemStates, 5000);
}

function SetItemState(item)
{
    var itemId = item.attributes["data-mcitem"].value;

    if (itemStates.hasOwnProperty(itemId))
    {
        var itemState = itemStates[itemId];

        switch (itemState)
        {
            case 1:
                item.classList.add("fbtmImpliedNegative");
                item.classList.remove("fbtmCheckedNegative");
                item.classList.remove("fbtmImpliedPositive");
                item.classList.remove("fbtmCheckedPositive");
                break;
            case 2:
                item.classList.remove("fbtmImpliedNegative");
                item.classList.add("fbtmCheckedNegative");
                item.classList.remove("fbtmImpliedPositive");
                item.classList.remove("fbtmCheckedPositive");
                break;
            case 3:
                item.classList.remove("fbtmImpliedNegative");
                item.classList.remove("fbtmCheckedNegative");
                item.classList.add("fbtmImpliedPositive");
                item.classList.remove("fbtmCheckedPositive");
                break;
            case 4:
                item.classList.remove("fbtmImpliedNegative");
                item.classList.remove("fbtmCheckedNegative");
                item.classList.remove("fbtmImpliedPositive");
                item.classList.add("fbtmCheckedPositive");
                break;
            default:
                item.classList.remove("fbtmImpliedNegative");
                item.classList.remove("fbtmCheckedNegative");
                item.classList.remove("fbtmImpliedPositive");
                item.classList.remove("fbtmCheckedPositive");
                break;
        }
    } else {
        item.classList.remove("fbtmImpliedNegative");
        item.classList.remove("fbtmCheckedNegative");
        item.classList.remove("fbtmImpliedPositive");
        item.classList.remove("fbtmCheckedPositive");
    }
}
