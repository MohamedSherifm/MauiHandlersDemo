using Android.Content;
using Android.Util;
using Android.Widget;
using Google.Android.Material.TextField;
using Microsoft.Maui.Platform;
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
        public MaterialEntryAndroid(Context context) : base(context)
        {
            textInputEditText = new(context);
            BoxBackgroundMode = BoxBackgroundOutline;
            AddView(textInputEditText);
            
            
            
        }

        public MaterialEntryAndroid(Context context, IAttributeSet? attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            textInputEditText = new(context);
            BoxBackgroundMode = BoxBackgroundOutline;
            AddView(textInputEditText);
            CounterMaxLength = 10;
            CounterEnabled = true;
            
            
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
