using GTA;
using GTA.Math;
using GTA.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
