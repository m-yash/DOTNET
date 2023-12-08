using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    private CarData cardata = new CarData();
    public List<CarDetails> cars = new List<CarDetails>();
       
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // Fetching data from availablecars.json
        cars = cardata.GetCarDataJSON();
    }

    public IActionResult OnPost()
    {
        // Page Redirection
        return RedirectToPage("Reservation");
    }
}


