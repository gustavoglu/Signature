using Signature.App.Pages;
using Signature.Shared.Interfaces;

namespace Signature.App.Services
{
    public class BarCodeService : IBarCodeReadService
    {
        private string barCodeRead = null;

        public async Task<string> ReadBarCode()
        {
             var barCodePage = new BarCodePage();
             barCodePage.BarCodeChanged += OnBarCodeChanged;
             await App.Current.MainPage.Navigation.PushModalAsync(barCodePage);
            return "";
        }


        public void OnBarCodeChanged(object? sender,string barCode) {

            barCodeRead = barCode;
        }
    }
}
