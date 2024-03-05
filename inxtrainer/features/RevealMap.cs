using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.features
{
    class RevealMap : NativeCheckboxItem
    {
        public RevealMap(string title, string description) : base(title, description)
        {
            CheckboxChanged += (sender, e) =>
            {
                if (Checked)
                {
                    GTA.Native.Function.Call(GTA.Native.Hash.SET_MINIMAP_HIDE_FOW, 1);
                } else
                {
                    GTA.Native.Function.Call(GTA.Native.Hash.SET_MINIMAP_HIDE_FOW, 0);
                }
            };
        }
    }
}
