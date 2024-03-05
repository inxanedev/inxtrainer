using GTA;
using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.features
{
    class God : NativeCheckboxItem
    {
        public God(string title, string description) : base(title, description)
        {
            if (Game.Player.Character.Exists())
            {
                Checked = Game.Player.Character.IsInvincible;
            }

            CheckboxChanged += (sender, e) =>
            {
                Game.Player.Character.IsInvincible = Checked;
            };
        }
    }
}
