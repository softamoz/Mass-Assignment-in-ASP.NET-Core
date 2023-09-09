using MassAssignmentDemo.BlazorWebApp;
using Index = MassAssignmentDemo.BlazorWebApp.Pages.Index;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents();
builder.Services.AddSingleton(new List<Index.Person>());

var app = builder.Build();

app.UseStaticFiles();

app.MapRazorComponents<App>();

app.Run();