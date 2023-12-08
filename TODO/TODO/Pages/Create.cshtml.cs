using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TODO.Pages;

public class CreateModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public TODOItem TODOItem = new TODOItem();

    public TODODBService tODODBService;

    public CreateModel(TODODBService TODODBService)
    {
        tODODBService = TODODBService;
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost(TODOItem tODOItem) {
        // tODOService.SaveTODOItem(tODOItem);
        tODODBService.SaveTodos(tODOItem);

        return RedirectToPage("Index");
    }
}

