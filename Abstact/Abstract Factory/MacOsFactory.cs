namespace Assigment2;

public class MacOsFactory : IGUIFactory
{
    public IButton CreateButton() => new MacOsButton();
    public ICheckbox CreateCheckbox() => new MacOsCheckbox();
    public IWindow CreateWindow() => new MacOsWindow();
}