using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace YashMistry_Q2_Book_v01.Pages;

public class AddEBookModel : PageModel
{
    private readonly ILogger<AddEBookModel> _logger;

    public Book bookObject = new Book();
    public EBook eBookObject = new EBook();

    
    public AddEBookModel(ILogger<AddEBookModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
   
    }

    public IActionResult OnPost(EBook eBookObject)
    {
        Console.WriteLine(eBookObject.ToString());

        // Page Redirection
        // Exception Handling
        try
        {
            return RedirectToPage("ThankYou", eBookObject);
        }
        catch (System.Exception)
        {
            
            return RedirectToPage("Error");
        }
    }
}


// Class
public class Book
{
    public string BookName { get; set; } = string.Empty;
    public string BookType { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Book Name: {BookName} and Book Type: {BookType}";
    }
}

// Inheriting
public class EBook : Book
{
    public double FileSize { get; set; }

    // Default constructor
    public EBook()
    {
        BookType = "EBook";
    }

    public override string ToString()
    {
        return $"EBook Details - {base.ToString()}. File size is: {FileSize}";
    }
}

