namespace Colab.Domain.Models;
public class MainDbContext : IdentityDbContext<User, Role, Guid>
{


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }



    // seed data 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<ProjectUser>()
       .HasKey(pu => new { pu.ProjectId, pu.UserId });

        modelBuilder.Entity<ProjectUser>()
            .HasOne(pu => pu.Project).WithMany(p => p.Participators).HasForeignKey(pu => pu.ProjectId);

        modelBuilder.Entity<ProjectUser>().HasOne(pu => pu.User).WithMany(u => u.Participations).HasForeignKey(pu => pu.UserId);

        // create roles
        var roles = new List<Role>
        {
            new Role
            {
                Id = Guid.NewGuid(),
                Name = "Admin"
            },
            new Role
            {
                Id = Guid.NewGuid(),
                Name = "User"
            }
        };

        modelBuilder.Entity<Role>().HasData(roles);

        // create admin user
        var admin = new User
        {
            Id = Guid.NewGuid(),
            Email = "admin@demo.com",
            Name = "Admin",            
            IsVerified = true,
            Password = BCrypt.Net.BCrypt.HashPassword("admin123"),
            profilePicture = "profile-images/default.png",
        };

        admin.

        modelBuilder.Entity<User>().HasData(admin);
    }


    public DbSet<User> Users { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<EmailVerifTokens> EmailVerifTokens { get; set; }
    public DbSet<PasswordResetTokens> PasswordResetTokens { get; set; }
    public DbSet<ProjectUserInvitation> ProjectUserInvitations { get; set; }

}