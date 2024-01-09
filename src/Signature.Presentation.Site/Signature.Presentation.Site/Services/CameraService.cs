using Signature.Shared.Interfaces;

namespace Signature.Presentation.Site.Services
{
    public class CameraService : ICameraService
    {
        public async Task<string?> TakePhotoAndGenerateBase64()
        {
            return "teste";
        }
    }
}
