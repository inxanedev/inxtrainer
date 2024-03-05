using GTA;
using GTA.Math;
using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.submenus
{
    class Teleport : NativeMenu
    {
        public Teleport(string bqnnerText, string name, string description) : base(bqnnerText, name, description)
        {
            NativeItem waypoint = new NativeItem("Waypoint");
            waypoint.Activated += (sender, e) =>
            {
                if (World.WaypointBlip != null)
                {
                    Vector3 pos = new GTA.Math.Vector3(
                        World.WaypointPosition.X,
                        World.WaypointPosition.Y,
                        World.GetGroundHeight(World.WaypointPosition)
                    );

                    Utils.TeleportPlayerOrVehicle(pos);
                }
            };
            Add(waypoint);

            NativeItem objective = new NativeItem("Objective");
            objective.Activated += (sender, e) =>
            {
                foreach (Blip blip in World.GetAllBlips())
                {
                    BlipColor c = blip.Color;
                    BlipSprite s = blip.Sprite;

                    if (
                        (s == BlipSprite.CrateDrop) ||
                        (c == BlipColor.Yellow && s == BlipSprite.Standard) ||
                        (c == BlipColor.Yellow3 && s == BlipSprite.Standard) ||
                        (c == BlipColor.Yellow2 && s == BlipSprite.Standard) ||
                        (c == BlipColor.White && s == BlipSprite.RaceFinish) ||
                        (c == BlipColor.Green && s == BlipSprite.Standard) ||
                        (c == BlipColor.Blue && s == BlipSprite.Standard)
                    )
                    {
                        Utils.TeleportPlayerOrVehicle(blip.Position);
                        break;
                    }
                }
            };
            Add(objective);
        }
    }
}
