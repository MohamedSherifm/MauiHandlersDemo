﻿using MauiHandlersDemo.CustomControls;
using MauiHandlersDemo.Handlers;
using MauiHandlersDemo.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiHandlersDemo
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Font-Awesome-Solid.otf", "FAS");
                })
                .ConfigureMauiHandlers(handlers =>
                {
                    handlers.AddHandler(typeof(IDraw), typeof(DrawViewHandler));
                    handlers.AddHandler(typeof(IMaterialEntry), typeof(MaterialEntryHandler));
                    handlers.AddHandler(typeof(ISwitchMaterial), typeof(SwitchMaterialHandler));
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();
            return builder.Build();
        }
    }
}
