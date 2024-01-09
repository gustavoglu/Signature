using Signature.App.Pages;
using Signature.Shared.Interfaces;

namespace Signature.App.Services
{
    public class BarCodeReadService : IBarCodeReadService
    {
        TaskCompletionSource<string> taskCompletionSource;
        BarCodePage barCodePage;

        public async Task<string> ReadBarCode()
        {
            taskCompletionSource = new TaskCompletionSource<string>();
            barCodePage = new BarCodePage();
            barCodePage.BarCodeChanged += OnBarCodeChanged;
            await App.Current.MainPage.Navigation.PushModalAsync(barCodePage);
            return await taskCompletionSource.Task;
        }

        public async void OnBarCodeChanged(object? sender, string barCode)
        {
            taskCompletionSource.SetResult(barCode);
        }

        public async Task StopRead()
        {
            barCodePage.BarCodeChanged -= OnBarCodeChanged;
            if (App.Current.MainPage.Navigation.ModalStack.Count > 0)
                await App.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
