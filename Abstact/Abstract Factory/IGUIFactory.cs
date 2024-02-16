namespace Assigment2;

public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
    IWindow CreateWindow();
}
