namespace MinimalToDoApp.Models;

public class ToDo
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public bool Done { get; set; }

    public ToDo(Guid id, string title, bool done)
    {
        Id = id;
        Title = title;
        Done = done;
    }
}
