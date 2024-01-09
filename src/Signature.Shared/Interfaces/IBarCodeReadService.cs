namespace Signature.Shared.Interfaces
{
    public interface IBarCodeReadService
    {
        Task<string> ReadBarCode();
        Task StopRead();
    }
}
