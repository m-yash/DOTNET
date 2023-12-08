using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Project.Pages;

public class ExistingReservationsModel : PageModel
{

    private readonly ILogger<ExistingReservationsModel> _logger;

    public Reservation? reserve;
    public CarDetails? cardetails;

    // public Reservation reserve = new Reservation();
    private CarData cardata = new CarData();

    public string reservationFile = "reservations.json";
    public string availablecarsFile = "availablecars.json";

    public List<Reservation>? reservationList = new List<Reservation>();

    public ExistingReservationsModel(ILogger<ExistingReservationsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // Reading reservations.json
        string ReadReservationsJson = System.IO.File.ReadAllText(reservationFile);
        reservationList = JsonConvert.DeserializeObject<List<Reservation>>(ReadReservationsJson);
    }

    
}