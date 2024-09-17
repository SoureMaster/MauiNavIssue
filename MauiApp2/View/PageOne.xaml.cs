namespace MauiApp2.View;

public partial class PageOne : ContentPage
{
	public PageOne()
	{
		InitializeComponent();
	}

    private void btn2_Clicked(object sender, EventArgs e)
    {
		AppShell.Current.GoToAsync(nameof(PageTwo), true);
    }
}