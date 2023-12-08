using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace Project.Pages;

public class ConfirmationModel : PageModel
{

    private readonly ILogger<ConfirmationModel> _logger;

    public Reservation? reserve;
    public CarDetails? cardetails;

    // public Reservation reserve = new Reservation();
    private CarData cardata = new CarData();

    public string reservationFile = "reservations.json";
    public string availablecarsFile = "availablecars.json";

    List<Reservation> reservationList = new List<Reservation>();

    public ConfirmationModel(ILogger<ConfirmationModel> logger)
    {
        _logger = logger;
    }

    // public void OnGet(Reservation _reserve)

    public void OnGet(Reservation _reserve)
    {
        reserve = _reserve;
        if (reserve != null)
        {
            // Reading reservations.json for existing reservations
            string ReadReservationsJson = System.IO.File.ReadAllText(reservationFile) ?? string.Empty;

            List<Reservation>? reservationList = JsonConvert.DeserializeObject<List<Reservation>>(ReadReservationsJson);

            // Writing reservations.json
            reservationList.Add(new Reservation(reserve.CarName, reserve.UserName, reserve.UserMobileNumber, reserve.UserReservationDateTime));
            string WriteReservationsJson = JsonConvert.SerializeObject(reservationList, Formatting.Indented);
            System.IO.File.WriteAllText(reservationFile, WriteReservationsJson);

            // Reading availablecars.json
            string ReadAvailableCarsJson = System.IO.File.ReadAllText(availablecarsFile) ?? string.Empty;
            
            List<CarDetails>? availablecars = JsonConvert.DeserializeObject<List<CarDetails>>(ReadAvailableCarsJson);

            List<CarDetails>? availablecarsUpdated = availablecars.Where(car => !reservationList.Select(r => r.CarName).Contains(car.car_Name)).ToList();
            
            // Writing availablecars.json with new data
            string updatedAvailableCarsJson = JsonConvert.SerializeObject(availablecarsUpdated, Formatting.Indented);
            System.IO.File.WriteAllText(availablecarsFile, updatedAvailableCarsJson);
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    public IActionResult OnPost()
    {
        // Page Redirection
        return RedirectToPage("Index");
    }
}