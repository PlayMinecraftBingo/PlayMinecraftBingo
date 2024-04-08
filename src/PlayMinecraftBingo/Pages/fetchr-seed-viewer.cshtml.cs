using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlayMinecraftBingo.Pages
{
	public class fetchr_seed_viewerModel : PageModel
    {
		[BindProperty(SupportsGet = true)]
		public int Seed { get; set; }

		public IActionResult OnPost(int seed)
		{
			return Redirect("/fetchr-seed-viewer/" + seed);
		}
	}
}
