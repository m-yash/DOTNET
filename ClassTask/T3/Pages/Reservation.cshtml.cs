using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T3.Pages;

public class ReservationModel : PageModel
{
    private readonly ILogger<ReservationModel> _logger;
    
    public Reservation reserve;

    public ReservationModel(ILogger<ReservationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }

    public IActionResult OnPost(Reservation reserve)
    {
        Console.WriteLine(reserve.ToString());
        return RedirectToPage("Confirmation", reserve);
    }
}


public class Reservation{
    public string CarType {get; set;}
    public string FromDate {get; set;}
    public string ToDate {get; set;}


    public string ToString(){
        // return string.Format("Book Name: {0}, Book Author: {1}", BookName, BookAuthor);
        return $"Cartype: {CarType}, From Date: {FromDate}, To Date: {ToDate}";
    }
}