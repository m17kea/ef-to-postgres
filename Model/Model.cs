using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public class Author  
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<Article> Articles { get; set; } = new List<Article>();
}

public class Article  
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string Body { get; set; }

    public int AuthorId { get; set; }
    public Author Author { get; set; }
}

public class ArticleContext : DbContext  
{
    public ArticleContext(DbContextOptions<ArticleContext> options)
        : base(options)
    { }

    public DbSet<Article> Articles { get; set; }
    public DbSet<Author> Authors { get; set; }
}
