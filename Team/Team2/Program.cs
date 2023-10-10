namespace T1;

class Program
{
    static void Main(string[] args)
    {
        Patient yash = new Patient();
        yash.name = "Yash";

        Patient ash = new Patient();
        ash.name = "Ash";

        Medicine crocin = new Medicine();
        crocin.name = "Crocin";
        crocin.price = 400;

        Medicine dola = new Medicine();
        dola.name = "Dola";
        dola.price = 300;      

        ITreatable standardTre = new StandardTreatment();
        ITreatable premiumTre = new PremiumTreatment();

        Order o1 = new Order();
        o1.patient = yash;
        o1.Addproduct(crocin);
        // o1.Addproduct(dola);
        o1.Addpatient(yash);
        o1.Displayorder();
        o1.treat = standardTre;
        // o1.shipProduct()
        o1.treat.TreatmentType();
      
    

        // Order o2 = new Order();
        // o2.patient = ash;
        // o2.Addproduct(crocin);
        // o2.Addproduct(dola);
        // o1.Addpatient(ash);
        // o2.Displayorder();
        // o2.treat = premiumTre;

       


    }
}

class User{
    public string name;

}

class Patient : User{ //patient

    public string name;

    public string address;
    public string email;
    public string phoneno;
}
class Doctor : User{ //doctor
    string priviledges;

}
interface ITreatable{ //treatment
    string name {get; set;}

    public void TreatmentType();
}

class PremiumTreatment : ITreatable{ //prenium treatment
    public string name {get; set;}
    public void TreatmentType(){
        Console.WriteLine("Treatment type: Premium");
    }
}

class StandardTreatment : ITreatable{ //stantdard treatment
    public string name {get; set;}
    public void TreatmentType(){
        Console.WriteLine("Treatment type: Standard");
    }
}

class Medicine{ //medicine
    public string name;
    public decimal price;
    public bool isAvailable; // isTreatable
}

class Order{ //treat

    public List<Patient> pa = new List<Patient>();
    
    public void Addpatient(Patient p1){
        pa.Add(p1);
    }
    public List<Medicine> orders = new List<Medicine>();
    public Patient patient;
    public ITreatable treat;

    public void Addproduct(Medicine p1){
        orders.Add(p1);
    }

    public void Displayorder(){
        foreach (var item in pa)
        {
            Console.WriteLine($"Patient Name: {item.name}");

        }
        foreach (var item in orders)
        {
            Console.WriteLine($"Medicine to be used: {item.name} Price({item.price})");
        }
        
    }
}