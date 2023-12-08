using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TODO.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private TODOService tODOService = new TODOService();

    public List<TODOItem> TODOItems;

    // DB
    private TODODBService todoDBService;

    public IndexModel(TODODBService todoService)
    {
        todoDBService = todoService;
    }

    public void OnGet()
    {
        // TODOItems = tODOService.GetTODOItemsJSON();
        TODOItems = todoDBService.GetTodos();

    }
}
