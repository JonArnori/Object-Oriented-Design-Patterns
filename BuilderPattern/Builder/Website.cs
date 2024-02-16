namespace Assigment3;


public class Website : IWebsiteComponent
{
    private List<IWebsiteComponent> components = new List<IWebsiteComponent>();

    public void AddComponent(IWebsiteComponent component)
    {
        components.Add(component);
    }

    public void RemoveComponent(IWebsiteComponent component)
    {
        components.Remove(component);
    }

    public void Display()
    {
        foreach (var component in components)
        {
            component.Display();
        }
    }
}
