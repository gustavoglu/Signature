using Signature.Shared.Interfaces;

namespace Signature.App.Services
{
    public class CameraService : ICameraService
    {

        public async Task<string?> TakePhotoAndGenerateBase64()
        {
            var result = await MediaPicker.CapturePhotoAsync();
            if (result is null) return null;

            var streamRead = await result.OpenReadAsync();

            byte[]? bytes = null;

            using (var memoryStream = new MemoryStream())
            {
                streamRead.CopyTo(memoryStream);
                bytes = memoryStream.ToArray();
            }

            return Convert.ToBase64String(bytes);
        }
    }
}
