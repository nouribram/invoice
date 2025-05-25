using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Root Path");

app.MapGet("/downloads", () => "Downloads");

app.MapPut("/", () => "this is a put");

app.MapDelete("/", () => "this is a ");

app.MapPost("/", () => "this is a put");

app.Run();

public class Blog
{
    public required string Title { get; set; }
    
    public required string Body { get; set; }
}
