using DemoEvent2.Enums;

namespace DemoEvent2.Models;

public class RightButton : Button
{
    public override void Click()
    {
        OnButtonClicked(ButtonTypes.Right, "Tu as cliqué sur le bouton Droit.");
    }
}
