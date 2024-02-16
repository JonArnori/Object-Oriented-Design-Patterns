namespace Assigment3;

public class Blog : IWebsiteComponent
{
    private List<string> blogPosts = new List<string>();

    public void AddBlogPost(string postTitle, string postContent)
    {
        blogPosts.Add($"{postTitle}: {postContent}");
    }

    public void Display()
    {
        Console.WriteLine("Blog Posts:");
        foreach (var post in blogPosts)
        {
            Console.WriteLine(post);
        }
    }
}
