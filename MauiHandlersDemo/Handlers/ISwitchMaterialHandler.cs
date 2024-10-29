#if IOS || MACCATALYST
using PlatformView = MauiHandlersDemo.DrawViewIOS;
#elif ANDROID
using PlatformView = MauiHandlersDemo.SwitchMaterialAndroid;
#elif WINDOWS
using PlatformView = MauiHandlersDemo.DrawViewWindows;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif
using MauiHandlersDemo.CustomControls;
namespace MauiHandlersDemo.Handlers
{
    public interface ISwitchMaterialHandler : IViewHandler
    {
        new ISwitchMaterial VirtualView { get; }
        new PlatformView PlatformView { get; }
    }
}
