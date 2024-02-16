using Assigment2;

class Program
{
    static void Main(string[] args)
    {
        IGUIFactory factory = DetermineFactoryFromOS(); 
        var button = factory.CreateButton();
        var checkbox = factory.CreateCheckbox();
        var window = factory.CreateWindow();

        window.Paint();
        button.Paint();
        checkbox.Paint();
    }

    static IGUIFactory DetermineFactoryFromOS()
    {
        if (Environment.OSVersion.Platform == PlatformID.Win32NT)
        {
            return new WindowsFactory();
        }
        else if (Environment.OSVersion.Platform == PlatformID.Unix)
        {
            return new LinuxFactory();
        }
        else
        {
            throw new NotSupportedException("OS not supported");
        }
    }
}