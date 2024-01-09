using Signature.Shared.Interfaces;

namespace Signature.App.Services
{
    public class DeviceService : IDeviceService
    {
        public bool IsWeb()
        {
            return false;
        }
    }
}
