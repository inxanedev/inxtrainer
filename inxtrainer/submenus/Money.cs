using GTA;
using LemonUI.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inxtrainer.submenus
{
    class Money : NativeMenu
    {
        public Money(string bqnnerText, string name, string description) : base(bqnnerText, name, description)
        {
            NativeListItem<int> list = new NativeListItem<int>("Money amount", new int[]
            {
                100, 1000, 10000, 100000, 1000000
            });

            Add(list);

            NativeItem give = new NativeItem("Give", "Gives the money directly");
            NativeItem subtract = new NativeItem("Subtract", "Takes away the money");
            Add(give);
            Add(subtract);

            give.Activated += (sender, e) =>
            {
                Game.Player.Money += list.SelectedItem;
            };

            subtract.Activated += (sender, e) =>
            {
                Game.Player.Money -= list.SelectedItem;
            };
        }
    }
}
