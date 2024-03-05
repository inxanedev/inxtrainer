using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.features
{
    class UnlimitedAbility : NativeCheckboxItem
    {
        public UnlimitedAbility(string title, string description) : base(title, description)
        {
            CheckboxChanged += (sender, e) =>
            {
                InxTrainer.UnlimitedAbility = Checked;
            };
        }
    }
}
