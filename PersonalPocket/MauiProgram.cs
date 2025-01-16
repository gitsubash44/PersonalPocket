﻿using Microsoft.Extensions.Logging;
using PersonalPocket.Components;

namespace PersonalPocket
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


#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Services.AddScoped<AppState>();
            builder.Logging.AddDebug();

#endif

            return builder.Build();
        }
    }
}
