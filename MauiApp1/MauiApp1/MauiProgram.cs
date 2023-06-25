using Microsoft.Extensions.Logging;
//using Microsoft.Maui.Essentials;
using Microsoft.Maui.Controls.Compatibility.Hosting;
namespace MauiApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCompatibility()
                    .ConfigureMauiHandlers((handlers) =>
                    {
#if ANDROID
                        handlers.AddHandler(typeof(MauiApp1.Controls.BorderedEntry), typeof(MauiApp1.Platforms.Android.Renderers.BorderedEntryRenderer));
#endif
                    });

        return builder.Build();

    }
}
//using Microsoft.Extensions.Logging;

//namespace MauiApp1;

//public static class MauiProgram
//{
//	public static MauiApp CreateMauiApp()
//	{
//		var builder = MauiApp.CreateBuilder();
//		builder
//			.UseMauiApp<App>()
//			.ConfigureFonts(fonts =>
//			{
//				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
//				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
//			});

//#if DEBUG
//		builder.Logging.AddDebug();
//#endif

//		return builder.Build();
//	}
//}
