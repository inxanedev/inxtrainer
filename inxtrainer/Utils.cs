using GTA;
using GTA.Math;

namespace inxtrainer
{
    public class Utils
    {
        public static void TeleportPlayerOrVehicle(Vector3 pos)
        {
            if (Game.Player.Character.IsInVehicle())
            {
                Game.Player.Character.CurrentVehicle.Position = pos;
            }
            else
            {
                Game.Player.Character.Position = pos;
            }
        }
    }
}
