public class TODOItem {
    public int ID {get;set;}
    public string Title {get;set;}
    public bool IsCompleted {get;set;}

    public TODOItem(int id, string title, bool isCompleted){
        ID = id;
        Title = title;
        IsCompleted = isCompleted;
    }

    public TODOItem() {

    }
}