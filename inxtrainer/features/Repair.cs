using GTA;
using LemonUI.Menus;

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
