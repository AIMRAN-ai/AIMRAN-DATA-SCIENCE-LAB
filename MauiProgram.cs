using AimranDataScienceLab.Engine;
using Microsoft.Extensions.Logging;

namespace AIMRAN_Data_Science_Lab
{
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
                });

            builder.Services.AddMauiBlazorWebView();

            // ── Register the full AIMRAN Data Science Lab service stack ───
            // Engine, SQLite persistence, data cleaning, dataset versioning,
            // Azure cloud services, Python/Rust gateway, plugin manager.
            builder.Services.AddAimranDataScienceLab();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
