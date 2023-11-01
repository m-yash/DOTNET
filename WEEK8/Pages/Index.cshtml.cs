using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEEK8.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string name {get; set;}
    public string x {get; set;}

    public bool LoginCheck {get; set;}

    public List<string> weeks = new List<string>();
    

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
        Console.WriteLine("true or false?");
        x = Console.ReadLine() ?? string.Empty;
        LoginCheck = bool.Parse(x);
        // name = "yy" ?? string.Empty;
        // Console.WriteLine(name);

        weeks.Add("Monday");
        weeks.Add("Tuesday");
        weeks.Add("Wednesday");
        weeks.Add("Thursday");
        weeks.Add("Friday");
        weeks.Add("Saturday");
        weeks.Add("Sunday");
    }
}
