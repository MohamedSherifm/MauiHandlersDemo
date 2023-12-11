using MauiHandlersDemo.CustomControls;
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHandlersDemo.Handlers
{
    public partial class MaterialEntryHandler : ViewHandler<IMaterialEntry, MaterialEntryAndroid>
    {
        MaterialEntryAndroid m_materialEntry;

        protected override MaterialEntryAndroid CreatePlatformView()
        {
            if (m_materialEntry == null) 
            {
                m_materialEntry = new MaterialEntryAndroid(Context, null, 2000660);
            }

            return m_materialEntry;
        }
    }
}
