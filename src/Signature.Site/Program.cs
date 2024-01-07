using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Signature.Shared.Components.States;
using Signature.Shared.Interfaces;
using Signature.Site;
using Signature.Site.Pages;
using Signature.Site.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IBarCodeReadService, BarCodeService>();

builder.Services.AddSingleton<NotaFiscalState>();

builder.Services.AddSingleton<ICameraService, CameraService>();


await builder.Build().RunAsync();
