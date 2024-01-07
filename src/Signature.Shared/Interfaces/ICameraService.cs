namespace Signature.Shared.Interfaces
{
    public interface ICameraService
    {
        Task<string?> TakePhotoAndGenerateBase64();
    }
}
