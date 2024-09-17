using MauiApp2.View;

namespace MauiApp2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(PageOne), typeof(PageOne));
            Routing.RegisterRoute(nameof(PageTwo), typeof(PageTwo));
            Routing.RegisterRoute(nameof(PageThree), typeof(PageThree));
            Routing.RegisterRoute(nameof(PageFour), typeof(PageFour));
            Routing.RegisterRoute(nameof(PageFive), typeof(PageFive));

        }
    }
}
