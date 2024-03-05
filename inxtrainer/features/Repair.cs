using GTA;
using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.features
{
    class Repair : NativeItem
    {
        public Repair(string title, string description) : base(title, description)
        {
            Activated += (sender, e) =>
            {
                if (Game.Player.Character.IsInVehicle())
                {
                    Game.Player.Character.CurrentVehicle.Repair();
                }
            };
        }
    }
}
