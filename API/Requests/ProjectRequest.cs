using System.ComponentModel.DataAnnotations;
using Colab.Models;

namespace Colab.Requests;
public class ProjectRequest
{   
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }

}

public class ParticiapatorsRequest
{
    [Required]
    public int UserId { get; set; }
    [Required]
    public bool IsOwner { get; set; }
}

