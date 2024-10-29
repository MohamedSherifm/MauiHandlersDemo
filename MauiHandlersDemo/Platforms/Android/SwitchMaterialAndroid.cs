using Android.Content;
using Android.Util;
using Google.Android.Material.MaterialSwitch;
using Google.Android.Material.SwitchMaterial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo
{
    public class SwitchMaterialAndroid : MaterialSwitch
    {
        public SwitchMaterialAndroid(Context context) : base(context)
        {
            Text = "Material Switch";
        }

        public SwitchMaterialAndroid(Context context, IAttributeSet? attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            //Text = "Material Switch";
            TextOn = "On";
            TextOff = "Off";
           

            TrackDrawable = Context.GetDrawable(Resource.Drawable.mtrl_switch_track);
            TrackDecorationDrawable = Context.GetDrawable(Resource.Drawable.mtrl_switch_track_decoration);
            TrackDecorationTintList = Context.GetColorStateList(Resource.Color.mtrl_switch_track_decoration_tint);
            ThumbDrawable = Context.GetDrawable(Resource.Drawable.mtrl_switch_thumb);
            ThumbTintList = Context.GetColorStateList(Resource.Color.mtrl_switch_thumb_tint);
            ThumbIconTintList = Context.GetColorStateList(Resource.Color.mtrl_switch_thumb_icon_tint);
            TrackTintList = Context.GetColorStateList(Resource.Color.mtrl_switch_track_tint);
        }

        public void SwitchEnabled(bool enabled) 
        {
            Enabled = enabled;
        }

        public void IsSwitchOn(bool isSwitchOn) 
        {
            this.Checked = isSwitchOn;
        }
    }
}
