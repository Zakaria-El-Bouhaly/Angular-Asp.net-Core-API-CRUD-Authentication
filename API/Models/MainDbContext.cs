namespace Colab.Models;

using Bogus;
using Microsoft.EntityFrameworkCore;
public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {

    }

    //enab  le lazy loading by proxy
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // optionsBuilder.UseLazyLoadingProxies();
        // optionsBuilder.EnableSensitiveDataLogging();
    }



    // seed data 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<ProjectUser>()
       .HasKey(pu => new { pu.ProjectId, pu.UserId });
        modelBuilder.Entity<ProjectUser>()
            .HasOne(pu => pu.Project).WithMany(p => p.Participators).HasForeignKey(pu => pu.ProjectId);
        modelBuilder.Entity<ProjectUser>().HasOne(pu => pu.User).WithMany(u => u.Participations).HasForeignKey(pu => pu.UserId);


        var i = 1;
        var randomusers = new Faker<User>()
                    .RuleFor(m => m.Id, f => i++)
                    .RuleFor(m => m.Name, f => f.Name.FullName())
                    .RuleFor(m => m.Email, f => f.Internet.Email())
                    .RuleFor(m => m.Password, f => f.Internet.Password());


        modelBuilder.Entity<User>()
                        .HasData(randomusers.Generate(5));

        var j = 1;

        var randomProjects = new Faker<Project>().RuleFor(m => m.Id, f => j++)
                                                 .RuleFor(m => m.Title, f => f.Commerce.ProductName())
                                                 .RuleFor(m => m.Description, f => f.Lorem.Paragraph().Substring(0, 20))
                                                 .RuleFor(m => m.CreatedAt, f => f.Date.Past())
                                                 .RuleFor(m => m.UpdatedAt, f => f.Date.Past());

        modelBuilder.Entity<Project>()
                        .HasData(randomProjects.Generate(10));

        var k = 1;
        var randomAssignments = new Faker<Assignment>().RuleFor(m => m.Id, f => k++)
                                                       .RuleFor(m => m.Title, f => f.Commerce.ProductName())
                                                       .RuleFor(m => m.Description, f => f.Lorem.Paragraph().Substring(0, 20))
                                                       .RuleFor(m => m.CreatedAt, f => f.Date.Past())
                                                       .RuleFor(m => m.UpdatedAt, f => f.Date.Past())
                                                       .RuleFor(m => m.IsCompleted, f => f.Random.Bool())
                                                       .RuleFor(m => m.ProjectId, f => f.Random.Int(1, 10));


        modelBuilder.Entity<Assignment>().HasData(randomAssignments.Generate(20));

      

    }


    public DbSet<User> Users { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Project> Projects { get; set; }

}