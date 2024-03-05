using LemonUI.Menus;

namespace inxtrainer.features
{
    class UnlimitedAbility : NativeCheckboxItem
    {
        public UnlimitedAbility(string title, string description) : base(title, description)
        {
            CheckboxChanged += (sender, e) =>
            {
                InxTrainer.UnlimitedAbility = Checked;
            };
        }
    }
}
