using BlazorWasmApp;
using BlazorWasmApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registrar MudBlazor
builder.Services.AddMudServices();

// Registrar HttpClient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Registrar Servicios en memoria
builder.Services.AddScoped<AnalysisService>();
builder.Services.AddScoped<SupplierService>();
builder.Services.AddScoped<LotService>();

// Registrar Servicio de Autenticación con IJSRuntime
builder.Services.AddScoped<AuthenticationService>();

var host = builder.Build();

// Inicializar servicio de autenticación
var authService = host.Services.GetRequiredService<AuthenticationService>();
await authService.InitializeAsync();

await host.RunAsync();
