using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.CustomControls
{
    public interface IDraw : IView
    {
        Color DrawColor { get; set; }
        void Clear();
        void Save();
    }
}
