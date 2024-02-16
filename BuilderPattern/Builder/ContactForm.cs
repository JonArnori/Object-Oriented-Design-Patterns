namespace Assigment3;

public class ContactForm : IWebsiteComponent
{
    public void Display()
    {
        Console.WriteLine("Contact Us\n");
        Console.WriteLine("Please fill out the form below to get in touch with us:");
        Console.WriteLine("Name: ___________");
        Console.WriteLine("Email: ___________");
        Console.WriteLine("Message:");
        Console.WriteLine("_______________");
    }
}
