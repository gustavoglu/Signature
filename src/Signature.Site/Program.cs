using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Signature.Shared.Components.States;
using Signature.Shared.Interfaces;
using Signature.Site;
using Signature.Site.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("api", client => client.BaseAddress = new Uri("https://localhost:7051/api/"));

builder.Services.AddSingleton<NotaFiscalState>();
builder.Services.AddSingleton<MainState>();

builder.Services.AddScoped<IBarCodeReadService, BarCodeReadService>();
builder.Services.AddScoped<ICameraService, CameraService>();
builder.Services.AddScoped<IDeviceService, DeviceService>();


await builder.Build().RunAsync();
