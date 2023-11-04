global using BookingSystem.Client.Repositorios;
global using BookingSystem.Shared;
global using System.Net.Http.Json;
using Blazorise;
using Blazorise.Icons.Material;
using Blazorise.Material;
using BookingSystem.Client;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;




var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IServicioRepositorio, ServicioRepositorio>();
builder.Services.AddScoped<IProfesionalRepositorio, ProfesionalRepositorio>();
builder.Services.AddScoped<IProfesionalDetalleRepositorio, ProfesionalDetalleRepositorio>();
builder.Services.AddMudServices();
builder.Services.AddSweetAlert2();
builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddMaterialProviders()
    .AddMaterialIcons();



await builder.Build().RunAsync();
