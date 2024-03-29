using CrudWithRenderModes.Shared.Interfaces;
using CrudWtithRenderModes.Client.Pages;
using CrudWtithRenderModes.Components;
using CrudWtithRenderModes.Context;
using CrudWtithRenderModes.Repositories;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var connectionString = builder.Configuration
                              .GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<SetoresContext>(opt =>
                   opt.UseSqlite(connectionString));

builder.Services.AddScoped<ISetoresRepository, SetoresRepositories>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("BaseAddress").Value!)
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(CrudWtithRenderModes.Client._Imports).Assembly);

app.Run();
