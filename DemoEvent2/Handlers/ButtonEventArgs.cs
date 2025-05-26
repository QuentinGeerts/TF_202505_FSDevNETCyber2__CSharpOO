using DemoEvent2.Enums;

namespace DemoEvent2.Handlers;

public class ButtonEventArgs : EventArgs
{
    public ButtonTypes ButtonType { get; set; }
    public string Message { get; set; }

    public ButtonEventArgs(ButtonTypes buttonType, string message)
    {
        ButtonType = buttonType;
        Message = message;
    }
}
