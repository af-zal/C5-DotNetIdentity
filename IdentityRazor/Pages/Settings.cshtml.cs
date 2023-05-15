using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityRazor.Pages
{
    [Authorize(Policy ="Adminonly")]
    public class SettingsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
