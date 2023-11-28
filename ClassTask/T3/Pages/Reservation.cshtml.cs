using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T3.Pages;

public class ReservationModel : PageModel
{
    private readonly ILogger<ReservationModel> _logger;
    
    public Reservation reserve = new Reservation();

    public List<Car> Cars { get; set; }  = new List<Car>();

    public ReservationModel(ILogger<ReservationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Cars = new List<Car>
        {
            new Car { Model = "Nissan", Name = "R34 Skyline" },
            new Car { Model = "Lamborghini", Name = "Murcielago" },
            new Car { Model = "Koenigsegg", Name = "Agera RS" },
            new Car { Model = "Tesla", Name = "Model S" }
        };
    }

    public IActionResult OnPost(Reservation reserve)
    {
        Console.WriteLine(reserve.ToString());

        // Page Redirection
        return RedirectToPage("Confirmation", reserve);
    }
}


// Class
public class Reservation{
    public string CarName {get; set;} = string.Empty;
    public string UserName {get; set;} = string.Empty;
    public string UserMobileNumber {get; set;} = string.Empty;
    public string UserReservationDateTime {get; set;} = string.Empty;
    
    public override string ToString(){
        return $"CarName: {CarName} UserName: {UserName}, Mobile Number: {UserMobileNumber}, Reservation Date: {UserReservationDateTime}";
    }
}
public class Car
    {
        public string Model { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }