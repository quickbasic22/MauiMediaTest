using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Media;
namespace MauiMediaTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        
	}

    private void BtnPlaySound_Clicked(object sender, EventArgs e)
    {
        MyMedia.Play();
    }

   
}

