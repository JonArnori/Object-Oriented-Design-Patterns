using Prototype;

class Program
{
    static void Main(string[] args)
    {
        var dashboard = new Dashboard();

        var weatherWidget = new Widget("WeatherWidget");
        weatherWidget.Configure("City", "New York");
        weatherWidget.Configure("Units", "Celsius");

        dashboard.AddWidget(weatherWidget);

        var clonedWidget = dashboard.CloneWidget(0) as Widget;
        clonedWidget.Configure("City", "San Francisco");

        dashboard.AddWidget(clonedWidget);

        dashboard.DisplayWidgets();
    }
}