using GTA;
using LemonUI.Menus;

namespace inxtrainer.features
{
    class VehicleGod : NativeItem
    {
        public VehicleGod(string title, string description) : base(title, description)
        {
            Activated += (sender, e) =>
            {
                if (Game.Player.Character.IsInVehicle())
                {
                    Game.Player.Character.CurrentVehicle.IsInvincible = true;
                }
            };
        }
    }
}
