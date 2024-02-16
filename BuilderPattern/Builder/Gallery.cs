namespace Assigment3;

public class Gallery : IWebsiteComponent
{
    private List<string> images = new List<string>();

    public void AddImage(string imageTitle)
    {
        images.Add(imageTitle);
    }

    public void Display()
    {
        Console.WriteLine("Gallery\n");
        Console.WriteLine("Images:");

        foreach (var image in images)
        {
            Console.WriteLine($"- {image}");
        }
    }
}
