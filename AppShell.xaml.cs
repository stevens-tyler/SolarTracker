using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using SolarTracker.View;

namespace SolarTracker;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
    }
}
