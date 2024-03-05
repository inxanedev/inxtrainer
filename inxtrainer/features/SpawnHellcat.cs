using GTA;
using LemonUI.Menus;
using System.Drawing;

namespace inxtrainer.features
{
    class SpawnHellcat : NativeItem
    {
        public SpawnHellcat(string title, string description) : base(title, description)
        {
            Activated += (sender, e) =>
            {
                Vehicle vehicle = World.CreateVehicle(VehicleHash.Buffalo4, Game.Player.Character.Position + Game.Player.Character.ForwardVector * 3.0f, Game.Player.Character.Heading);

                vehicle.CanTiresBurst = false;
                vehicle.Mods.InstallModKit();
                vehicle.Mods[VehicleModType.Armor].Index = 5;
                vehicle.Mods[VehicleModType.Brakes].Index = 3;
                vehicle.Mods[VehicleModType.Engine].Index = 3;
                vehicle.Mods[VehicleModType.Exhaust].Index = 6;
                vehicle.Mods[VehicleModType.Hood].Index = 4;
                vehicle.Mods.CustomPrimaryColor = Color.Black;
                vehicle.Mods.CustomSecondaryColor = Color.Black;
                vehicle.Mods.TrimColor = VehicleColor.MetallicBlack;
                vehicle.Mods[VehicleModType.SideSkirt].Index = 1;
                vehicle.Mods[VehicleModType.Spoilers].Index = 1;
                vehicle.Mods[VehicleModType.Suspension].Index = 4;
                vehicle.Mods[VehicleModType.Transmission].Index = 3;
                vehicle.Mods[VehicleToggleModType.Turbo].IsInstalled = true;
                vehicle.Mods.WheelType = VehicleWheelType.HighEnd;
                vehicle.Mods[VehicleModType.FrontWheel].Index = 18;
                vehicle.Mods.RimColor = VehicleColor.MetallicBlack;
                vehicle.Mods.TireSmokeColor = Color.Black;
                vehicle.Mods.WindowTint = VehicleWindowTint.PureBlack;
                vehicle.Mods.PearlescentColor = VehicleColor.PureWhite;
                vehicle.Mods.LicensePlateStyle = LicensePlateStyle.NorthYankton;
                vehicle.Mods[VehicleToggleModType.XenonHeadlights].IsInstalled = true;

                vehicle.PlaceOnGround();
                vehicle.Mods.LicensePlate = "HELLCAT";
                vehicle.IsEngineRunning = true;
                vehicle.IsRadioEnabled = false;
                vehicle.AreLightsOn = false;
                vehicle.DirtLevel = 0.0f;
                Game.Player.Character.SetIntoVehicle(vehicle, VehicleSeat.Driver);
            };
        }
    }
}
