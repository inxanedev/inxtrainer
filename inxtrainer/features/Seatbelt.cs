using GTA;
using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.features
{
    class Seatbelt: NativeCheckboxItem
    {
        public Seatbelt(string title, string description) : base(title, description)
        {
            if (Game.Player.Character.Exists())
            {
                Checked = !Game.Player.Character.CanFlyThroughWindscreen;
            }

            CheckboxChanged += (sender, e) =>
            {
                Game.Player.Character.CanFlyThroughWindscreen = !Checked;
                Game.Player.Character.CanBeKnockedOffBike = !Checked;
            };
        }
    }
}
