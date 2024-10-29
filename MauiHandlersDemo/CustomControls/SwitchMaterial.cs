using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.CustomControls
{
    public class SwitchMaterial : View, ISwitchMaterial
    {
        public static readonly BindableProperty IsOnProperty =
            BindableProperty.Create(
                nameof(IsOn),
                typeof(bool),
                typeof(SwitchMaterial),
                false);
        public bool IsOn
        {
            get => (bool)GetValue(IsOnProperty);
            set { SetValue(IsOnProperty, value); }
        }
        public Color TrackColor { get; }
        public Color ThumbColor { get; }
    }
}
