using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T5.Pages;

public class CreateModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public TODOItem todo = new TODOItem();
    public CreateModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

