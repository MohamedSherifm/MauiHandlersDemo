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
    public partial class SwitchMaterialHandler : ISwitchMaterialHandler
    {
        public static IPropertyMapper<ISwitchMaterial, ISwitchMaterialHandler> PropertyMapper = 
            new PropertyMapper<ISwitchMaterial, ISwitchMaterialHandler>(ViewMapper)
            {
                [nameof(ISwitchMaterial.IsOn)] = IsOn,
                [nameof(ISwitchMaterial.IsEnabled)] = IsEnabled
            };

        public SwitchMaterialHandler() : base(PropertyMapper)
        {
            
        }

        private static void IsEnabled(ISwitchMaterialHandler handler, ISwitchMaterial materialSwitch)
        {
            handler.PlatformView.SwitchEnabled(materialSwitch.IsEnabled);
        }

        private static void IsOn(ISwitchMaterialHandler handler, ISwitchMaterial materialSwitch)
        {
            handler.PlatformView.IsSwitchOn(materialSwitch.IsOn);
        }

        ISwitchMaterial ISwitchMaterialHandler.VirtualView => VirtualView;
        PlatformView ISwitchMaterialHandler.PlatformView => PlatformView;
    }
}
