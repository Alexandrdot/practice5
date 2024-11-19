using Microsoft.Extensions.Logging;

namespace Practice5MauiApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        //List<TransportManager> transports = new List<TransportManager>(); //список обьектов (т/с)
        var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

