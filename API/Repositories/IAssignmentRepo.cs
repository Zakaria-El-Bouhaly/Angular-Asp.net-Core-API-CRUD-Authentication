using Colab.Models;
using Colab.Requests;
namespace Colab.Repositories;
public interface IAssignmentRepo
{
    Task<IEnumerable<Assignment>> GetAssignments();
    Task<Assignment> GetAssignment(int id);
    Task<Assignment> PutAssignment(AssignmentRequest assignment);
    Task<Assignment> PostAssignment(BaseAssignmentRequest assignment);
    Task<Assignment> DeleteAssignment(int id);
    Task<IEnumerable<Assignment>> GetAssignmentsByUserProject(int id);
    
}