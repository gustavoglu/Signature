using Signature.Shared.Interfaces;

namespace Signature.Presentation.Site.Services
{
    public class BarCodeService : IBarCodeReadService
    {
        public async Task<string> ReadBarCode()
        {
            return "Site Barcode";
        }
    }
}
