using GTA;
using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.features
{
    class Heal : NativeItem
    {
        public Heal(string title, string description) : base(title, description)
        {
            Activated += (sender, e) =>
            {
                Game.Player.Character.Health = Game.Player.Character.MaxHealth;
                Game.Player.Character.Armor = Game.Player.MaxArmor;
            };
        }

    }
}
