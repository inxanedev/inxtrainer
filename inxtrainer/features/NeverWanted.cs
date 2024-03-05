using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.features
{
    class NeverWanted : NativeCheckboxItem
    {
        public NeverWanted(string title, string description, WantedLevel wantedLevelItem) : base(title, description)
        {
            CheckboxChanged += (sender, e) =>
            {
                InxTrainer.NeverWanted = Checked;
                wantedLevelItem.Enabled = !Checked;
            };
        }
    }
}
