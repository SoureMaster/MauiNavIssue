namespace MauiApp2.View;

public partial class PageTwo : ContentPage
{
	public PageTwo()
	{
		InitializeComponent();
	}

    private void btn2_Clicked(object sender, EventArgs e)
    {
        AppShell.Current.GoToAsync(nameof(PageThree), true);
    }

    protected override bool OnBackButtonPressed()
    {
        return base.OnBackButtonPressed();
    }
}