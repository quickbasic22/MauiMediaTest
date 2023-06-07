using CommunityToolkit.Maui.Extensions;

namespace MauiMediaTest;

public partial class MyDrawable : ContentPage
{
    public Drawable Drawable { get; set; }
	public MyDrawable()
	{
		InitializeComponent();
        Drawable = new Drawable();
        Drawable.graphicsView = GraphicsView1;
        BindingContext = this;
	}

    private void AnimateBtn_Clicked(object sender, EventArgs e)
    {
        Drawable.AnimateFillColor(Colors.Bisque);
        Drawable.AnimateFillColor(Colors.Orange);
        Drawable.AnimateFillColor(Colors.DarkBlue);
        Drawable.AnimateFillColor(Colors.Plum);
    }
}