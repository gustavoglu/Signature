using Microsoft.Extensions.Logging;
using Signature.App.Services;
using Signature.Shared.Components.States;
using Signature.Shared.Interfaces;
using ZXing.Net.Maui.Controls;

namespace Signature.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseBarcodeReader()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddHttpClient("api", client => client.BaseAddress = new Uri("https://localhost:7051/api/"));

            builder.Services.AddScoped<IBarCodeReadService, BarCodeReadService>();
            builder.Services.AddScoped<IDeviceService, DeviceService>();
            builder.Services.AddSingleton<ICameraService, CameraService>();

            builder.Services.AddSingleton<NotaFiscalState>();
            builder.Services.AddSingleton<MainState>();




#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
