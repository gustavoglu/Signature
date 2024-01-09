using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddHttpClient("api", client => client.BaseAddress = new Uri("https://localhost:7051/api/"));

builder.Services.AddSingleton<NotaFiscalState>();

builder.Services.AddSingleton<IBarCodeReadService, BarCodeService>();
builder.Services.AddSingleton<ICameraService, CameraService>();

await builder.Build().RunAsync();
