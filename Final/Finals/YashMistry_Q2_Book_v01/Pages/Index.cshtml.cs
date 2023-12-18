// what is GET and POST
// GET and POST are HTTP methods. GET is used to fetch data whereas POST is used to pass/store data.
// GET acts as a select query (data is retrieve from somewhere) whereas POST acts as a create/insert query (data is saved somwehre)
// The data is visible in the URL for GET whereas data is not in the URL for POST

// Yash Mistry, Section 4, Version 1, 8931383

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YashMistry_Q2_Book_v01.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public IActionResult OnPost()
    {
        // Page Redirection
        return RedirectToPage("AddEBook");
    }
}
