using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TODO.Pages;

public class EditModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public TODOItem TODOItem = new TODOItem();

    public TODODBService tODODBService;

    public EditModel(TODODBService TODODBService)
    {
        tODODBService = TODODBService;
    }

    public IActionResult OnGet(int id)
    {
        TODOItem = tODODBService.Getodo(id);
        if(TODOItem == null)
        {
            return RedirectToPage("Error");
        }
        return Page();


    }

    public IActionResult OnPost(TODOItem tODOItem) {
        // tODOService.SaveTODOItem(tODOItem);
        TODOItem existingTodo = tODODBService.Getodo(tODOItem.ID);
        Console.WriteLine(existingTodo.ToString());
        
        existingTodo.Title = tODOItem.Title;
        existingTodo.IsCompleted = tODOItem.IsCompleted;

        tODODBService.UpdateTodos(existingTodo);


        // tODODBService.SaveTodos(tODOItem);

        return RedirectToPage("Index");
        
    }
}

