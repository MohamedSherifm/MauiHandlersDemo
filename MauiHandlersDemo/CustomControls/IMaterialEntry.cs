using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.CustomControls
{
    public interface IMaterialEntry : IView
    {
        string PlaceHolder { get; set; }
        Color TextColor { get; set; }
        void Clear();
    }
}
