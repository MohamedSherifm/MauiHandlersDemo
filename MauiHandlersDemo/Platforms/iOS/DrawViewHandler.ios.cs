using MauiHandlersDemo.CustomControls;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.Handlers
{
    public partial class DrawViewHandler : ViewHandler<IDraw, DrawViewIOS>
    {
        DrawViewIOS _drawView;

        protected override DrawViewIOS CreatePlatformView()
        {
            if (_drawView == null)
            {
                _drawView = new DrawViewIOS();
            }

            return _drawView;
        }
    }
}
