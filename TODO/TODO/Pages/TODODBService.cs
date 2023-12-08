// using System.Linq;

public class TODODBService
{
    private readonly TODOContext _dbContext;

    public TODODBService(TODOContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<TODOItem> GetTodos()
    {
        return _dbContext.Todos.ToList();
    }

    public void SaveTodos(TODOItem todo)
    {
        _dbContext.Todos.Add(todo);
        _dbContext.SaveChanges();
    }

    public void UpdateTodos(TODOItem todo)
    {
        _dbContext.Todos.Update(todo);
        _dbContext.SaveChanges();
    }

    public TODOItem Getodo(int id){
        return _dbContext.Todos.FirstOrDefault(todo => todo.ID == id);
    }

    
}