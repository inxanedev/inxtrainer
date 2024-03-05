using GTA;
using LemonUI.Menus;

namespace inxtrainer.features
{
    class God : NativeCheckboxItem
    {
        public God(string title, string description) : base(title, description)
        {
            if (Game.Player.Character.Exists())
            {
                Checked = Game.Player.Character.IsInvincible;
            }

            CheckboxChanged += (sender, e) =>
            {
                Game.Player.Character.IsInvincible = Checked;
            };
        }
    }
}
