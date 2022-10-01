using SolarTracker.ViewModel;
namespace SolarTracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Views
		//builder.Services.AddSingleton<LoginPage>();

        // View Models
        //builder.Services.AddSingleton<LoginPageViewModel>();
        return builder.Build();
	}
}
