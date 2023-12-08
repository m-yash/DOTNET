using Newtonsoft.Json;

public class TODOService {

    string TODOFile = "TODOs.json";
    public List<TODOItem> GetTODOItems() {
        List<TODOItem> tODOItems = new List<TODOItem> {
           new TODOItem(1, "Evaluate Assignment 3", false),
           new TODOItem(2, "Create Assignment 4", false),
           new TODOItem(3, "Prepare for Finals", false)
        };
        return tODOItems;
    }

    public List<TODOItem> GetTODOItemsJSON() {
        string json = File.ReadAllText(TODOFile);
        List<TODOItem> todos = JsonConvert.DeserializeObject<List<TODOItem>>(json);
        return todos;
    }

    public void SaveTODOItem(TODOItem tODOItem) {
        List<TODOItem> tODOItems = GetTODOItemsJSON();
        tODOItem.ID = tODOItems.Count + 1;
        tODOItems.Add(tODOItem);

        string json = JsonConvert.SerializeObject(tODOItems, Formatting.Indented);
        File.WriteAllText(TODOFile,json);
    }
}