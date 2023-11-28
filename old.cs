  Console.WriteLine("Hello, World!");
        int result = AddLambda(5, 5);
        Console.WriteLine(result);
        Console.WriteLine(positive(-1));
        Console.WriteLine(subtractTwo(4));
        Console.WriteLine(CutomMutiline(4, 7));

        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // fitering
        List<int> evenNumbers = numbers.Where(x => (x % 2 == 0)).ToList();

        List<int> evenNumbersDivisibleBy3 = numbers.Where(x => x % 2 == 0).Where(x => x % 3 == 0).ToList();
        Console.WriteLine("Even");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("divisible by 3");
        foreach (var number in evenNumbersDivisibleBy3)
        {
            Console.WriteLine(number);
        }

        List<string> studentNames = new List<string>() { "Adam", "john", "Lisa", "Nich", "sam", "elizabeth" };

        List<string> studentNameWithA = studentNames.Where(name => name.ToLower().StartsWith('a')).ToList();

        List<string> studentNameContainsA = studentNames.Where(name => name.ToLower().Contains('a')).ToList();

        // List of students that has more than 5 letters
        List<string> studentNamelength5 = studentNames.Where(name => name.Length > 5).ToList();

        Console.WriteLine("Student names length greater than 5");
        foreach (var names in studentNamelength5)
        {
            Console.WriteLine(names);
        }

        // Create list of squares of initial number
        List<int> squares = numbers.Select(x => x * x).ToList();
        Console.WriteLine("Squares");
        foreach (var number in squares)
        {
            Console.WriteLine(number);
        }

        // create a list of integers that contains the length of each student names
        List<int> studentNameLengths = studentNames.Select(name => name.Length).ToList();
        Console.WriteLine("Student names lists");
        foreach (var names in studentNameLengths)
        {
            Console.WriteLine(names);
        }

        List<int> squareOfEvenNumbers = numbers.Where(x => x % 2 == 0).Select(x => x * x).ToList();
        Console.WriteLine("square of even numbers");
        foreach (var number in squareOfEvenNumbers)
        {
            Console.WriteLine(number);
        }

        // Order by
        List<string> cities = new List<string>{
            "toronto","waterloo","montreal"
        };

        Console.WriteLine("City Order By");

        List<string> citiesInAsc = cities.OrderBy(city => city).ToList();
        List<string> citiesInDes = cities.OrderByDescending(city => city).ToList();
        foreach (var city in citiesInDes)
        {
            Console.WriteLine(city);
        }

        List<int> scores = new List<int>{
            3,2,10,1,10,43,23,94,31
        };

        Console.WriteLine("Score Order By");
        List<int> scoreInAsc = scores.OrderBy(s => s).ToList();
        // List<string> citiesInDes = cities.OrderByDescending(city => city).ToList();
        foreach (var ss in scoreInAsc)
        {
            Console.WriteLine(ss);
        }


static int Add(int x, int y)
    {
        return x + y;
    }

    static Func<int, int, int> AddLambda = (x, y) => x + y;

    static Func<int, bool> positive = (x) => x < 0;

    static Func<int, int> subtractTwo = (x) => x - 2;

    static Func<int, int, bool> CutomMutiline = (x, y) =>
    {
        int z = x * y;
        int w = z + x + y;
        bool isGreaterThan80 = w > 80;
        return isGreaterThan80;
    };
