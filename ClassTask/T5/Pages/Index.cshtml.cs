using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T5.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public TODOService todo = new TODOService();

    public List<TODOItem> todoitems;
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        todoitems = todo.GetToDoItems();
    }
}
