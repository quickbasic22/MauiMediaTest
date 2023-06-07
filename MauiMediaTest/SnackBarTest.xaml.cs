using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace MauiMediaTest;

public partial class SnackBarTest : ContentPage
{
    private PaintTheRainbowAnimation rainbowAnimation;
    public SnackBarTest()
    {
        InitializeComponent();
        rainbowAnimation = new PaintTheRainbowAnimation();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        var snackbarOptions = new SnackbarOptions
        {
            BackgroundColor = Colors.Red,
            TextColor = Colors.Green,
            ActionButtonTextColor = Colors.Yellow,
            CornerRadius = new CornerRadius(30),
            Font = Microsoft.Maui.Font.SystemFontOfSize(23),
            ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(23),
            CharacterSpacing = 0.5
        };
        string text = "This is a Snackbar";
        string actionButtonText = "Click Here to Dismiss";
        Action action = async () => await DisplayAlert("Snackbar ActionButton Tapped", "The user has tapped the Snackbar ActionButton", "OK");
        TimeSpan duration = TimeSpan.FromSeconds(3);
        var snackbar = Snackbar.Make(text, action, actionButtonText, duration, snackbarOptions);
        snackbar.Show(cancellationTokenSource.Token).Wait();

        CommunityToolkit.Maui.Views.MediaElement mediaElement = new CommunityToolkit.Maui.Views.MediaElement();
        mediaElement.Source = MediaSource.FromResource("MauiMediaTest.Resources.Raw.song.mp3");
        mediaElement.Play();
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Task.WhenAll(FirstAnimation(), SecondAnimation());
        await Task.Yield();


        var controls = new List<VisualElement> { MyPath, Label1, MyVertical, SnackBarBtn, AnimateBtn };

        foreach (var control in controls)
        {
            await rainbowAnimation.Animate(control);
        }

    }

    private async Task FirstAnimation()
    {
        var controls = new List<VisualElement> { MyPath, Label1, MyVertical, SnackBarBtn, AnimateBtn };

        foreach (var control in controls)
        {
            await rainbowAnimation.Animate(control);
        }
       
    }
    private async Task SecondAnimation()
    {
        var controls = new List<VisualElement> { MyPath, Label1, MyVertical, SnackBarBtn, AnimateBtn };

        foreach (var control in controls)
        {
            await rainbowAnimation.Animate(control);
        }
    }

}