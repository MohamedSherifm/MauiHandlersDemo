#if IOS || MACCATALYST
using PlatformView = MauiHandlersDemo.DrawViewIOS;
#elif ANDROID
using PlatformView = MauiHandlersDemo.MaterialEntryAndroid;
#elif WINDOWS
using PlatformView = MauiHandlersDemo.DrawViewWindows;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif
using MauiHandlersDemo.CustomControls;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace MauiHandlersDemo.Handlers
{
    public partial class MaterialEntryHandler : IMaterialEntryHandler
    {
        public static IPropertyMapper<IMaterialEntry, IMaterialEntryHandler> Mapper =
            new PropertyMapper<IMaterialEntry, IMaterialEntryHandler>(ViewHandler.ViewMapper)
            {
                [nameof(IMaterialEntry.TextColor)] = TextColor,
                [nameof(IMaterialEntry.PlaceHolder)] = PlaceHolderChanged,
            };

        

        public static CommandMapper<IMaterialEntry, IMaterialEntryHandler> CommandMapper =
            new(ViewHandler.ViewCommandMapper)
            {
                [nameof(IMaterialEntry.Clear)] = Completed,
                
            };

        private static void Completed(IMaterialEntryHandler handler, IMaterialEntry entry, object? args)
        {
            throw new NotImplementedException();
        }

        private static void TextColor(IMaterialEntryHandler handler, IMaterialEntry entry)
        {
            handler.PlatformView.ApplyTextColor(entry.TextColor);
        }

        private static void PlaceHolderChanged(IMaterialEntryHandler handler, IMaterialEntry entry)
        {
            handler.PlatformView.UpdatePlaceHolder(entry.PlaceHolder);
        }

        protected override void ConnectHandler(PlatformView platformView)
        {
            base.ConnectHandler(platformView);
        }

        protected override void DisconnectHandler(PlatformView platformView)
        {
            PlatformView.Dispose();
            base.DisconnectHandler(platformView);
        }

        public MaterialEntryHandler() : base(Mapper, CommandMapper)
        {

        }

        IMaterialEntry IMaterialEntryHandler.VirtualView => VirtualView;
        PlatformView IMaterialEntryHandler.PlatformView => PlatformView;
    }
}
