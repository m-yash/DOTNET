// Difference between inheritance and interface
// inheritance is the ability where the subclass inherits the property of the superclass whereas interface is like it declares the methods and properties and the implementing class will define methods and properties

// Yash Mistry, Section 4, Version 1, 8931383
namespace YashMistry_Q1_Book_v01;

class Program
{
    static void Main(string[] args)
    {
        Book bookObject = new Book();
        AudioBook audioBookObject = new AudioBook();
        EBook eBookObject = new EBook();

        bool looper = true;

        while (looper)
        {
            Console.WriteLine("\n1. Add Ebook\n2. Add AudioBook\n3. View Ebook and AudioBook\n4. Exit");
            var path = int.Parse(Console.ReadLine() ?? string.Empty);

            // Add EBook
            if (path == 1)
            {
                // Exception Handling
                try
                {
                    Console.WriteLine("Enter EBook Name");
                    string EBookNameInput = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Enter EBook File Size");
                    double EBookFileSize = double.Parse(Console.ReadLine() ?? string.Empty);

                    eBookObject.BookName = EBookNameInput;
                    eBookObject.FileSize = EBookFileSize;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            // Add AudioBook
            else if (path == 2)
            {
                // Exception Handling
                try
                {
                    Console.WriteLine("Enter AudioBook Name");
                    string AudioBookNameInput = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Enter AudioBook Length (Write in seconds!)");
                    int AudioBookLength = int.Parse(Console.ReadLine() ?? string.Empty);

                    audioBookObject.BookName = AudioBookNameInput;
                    audioBookObject.Length = AudioBookLength;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            // Display
            else if (path == 3)
            {
                Console.WriteLine(eBookObject);
                Console.WriteLine(audioBookObject);
            }
            // Exit
            else if (path == 4)
            {
                looper = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }


    public class Book
    {
        public string BookName { get; set; } = string.Empty;
        public string BookType { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"Book Name: {BookName} and Book Type: {BookType}";
        }
    }
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

    public class AudioBook : Book
    {

        public int Length { get; set; }

        // Default constructor
        public AudioBook()
        {
            BookType = "AudioBook";
        }
        public override string ToString()
        {
            return $"AudioBook Details - {base.ToString()}. Length is: {Length}";
        }
    }

}
