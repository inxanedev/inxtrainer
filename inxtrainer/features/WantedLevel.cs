﻿using GTA;
using LemonUI.Menus;

namespace inxtrainer.features
{
    class WantedLevel : NativeListItem<int>
    {
        public WantedLevel(string title, string description) : base(title, description, new int[] { 0, 1, 2, 3, 4, 5 })
        {
            Activated += (sender, e) =>
            {
                Game.Player.WantedLevel = SelectedItem;
            };
        }
    }
}
