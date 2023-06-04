using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Yet_on_track.View;
using Yet_on_track.ViewModel;

namespace Yet_on_track;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<CreateRecordView>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<CreateRecordViewModel>();

        return builder.Build();
    }
}
