namespace Signature.Shared.Components.States
{
    public class MainState
    {
        public event Action OnChange;
        public bool IsWeb { get; private set; }
        public void SetIsWeb(bool isWeb) {  IsWeb = isWeb; OnChange?.Invoke(); }
    
    }
}
