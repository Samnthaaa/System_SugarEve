using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SugarEveSystem.Pages.Auth
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Dummy authentication for demo layout purposes
            return RedirectToPage("/Index");
        }
    }
}
