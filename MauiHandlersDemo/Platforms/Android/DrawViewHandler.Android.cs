using Android.Content;
using MauiHandlersDemo.CustomControls;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.Handlers
{
    public partial class DrawViewHandler : ViewHandler<IDraw, DrawViewAndroid>
    {
        DrawViewAndroid _drawView;

        protected override DrawViewAndroid CreatePlatformView()
        {
            if( _drawView == null)
            {
                _drawView = new DrawViewAndroid(Context);
            }

            return _drawView;
        }

        public static void TextColor(IMaterialEntryHandler handler, IMaterialEntry entry)
        {
            handler.PlatformView.ApplyTextColor(entry.TextColor);
        }
    }
}
