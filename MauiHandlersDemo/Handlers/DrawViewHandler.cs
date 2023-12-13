#if IOS || MACCATALYST
using PlatformView = MauiHandlersDemo.DrawViewIOS;
#elif ANDROID
using PlatformView = MauiHandlersDemo.DrawViewAndroid;
#elif WINDOWS
//using PlatformView = MauiHandlersDemo.DrawViewWindows;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif
using MauiHandlersDemo.CustomControls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;


namespace MauiHandlersDemo.Handlers
{
    public partial class DrawViewHandler : IDrawHandler
    {
        public static IPropertyMapper<IDraw, IDrawHandler> Mapper =
            new PropertyMapper<IDraw, IDrawHandler>(ViewHandler.ViewMapper)
            {
                [nameof(IDraw.DrawColor)] = DrawColor,
            };

        

        public static CommandMapper<IDraw, IDrawHandler> CommandMapper =
            new(ViewHandler.ViewCommandMapper)
            {
                [nameof(IDraw.Clear)] = OnClear,
                [nameof(IDraw.Save)] = OnSave,
            };

        public DrawViewHandler() : base(Mapper, CommandMapper)
        {
            
        }

        IDraw IDrawHandler.VirtualView => VirtualView;
        PlatformView IDrawHandler.PlatformView => PlatformView;

        private static void OnSave(IDrawHandler handler, IDraw draw, object? args)
        {
            handler.PlatformView.Save();
        }

        private static void OnClear(IDrawHandler handler, IDraw draw, object? args)
        {
            handler.PlatformView.Clear();
        }

        private static void DrawColor(IDrawHandler handler, IDraw draw)
        {
            handler.PlatformView.PaintColor = draw.DrawColor.ToPlatform();
        }

        protected override void ConnectHandler(PlatformView platformView)
        {
            base.ConnectHandler(platformView);
        }

        protected override void DisconnectHandler(PlatformView platformView)
        {
            //PlatformView.Dispose();
            base.DisconnectHandler(platformView);
        }

    }
}
