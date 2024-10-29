using MauiHandlersDemo.CustomControls;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.Handlers
{
    public partial class SwitchMaterialHandler : ViewHandler<ISwitchMaterial, SwitchMaterialAndroid>
    {
        SwitchMaterialAndroid _switchMaterialAndroid;
        protected override SwitchMaterialAndroid CreatePlatformView()
        {
            if( _switchMaterialAndroid == null ) 
            {
                //_switchMaterialAndroid = new SwitchMaterialAndroid(Context);
                _switchMaterialAndroid = new SwitchMaterialAndroid(Context, null, Resource.Attribute.materialSwitchStyle);
                //_switchMaterialAndroid = new SwitchMaterialAndroid(Context, null, Resource.Style.Widget_Material3_CompoundButton_Switch);

            }
            return _switchMaterialAndroid;
        }
    }
}
