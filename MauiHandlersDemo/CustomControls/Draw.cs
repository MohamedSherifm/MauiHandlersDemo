using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.CustomControls
{
    public partial class Draw : View, IDraw
    {
        public static readonly BindableProperty DrawColorPropert =
            BindableProperty.Create(
                nameof(DrawColor),
                typeof(Color),
                typeof(Draw),
                Colors.Red);
        public Color DrawColor 
        { 
            get=>(Color)GetValue(DrawColorPropert);
            set {  SetValue(DrawColorPropert, value); }
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
