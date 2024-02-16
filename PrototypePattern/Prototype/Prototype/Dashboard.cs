namespace Prototype;

public class Dashboard
{
    private List<IWidgetPrototype> widgets = new List<IWidgetPrototype>();

    public void AddWidget(IWidgetPrototype widget)
    {
        widgets.Add(widget);
    }

    public IWidgetPrototype CloneWidget(int widgetIndex)
    {
        if (widgetIndex < 0 || widgetIndex >= widgets.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(widgetIndex), "Widget index is out of range.");
        }
        return widgets[widgetIndex].Clone();
    }

    public void DisplayWidgets()
    {
        foreach (var widget in widgets)
        {
            if (widget is Widget concreteWidget) // Safe cast
            {
                Console.WriteLine($"Widget: {concreteWidget.Name}");
                foreach (var config in concreteWidget.Configuration)
                {
                    Console.WriteLine($" - {config.Key}: {config.Value}");
                }
            }
        }
    }
}
