using System;
using Assigment3;

namespace WebsiteGenerator
{
    class Program
    {
        static void Main()
        {
            var portfolioWebsite = new Website();
            portfolioWebsite.AddComponent(new HomePage());
            portfolioWebsite.AddComponent(new AboutPage());
            portfolioWebsite.AddComponent(new ContactForm());
            portfolioWebsite.AddComponent(new Gallery());

            var businessWebsite = new Website();
            businessWebsite.AddComponent(new HomePage());
            businessWebsite.AddComponent(new AboutPage());
            businessWebsite.AddComponent(new ContactForm());
            businessWebsite.AddComponent(new Blog());

            var personalBlogWebsite = new Website();
            personalBlogWebsite.AddComponent(new HomePage());
            personalBlogWebsite.AddComponent(new Blog());

            Console.WriteLine("Portfolio Website:");
            portfolioWebsite.Display();

            Console.WriteLine("\nBusiness Website:");
            businessWebsite.Display();

            Console.WriteLine("\nPersonal Blog Website:");
            personalBlogWebsite.Display();
        }
    }
}