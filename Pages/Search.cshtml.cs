using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMWCTFY.Pages;

public class SearchModel : PageModel
{
    [BindProperty(SupportsGet = true)]
    public string? Query { get; set; }

    public IActionResult OnGet()
    {
        if (string.IsNullOrWhiteSpace(Query))
        {
            return RedirectToPage("/Index");
        }
        return Page();
    }
}
