using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace T3.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string car1_Name {get; set;} = string.Empty;
    public string car1_Model {get; set;} = string.Empty;
    public string car1_Website {get; set;} = string.Empty;
    
    public string car2_Name {get; set;} = string.Empty;
    public string car2_Model {get; set;} = string.Empty;
    public string car2_Website {get; set;} = string.Empty;

    public string car3_Name {get; set;} = string.Empty;
    public string car3_Model {get; set;} = string.Empty;
    public string car3_Website {get; set;} = string.Empty;

    public string car4_Name {get; set;} = string.Empty;
    public string car4_Model {get; set;} = string.Empty;
    public string car4_Website {get; set;} = string.Empty;

    
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
 
        car1_Name = "R34 Skyline";
        car1_Model = "Nissan";
        car1_Website = "https://jdm-expo.com/5-nissan";

        car2_Name = "Murcielago";
        car2_Model = "Lamborghini";
        car2_Website = "https://www.autotrader.ca/a/Lamborghini/Murcielago/North%20York/ON/5_59287854_20111115101047209/?loc=M3J2L4&store=20111115101047209&gad_source=1&gclid=EAIaIQobChMIs_bgsr_gggMVpzPUAR3bFwi5EAQYASABEgJtTfD_BwE";

        car3_Name = "Agera RS";
        car3_Model = "Koenigsegg";
        car3_Website = "https://luxurypulse.com/sales/show/374-koenigsegg-agera-rs";

        car4_Name = "Model S";
        car4_Model = "Tesla";
        car4_Website = "https://www.autotrader.ca/cars/tesla/model%20s/on/?gad_source=1&gclid=CjwKCAiA04arBhAkEiwAuNOsIv_zfQdIytcvkGiBuiZh3ayGO1jAT7Xp2rkSPcbv_iWI-YEdWH__BRoC3uUQAvD_BwE";
    }

    public IActionResult OnPost()
    {
        // Page Redirection
        return RedirectToPage("Reservation");
    }
}

