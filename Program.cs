using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run(async (context) =>
{
    //context.Response.ContentType = "text/html; charset=utf-8";
    //var stringBuilder = new System.Text.StringBuilder("<h3>Параметры строки запроса</h3><table>");
    //stringBuilder.Append("<tr><td>Параметр</td><td>Значение</td></tr>");
    //foreach (var param in context.Request.Query)
    //{
    //    stringBuilder.Append($"<tr><td>{param.Key}</td><td>{param.Value}</td></tr>");
    //}
    //stringBuilder.Append("</table>");
    //await context.Response.WriteAsync(stringBuilder.ToString());


    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.SendFileAsync("html/Index.html");

});

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
