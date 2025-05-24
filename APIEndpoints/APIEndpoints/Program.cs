var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Root Path");

app.MapGet("/downloads", () => "Downloads");

app.MapPut("/", () => "this is a put");

app.MapDelete("/", () => "this is a ");

app.MapPost("/", () => "this is a put");

app.Run();

