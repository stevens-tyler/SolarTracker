using SolarTracker.Services;
using SolarTracker.View;
using SolarTracker.ViewModel;
using SkiaSharp.Views.Maui.Controls.Hosting;
namespace SolarTracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseSkiaSharp(true)
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

        return builder.Build();


	}
}
