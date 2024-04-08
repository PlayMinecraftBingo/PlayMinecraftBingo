using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlayMinecraftBingo.Pages
{
    public class fetchr_weekly_seedsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
		public byte Prefix { get; set; }
		
        internal FetchrWeeklySeeds? Seeds { get; set; }

		public IActionResult OnGet()
        {
            if (Prefix == 0) Prefix = FetchrWeeklySeeds.GetCurrentPrefix();

            if (FetchrWeeklySeeds.IsValidPrefix(Prefix))
            {
                Seeds = FetchrWeeklySeeds.GetByPrefix(Prefix);
                return Page();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
