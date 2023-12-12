using Android;
using Android.Content;
using Android.Util;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using Google.Android.Material.TextField;
using Microsoft.Maui.Platform;
using Org.W3c.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo
{
    public class MaterialEntryAndroid : TextInputLayout
    {
        TextInputEditText textInputEditText;
        LayoutParams textInputLayoutLayoutParams;
        public MaterialEntryAndroid(Context context) : base(context)
        {
            BoxBackgroundMode = TextInputLayout.BoxBackgroundOutline;
            SetBoxCornerRadii(5, 5, 5, 5);
            BoxStrokeColor = Colors.Red.ToPlatform();
            textInputEditText = new(Context, null, Resource.Style.Widget_Material3_TextInputEditText_OutlinedBox);
            AddView(textInputEditText);
        }

        public MaterialEntryAndroid(Context context, IAttributeSet? attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            textInputLayoutLayoutParams = new(LayoutParams.MatchParent, LayoutParams.WrapContent);
            this.LayoutParameters = textInputLayoutLayoutParams;
            BoxBackgroundMode = TextInputLayout.BoxBackgroundOutline;
            SetBoxCornerRadii(12, 12, 12, 12);      
            //CounterMaxLength = 10;
            //CounterEnabled = true;
            //HelperText = "Nice";
            textInputEditText = new(Context,null, Resource.Style.Widget_AppCompat_EditText);
            textInputEditText.Gravity = Android.Views.GravityFlags.CenterVertical;
            textInputEditText.SetPadding(40,40,40,40);
            textInputEditText.SetMinHeight(130);
            textInputEditText.FocusableInTouchMode = true;
            this.AddView(textInputEditText, LayoutParams.MatchParent, LayoutParams.WrapContent);

            //this.StartIconVisible = true;
            //SetStartIconDrawable(Resource.Drawable.avd_show_password);

            //Toast.MakeText(context, textInputEditText.Width.ToString(), ToastLength.Long).Show();
            //this.EndIconVisible = true;
            //SetEndIconDrawable(Resource.Drawable.material_ic_clear_black_24dp);
            //SetEndIconActivated(true);

        }



        public void ApplyTextColor(Color color)
        {
            if (color != null) 
            {
                textInputEditText.SetTextColor(color.ToPlatform());
            }
        }

        public void UpdatePlaceHolder(string placeHolder)
        {
            Hint = placeHolder;
        }
    }
}
