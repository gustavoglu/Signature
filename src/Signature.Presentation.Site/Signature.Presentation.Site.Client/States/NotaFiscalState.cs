namespace Signature.Presentation.Site.Client.States
{
    public class NotaFiscalState
    {

        public event Action OnChange;
        public string? ChaveAcesso { get; private set; }
        public string? ComprovanteBase64 { get; private set; }
        public string? ComprovanteBase64Src { get; private set; }

        public void Clear()
        {
            ChaveAcesso = null;
            ComprovanteBase64 = null;
            ComprovanteBase64Src = null;

            OnChange?.Invoke();
        }
        public void SetChaveAcesso(string? chaveAcesso) { ChaveAcesso = chaveAcesso; OnChange?.Invoke(); }
        public void SetComprovanteBase64(string? comprovanteBase64) { ComprovanteBase64 = comprovanteBase64; OnChange?.Invoke(); }
        public void SetComprovanteBase64Src(string? comprovanteBase64Src) { ComprovanteBase64Src = comprovanteBase64Src; OnChange?.Invoke(); }
    }
}
