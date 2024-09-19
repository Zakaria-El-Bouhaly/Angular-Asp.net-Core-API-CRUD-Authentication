using Microsoft.AspNetCore.Identity;

namespace Colab.Domain.Models;
public class Role : IdentityRole<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
