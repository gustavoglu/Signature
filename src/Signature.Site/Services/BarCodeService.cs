using Signature.Shared.Interfaces;

namespace Signature.Site.Pages
{
    public class BarCodeService : IBarCodeReadService
    {
        public async Task<string> ReadBarCode()
        {
            return "Site Barcode";
        }
    }
}
