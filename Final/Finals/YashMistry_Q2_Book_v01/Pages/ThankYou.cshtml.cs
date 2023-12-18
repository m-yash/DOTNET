
// Yash Mistry, Section 4, Version 1, 8931383
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YashMistry_Q2_Book_v01.Pages;

public class ThankYouModel : PageModel
{

    private readonly ILogger<ThankYouModel> _logger;

    public EBook? eBookObject;

    public ThankYouModel(ILogger<ThankYouModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(EBook _eBookObject)
    {
        eBookObject = _eBookObject;
        Console.WriteLine(eBookObject.BookName);
    }
}