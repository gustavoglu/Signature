using ZXing.Net.Maui;

namespace Signature.App.Pages;

public partial class BarCodePage : ContentPage
{
    public event EventHandler<string?> BarCodeChanged;
    public BarCodePage()
    {
        InitializeComponent();
    }

    protected override void OnDisappearing()
    {
        BarCodeChanged?.Invoke(this, null);
    }

    protected async void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
        string barCode = e.Results.FirstOrDefault()?.Value;

        if (barCode is null) return;

        BarCodeChanged?.Invoke(this, barCode);

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            BarCodeChanged?.Invoke(this, null);
        }
        catch (Exception ex)
        {
            string msg = ex.Message;
        }
    }
}