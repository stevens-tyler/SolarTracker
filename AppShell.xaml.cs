using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using SolarTracker.View;

namespace SolarTracker;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        LiveCharts.Configure(config =>
        config
            // registers SkiaSharp as the library backend
            // REQUIRED unless you build your own
            .AddSkiaSharp()

            // adds the default supported types
            // OPTIONAL but highly recommend
            .AddDefaultMappers()

            // select a theme, default is Light
            // OPTIONAL
            //.AddDarkTheme()
            .AddLightTheme()

            // finally register your own mappers
            // you can learn more about mappers at:
            // ToDo add website link...
            //.HasMap<City>((city, point) =>
            //{
            //    point.PrimaryValue = city.Population;
            //    point.SecondaryValue = point.Context.Index;
            //})
        // .HasMap<Foo>( .... )
        // .HasMap<Bar>( .... )
        );
    }
}
