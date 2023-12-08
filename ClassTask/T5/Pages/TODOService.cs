public class TODOService {
    public List<TODOItem> GetToDoItems(){
        List<TODOItem> todoitems = new List<TODOItem>{
            new TODOItem(1,"Assignment 3", false)
        };
        return todoitems;
    }

    // public List<TODOItem> GetTODOItemsJSON(){
    //     string json = File.
    // }
     
        string json = File.ReadAllText(file);

        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
}