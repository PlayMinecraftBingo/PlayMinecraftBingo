using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlayMinecraftBingo.Pages
{
    public class fetchr_seedsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public byte Prefix { get; set; }

        public IActionResult OnGet()
        {
            if (Prefix == 0) return RedirectPermanent("/fetchr-weekly-seeds/");

            if ((Prefix >= 10) && (Prefix <= 36)) return RedirectPermanent("/fetchr-weekly-seeds/" + Prefix);

            return NotFound();
        }
    }
}
