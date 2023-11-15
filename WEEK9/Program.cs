using System.Globalization;
using CsvHelper;

namespace Week9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        List<Student> students = new List<Student>(){
            new Student("123", "John"),
           new Student("345", "Jame"),
           new Student("567", "Max"),
           new Student("789", "Nick"),
        };

        //Write to txt file
        WriteToTxtFile("students.txt", students);

        // Read from text file
        ReadFromTxtFile("students.txt");

        WriteToCSVFile("students.csv", students);

        ReadFromCSVFile("students.csv");
    }

    private static void ReadFromCSVFile(string file)
    {
        Console.WriteLine("Reading from CSV file");
        var reader = new StreamReader(file);
        var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
        foreach(var student in csvReader.GetRecords<Student>()){
            Console.WriteLine(student.ToString());
        }
        reader.Close();
    }

    private static void WriteToCSVFile(string file, List<Student> students)
    {
         Console.WriteLine("Writing to CSV file");
        var writer = new StreamWriter(file);
        var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csvWriter.WriteRecords(students);
        csvWriter.Flush();
        writer.Close();
    }

    private static void ReadFromTxtFile(string file)
    {
        Console.WriteLine("Reading from text file");
        var reader = new StreamReader(file);
        while (!reader.EndOfStream)
        {
            Console.WriteLine(reader.ReadLine());
        }
        reader.Close();
    }

    private static void WriteToTxtFile(string file, List<Student> students)
    {
        Console.WriteLine("Writing to Txt file");
        using (var writer = new StreamWriter(file))
        {
            foreach (var student in students)
            {
                writer.WriteLine(student.ToString());
            }
        };
    }
}

class Student
{
    public string ID { get; set; }
    public string Name { get; set; }

    public Student(string ID, string Name)
    {
        this.Name = Name;
        this.ID = ID;
    }

    public override string ToString()
    {
        return String.Format("{0} {1}", ID, Name);
    }
}