using Baitapbuoi19.DataAccess.DTO;
using Baitapbuoi19.DataAccess.IServices;
using Baitapbuoi19.Models;

namespace Baitapbuoi19.DataAccess.Services
{
    public class StudentServices : IStudentServices
    {
        private StudentDBcontext dbcontext = new StudentDBcontext();
        public async Task<ReturnData> AddStudent(StudentRequestData requestData)
        {
            ReturnData result = new ReturnData();
            try
            {
                if (requestData == null
                    || requestData.StudentID <= 0
                    || requestData.StudentName == null
                    || requestData.StudentClass == null
                    || requestData.StudentEmail == null
                    || requestData.StudentGender == null
                    || requestData.StudentAge <= 0)
                {
                    result.ReturnCode = -1;
                    result.ReturnMsg = "Dữ liệu vào không hợp lệ!";
                    return result;
                }
                if (checkInput.CheckIsNullOrWhiteSpace(requestData.StudentName) == true
                    || checkInput.ContainsNumber(requestData.StudentName) == true
                    || checkInput.CheckIsNullOrWhiteSpace(requestData.StudentEmail) == true
                    || checkInput.ContainsNumber(requestData.StudentGender) == true
                    || checkInput.CheckIsNullOrWhiteSpace(requestData.StudentGender) == true
                    || checkInput.CheckIsNullOrWhiteSpace(requestData.StudentClass) == true)
                {
                    result.ReturnCode = -1;
                    result.ReturnMsg = "Dữ liệu vào không hợp lệ!";
                    return result;
                }
                if (dbcontext.students.Find(requestData.StudentID) != null)
                {
                    result.ReturnCode = -1;
                    result.ReturnMsg = "học sinh vừa nhập đã có trên hệ thống!";
                    return result;
                }
                var StudentReq = dbcontext.students.Find(requestData.StudentName);
                dbcontext.students.Add(StudentReq);
                dbcontext.SaveChanges();
                result.ReturnCode = 1;
                result.ReturnMsg = "Thêm học sinh thành công!";
                return result;
            }
            catch (Exception ex)
            {
                result.ReturnCode = -1;
                result.ReturnMsg = "Hệ thống đang bận:" + ex.Message;
                return result;
            }
        }
        public IEnumerable<Students> GetAllStudents()
        {
            return dbcontext.students.ToList();
        }
    }
}
