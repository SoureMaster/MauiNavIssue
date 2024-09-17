namespace MauiApp2.View;

public partial class PageFour : ContentPage
{
	public PageFour()
	{
		InitializeComponent();
	}

    protected override bool OnBackButtonPressed()
    {
        return base.OnBackButtonPressed();
    }

    private void btn2_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync(nameof(PageFive), true);
    }
}