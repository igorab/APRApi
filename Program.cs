using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

//https://metanit.com/sharp/aspnet6/2.10.php

Task ReadData(HttpContext �ontext)
{
    
    return null;
}

RequestDelegate handler = ReadData;

app.Run(ReadData);

app.Run();


//var builder = WebApplication.CreateSlimBuilder(args);

//builder.Services.ConfigureHttpJsonOptions(options =>
//{
//options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
//});

//WebApplication app = builder.Build();

//Todo[] sampleTodos = new Todo[] {
//    new(1, "Walk the dog"),
//    new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
//    new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
//    new(4, "Clean the bathroom"),
//    new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
//};

//var todosApi = app.MapGroup("/todos");
//todosApi.MapGet("/", () => sampleTodos);
//todosApi.MapGet("/{id}", (int id) =>
//    sampleTodos.FirstOrDefault(a => a.Id == id) is { } todo
//        ? Results.Ok(todo)
//        : Results.NotFound());

//app.Run();

////app.UseWelcomePage();

//public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

//[JsonSerializable(typeof(Todo[]))]
//internal partial class AppJsonSerializerContext : JsonSerializerContext
//{

//}
