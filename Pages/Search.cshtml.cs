using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMWCTFY.Pages;

public class SearchModel : PageModel
{
    public string? Query { get; set; }

    public IActionResult OnGet([FromQuery(Name = "s")] string? s)
    {
        Query = s;
        if (string.IsNullOrWhiteSpace(Query))
        {
            return RedirectToPage("/Index");
        }
        return Page();
    }
}
