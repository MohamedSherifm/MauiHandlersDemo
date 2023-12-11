using MauiHandlersDemo.CustomControls;
using MauiHandlersDemo.Handlers;
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
                })
                .ConfigureMauiHandlers(handlers =>
                {
                    handlers.AddHandler(typeof(IDraw), typeof(DrawViewHandler));
                    handlers.AddHandler(typeof(IMaterialEntry), typeof(MaterialEntryHandler));
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
