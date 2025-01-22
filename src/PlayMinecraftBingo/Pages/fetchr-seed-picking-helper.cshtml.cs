using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlayMinecraftBingo.Pages
{
	public class fetchr_seed_picking_helperModel : PageModel
    {
		[BindProperty(SupportsGet = true)]
		public int Seed { get; set; }
		
		public int Copper { get; set; }
		public int Iron { get; set; }
		public int Gold { get; set; }
		public int Redstone { get; set; }
		public int Lapis { get; set; }
		public int Diamond { get; set; }

        public bool Shears { get; set; }
        public bool SmithingTable { get; set; }
        public bool Trim { get; set; }

        public bool BadR1 { get; set; }
		public bool BadR2 { get; set; }
		public bool BadR3 { get; set; }
		public bool BadR4 { get; set; }
		public bool BadR5 { get; set; }
		public bool BadC1 { get; set; }
		public bool BadC2 { get; set; }
		public bool BadC3 { get; set; }
		public bool BadC4 { get; set; }
		public bool BadC5 { get; set; }
		public bool BadFS { get; set; }
		public bool BadBS { get; set; }

		public IActionResult OnPost(int seed)
		{
			return Redirect("/fetchr-seed-picking-helper/" + seed);
		}
/*
		public void OnGet()
		{
			List<string> Card = CardGeneration.GenerateFromSeed(Seed);
			
			foreach (int slot in new int[] { 0, 1, 2, 3, 4 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadR1 = true;
				break;
			}
			foreach (int slot in new int[] { 5, 6, 7, 8, 9 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadR2 = true;
				break;
			}
			foreach (int slot in new int[] { 10, 11, 12, 13, 14 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadR3 = true;
				break;
			}
			foreach (int slot in new int[] { 15, 16, 17, 18, 19 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadR4 = true;
				break;
			}
			foreach (int slot in new int[] { 20, 21, 22, 23, 24 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadR5 = true;
				break;
			}

			foreach (int slot in new int[] { 0, 5, 10, 15, 20 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadC1 = true;
				break;
			}
			foreach (int slot in new int[] { 1, 6, 11, 16, 21 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadC2 = true;
				break;
			}
			foreach (int slot in new int[] { 2, 7, 12, 17, 22 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadC3 = true;
				break;
			}
			foreach (int slot in new int[] { 3, 8, 13, 18, 23 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadC4 = true;
				break;
			}
			foreach (int slot in new int[] { 4, 9, 14, 19, 24 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadC5 = true;
				break;
			}

			foreach (int slot in new int[] { 4, 8, 12, 16, 20 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadFS = true;
				break;
			}
			foreach (int slot in new int[] { 0, 6, 12, 18, 24 })
			{
				if (FetchrCardPreview.IsBad(Card[slot])) BadBS = true;
				break;
			}
		}*/
	}
}
