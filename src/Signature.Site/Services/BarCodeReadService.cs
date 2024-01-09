using Signature.Shared.Interfaces;

namespace Signature.Site.Services
{
    public class BarCodeReadService : IBarCodeReadService
    {
        public Task<string> ReadBarCode()
        {
            return null;
        }

        public Task StopRead()
        {
            return Task.CompletedTask;
        }
    }
}
