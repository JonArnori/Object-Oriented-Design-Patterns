namespace Assigment2;

public class LinuxFactory : IGUIFactory
{
    public IButton CreateButton() => new LinuxButton();
    public ICheckbox CreateCheckbox() => new LinuxCheckbox();
    public IWindow CreateWindow() => new LinuxWindow();
}