#if IOS || MACCATALYST
using PlatformView = MauiHandlersDemo.DrawViewIOS;
#elif ANDROID
using PlatformView = MauiHandlersDemo.DrawViewAndroid;
#elif WINDOWS
using PlatformView = MauiHandlersDemo.DrawViewWindows;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif
using MauiHandlersDemo.CustomControls;

namespace MauiHandlersDemo.Handlers
{
    public interface IDrawHandler : IViewHandler
    {
        new IDraw VirtualView { get; }
        new PlatformView PlatformView { get; }
    }
}
