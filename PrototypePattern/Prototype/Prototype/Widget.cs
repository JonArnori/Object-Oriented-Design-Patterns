namespace Prototype;

public class Widget : IWidgetPrototype
{
    public string Name { get; set; }
    public Dictionary<string, string> Configuration { get; private set; }

    public Widget(string name)
    {
        Name = name;
        Configuration = new Dictionary<string, string>();
    }

    public void Configure(string key, string value)
    {
        Configuration[key] = value;
    }

    public IWidgetPrototype Clone()
    {
        // Deep copy implementation for the Configuration dictionary
        Widget clone = new Widget(Name)
        {
            Configuration = new Dictionary<string, string>(this.Configuration)
        };
        return clone;
    }
}
