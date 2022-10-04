using SolarTracker.Services;
using SolarTracker.View;
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

		// Services
		builder.Services.AddSingleton<UserService>();

		// View Models
		builder.Services.AddSingleton<UserViewModel>();
		builder.Services.AddTransient<LoginPageViewModel>();


		// Pages
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<LoginPage>();

        return builder.Build();
	}
}
