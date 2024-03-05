using LemonUI.Menus;

namespace inxtrainer.features
{
    class NeverWanted : NativeCheckboxItem
    {
        public NeverWanted(string title, string description, WantedLevel wantedLevelItem) : base(title, description)
        {
            CheckboxChanged += (sender, e) =>
            {
                InxTrainer.NeverWanted = Checked;
                wantedLevelItem.Enabled = !Checked;
            };
        }
    }
}
