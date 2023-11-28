// See https://aka.ms/new-console-template for more information
using System.Globalization;
using CsvHelper;
using Newtonsoft.Json;

namespace T4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Reservation System!");
        List<Car> reservation = new List<Car>();
        while (true)
        {

            Console.WriteLine("Enter Passenger Name");
            string passengername = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter Car Type");
            string cartype = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter Date From");
            string datefrom = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter Date To");
            string dateto = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("More? yes/no");

            reservation.Add(new Car(cartype, datefrom, dateto, passengername));

            var more = Console.ReadLine() ?? string.Empty;
            if (more == "no")
            {
                break;
            }
        }

        
        // List<Car> reservation = new List<Car>(){
        //     new Car(cartype, datefrom, dateto, passengername)
        // };


        //Write to txt file
        // WriteToTxtFile("students.txt", students);

        // Read from text file
        // ReadFromTxtFile("students.txt");

        WriteToCSVFile("ReservationList.csv", reservation);

        ReadFromCSVFile("ReservationList.csv");

        WriteToJSONFile("ReservationList.json", reservation);

        ReadFromJSONFile("ReservationList.json");
    }

    private static void WriteToJSONFile(string file, List<Car> reservation)
    {
        Console.WriteLine("Writing to JSON file");
        string json = JsonConvert.SerializeObject(reservation, Formatting.Indented);
        File.WriteAllText(file, json);
        Console.WriteLine(json);

    }

    private static void ReadFromJSONFile(string file)
    {
        Console.WriteLine("Reading from JSON file");
        string json = File.ReadAllText(file);

        List<Car> reservation = JsonConvert.DeserializeObject<List<Car>>(json);

        foreach (var reserve in reservation)
        {
            Console.WriteLine(reserve);
        }
    }


    private static void ReadFromCSVFile(string file)
    {
        Console.WriteLine("Reading from CSV file");
        var reader = new StreamReader(file);
        var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
        foreach (var reserve in csvReader.GetRecords<Car>())
        {
            Console.WriteLine(reserve.ToString());
        }
        reader.Close();
    }

    private static void WriteToCSVFile(string file, List<Car> reserve)
    {
        Console.WriteLine("Writing to CSV file");
        var writer = new StreamWriter(file);
        var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csvWriter.WriteRecords(reserve);
        csvWriter.Flush();
        writer.Close();
    }
}


class Car
{
    public string CarType { get; set; }
    public string DateFrom { get; set; }
    public string DateTo { get; set; }
    public string PassengerName { get; set; }


    public Car(string CarType, string DateFrom, string DateTo, string PassengerName)
    {
        this.CarType = CarType;
        this.DateFrom = DateFrom;
        this.DateTo = DateTo;
        this.PassengerName = PassengerName;
    }

    public override string ToString()
    {
        return String.Format("Passenger Name: {0}, Car Type: {1}, Date From: {2}, Date To: {3}", PassengerName, CarType, DateFrom, DateTo);
    }
}