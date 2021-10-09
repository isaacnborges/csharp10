using MinimalToDoApp.Data;
using MinimalToDoApp.Dtos;
using MinimalToDoApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ToDoContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/todos", (ToDoContext context) => {
    var todos = context.ToDos.ToList();
    return Results.Ok(todos);
});

app.MapGet("/todos/{id}", (ToDoContext context, Guid id) => {
    var todo = GetTodo(context, id);

    if (todo == null)
        return Results.NotFound("Not found");

    return Results.Ok(todo);
});

app.MapPost("/todos", (ToDoContext context, ToDoDto dto) =>
{
    var todo = new ToDo(Guid.NewGuid(), dto.Title, dto.Done);

    context.ToDos.Add(todo);
    context.SaveChanges();

    return Results.Created($"/{todo.Id}", todo);
});

app.MapPut("/todos/{id}", (ToDoContext context, Guid id, ToDoDto dto) =>
{
    var todo = GetTodo(context, id);

    if (todo == null)
        return Results.NotFound("Not found");

    todo.Title = dto.Title;
    todo.Done = dto.Done;

    context.ToDos.Update(todo);
    context.SaveChanges();

    return Results.NoContent();
});

app.MapDelete("/todos{id}", (ToDoContext context, Guid id) =>
{
    var todo = GetTodo(context, id);

    if (todo == null)
        return Results.NotFound("Not found");

    context.ToDos.Remove(todo);
    context.SaveChanges();

    return Results.NoContent();
});

ToDo GetTodo(ToDoContext context, Guid id) => context.ToDos.First(x => x.Id == id);

app.Run();
