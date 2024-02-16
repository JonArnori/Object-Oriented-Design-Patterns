using Assigment2;

class Application
{
    private readonly IGUIFactory _factory;

    public Application(IGUIFactory factory)
    {
        _factory = factory;
    }

    public void Run()
    {
        var button = _factory.CreateButton();
        var checkbox = _factory.CreateCheckbox();
        var window = _factory.CreateWindow();

        // Core application logic
        window.Paint();
        button.Paint();
        checkbox.Paint();
    }
}