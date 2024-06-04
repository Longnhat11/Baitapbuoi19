using Baitapbuoi19.DataAccess.DTO;
using Baitapbuoi19.Models;

namespace Baitapbuoi19.DataAccess.IServices
{
    public interface IStudentServices
    {
        IEnumerable<Students> GetAllStudents();
        Task<ReturnData> AddStudent(StudentRequestData requestData);
    }
}
