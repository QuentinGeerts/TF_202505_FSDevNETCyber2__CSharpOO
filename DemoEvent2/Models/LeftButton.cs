using DemoEvent2.Enums;

namespace DemoEvent2.Models;

internal class LeftButton : Button
{
    public override void Click()
    {
        OnButtonClicked(ButtonTypes.Left, "Tu as cliqué sur le bouton Gauche.");
    }
}
