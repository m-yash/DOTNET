using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T3.Pages;

public class ConfirmationModel : PageModel
{

    private readonly ILogger<ConfirmationModel> _logger;

    public Reservation? reserve;
    public ConfirmationModel(ILogger<ConfirmationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(Reservation _reserve)
    {
        reserve = _reserve;
    }

    public IActionResult OnPost()
    {
        // Page Redirection
        return RedirectToPage("Index");
    }
}