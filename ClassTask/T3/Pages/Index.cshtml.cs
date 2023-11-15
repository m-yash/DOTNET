using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T3.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string Name {get; set;}

    public string Address {get; set;}

    public string Website {get; set;}
    public string PhoneNo {get; set;}

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Name = "Nissan r34";
        Address = "Kyoto, Waterloo, ON";
        Website = "https://jdm-expo.com/5-nissan";
        PhoneNo = "+13243243435";
    }

    public IActionResult OnPost()
    {
        // Console.WriteLine(book.ToString());
        return RedirectToPage("Reservation");
    }
}

// public class CarReservation 
