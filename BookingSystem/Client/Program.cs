global using BookingSystem.Client.Repositorios;
global using BookingSystem.Shared;
global using System.Net.Http.Json;
using BookingSystem.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MatBlazor;



var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddMatToaster(config =>
{
    config.Position = MatToastPosition.BottomRight;
    config.PreventDuplicates = true;
    config.NewestOnTop = true;
    config.ShowCloseButton = true;
    config.MaximumOpacity = 95;
    config.VisibleStateDuration = 3000;
});
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IHorarioRepositorio, HorarioRepositorio>();
builder.Services.AddScoped<IProfesionalRepositorio, ProfesionalRepositorio>();


await builder.Build().RunAsync();
