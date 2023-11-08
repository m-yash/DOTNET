using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEEK8.Pages;

public class ConfirmationModel : PageModel
{

    private readonly ILogger<ConfirmationModel> _logger;

    public Book book;
    public ConfirmationModel(ILogger<ConfirmationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(Book _book)
    {
        book = _book;
    }
}