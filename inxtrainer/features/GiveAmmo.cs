using GTA;
using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.features
{
    class GiveAmmo : NativeItem
    {
        public GiveAmmo(string title) : base(title)
        {
            Activated += (sender, e) =>
            {
                foreach (WeaponHash hash in Enum.GetValues(typeof(WeaponHash)))
                {
                    if (Game.Player.Character.Weapons.HasWeapon(hash))
                    {
                        Weapon weapon = Game.Player.Character.Weapons[hash];
                        weapon.Ammo = weapon.MaxAmmo;
                        weapon.AmmoInClip = weapon.MaxAmmoInClip;
                    }
                }
            };
        }
    }
}
