using GTA;
using GTA.UI;
using GTA.Native;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using GTA.NaturalMotion;
using inxtrainer;
using LemonUI;
using LemonUI.Menus;
using inxtrainer.features;
using inxtrainer.submenus;

public class InxTrainer : Script
{

    public static bool NeverWanted = false;
    public static bool UnlimitedAbility = false;

    public ObjectPool Pool = new ObjectPool();
    public NativeMenu menu;
    
    public InxTrainer()
    {
        Tick += OnTick;
        KeyUp += OnKeyUp;

        WantedLevel wantedLevelItem = new WantedLevel("Wanted level", "Set your wanted level");

        menu = new NativeMenu("inxtrainer", "", "descritpion")
        {
            new Heal("Heal", "Heals the player"),
            new GiveAmmo("Give all ammo"),
            new God("God mode", "Invincibility"),
            new Repair("Repair car", "Repair current vehicle"),
            new VehicleGod("Vehicle God", "Make car invincible"),
            new RevealMap("Reveal Map", "Reveals the entire map"),
            new Seatbelt("Seatbelt", "Never fall out of your vehicle"),
            new UnlimitedAbility("Unlimited Ability", "Unlimited special ability"),
            wantedLevelItem,
            new NeverWanted("Never Wanted", "Always 0 wanted level", wantedLevelItem),
            new SpawnHellcat("Spawn Hellcat", "Spawns a hellcat")
        };

        menu.MaxItems = 15;

        NativeMenu teleportSubMenu = new Teleport("Teleport", "Teleport", "");
        Pool.Add(teleportSubMenu);
        menu.AddSubMenu(teleportSubMenu);

        NativeMenu moneySubMenu = new Money("Money", "Money", "");
        Pool.Add(moneySubMenu);
        menu.AddSubMenu(moneySubMenu);

        Pool.Add(menu);

    }

    private void OnTick(object sender, EventArgs e)
    {
        Pool.Process();

        if (NeverWanted && Game.Player.WantedLevel != 0)
        {
            Game.Player.WantedLevel = 0;
        }

        if (UnlimitedAbility)
        {
            Game.Player.RefillSpecialAbility();
        }
    }

    private void OnKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Oemcomma && !Pool.AreAnyVisible)
        {
            menu.Visible = true;
        }
    }
}