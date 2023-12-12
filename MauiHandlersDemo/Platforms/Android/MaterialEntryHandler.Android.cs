using MauiHandlersDemo.CustomControls;
using Microsoft.Maui.Handlers;

namespace MauiHandlersDemo.Handlers
{
    public partial class MaterialEntryHandler : ViewHandler<IMaterialEntry, MaterialEntryAndroid>
    {
        MaterialEntryAndroid m_materialEntry;

        protected override MaterialEntryAndroid CreatePlatformView()
        {
            if (m_materialEntry == null) 
            {
                m_materialEntry = new MaterialEntryAndroid(Context, null, Resource.Style.Widget_Material3_TextInputLayout_FilledBox_Dense);
                //m_materialEntry = new MaterialEntryAndroid(Context);
            }

            return m_materialEntry;
        }
    }
}
