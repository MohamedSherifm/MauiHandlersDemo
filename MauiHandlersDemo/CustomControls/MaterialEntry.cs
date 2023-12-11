using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.CustomControls
{
    public partial class MaterialEntry : View, IMaterialEntry
    {
        public static readonly BindableProperty PlaceHolderProperty =
           BindableProperty.Create(
               nameof(PlaceHolder),
               typeof(string),
               typeof(MaterialEntry),
               string.Empty);
        public string PlaceHolder
        {
            get => (string)GetValue(PlaceHolderProperty);
            set { SetValue(PlaceHolderProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(
                nameof(TextColor),
                typeof(Color),
                typeof(MaterialEntry),
                Colors.Red);
        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set { SetValue(TextColorProperty, value); }
        }


        public event EventHandler ClearRequested;
        public event EventHandler SaveRequested;

        public void Clear()
        {
            ClearRequested?.Invoke(this, EventArgs.Empty);
            Handler?.Invoke(nameof(IDraw.Clear));
        }

        public void Save()
        {
            SaveRequested?.Invoke(this, EventArgs.Empty);
            Handler?.Invoke(nameof(IDraw.Save));
        }
    }
}
