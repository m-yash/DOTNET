using Newtonsoft.Json;

public class CarData
{
    
    // List<Reservation> reservationList = new List<Reservation>();
    
    string availableCarsFile = "availablecars.json";
    public List<CarDetails> GetCarDataJSON()
    {
        string json = File.ReadAllText(availableCarsFile) ?? string.Empty;
        List<CarDetails>? carsavailable = JsonConvert.DeserializeObject<List<CarDetails>>(json);
        
        return carsavailable;
    }

    // string reservationFile = "reservations.json";
    // public void SaveCarDataJSON(TODOItem tODOItem)
    // public void SaveCarDataJSON(Reservation reserve)

    // {
    //     reservationList.Add(new Reservation(CarName, UserName, UserMobileNumber, UserReservationDateTime));

    //     // List<Reservation> tODOItems = GetTODOItemsJSON();
    //     // tODOItem.ID = tODOItems.Count + 1;
    //     // tODOItems.Add(tODOItem);

    //     string json = JsonConvert.SerializeObject(reservation, Formatting.Indented);
    //     File.WriteAllText(reservationFile, json);
    // }

}