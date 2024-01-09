using Signature.Shared.Interfaces;

namespace Signature.Site.Services
{
    public class DeviceService : IDeviceService
    {
        public bool IsWeb()
        {
            return true;
        }
    }
}
