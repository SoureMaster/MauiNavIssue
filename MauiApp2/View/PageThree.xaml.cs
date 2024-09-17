namespace MauiApp2.View;

public partial class PageThree : ContentPage
{
	public PageThree()
	{
		InitializeComponent();
	}

    protected override bool OnBackButtonPressed()
    {
        return base.OnBackButtonPressed();
    }


    private void btn2_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync(nameof(PageFour), true);
    }
}