using Microsoft.Extensions.Logging;

namespace QuoteGenerator;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				//fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				//fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("ComicRelief-Regular.ttf", "ComicRelief-Regular");
				fonts.AddFont("ComicRelief-Bold.ttf", "ComicRelief-Bold");

			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
