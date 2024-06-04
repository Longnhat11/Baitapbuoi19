using System.ComponentModel.DataAnnotations;

namespace Baitapbuoi19.DataAccess.DTO
{
    public class StudentRequestData
    {
        [Key]public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentGender { get; set; }
        public string StudentClass { get; set; }
        public string StudentEmail { get; set; }
        public int StudentAge { get; set; }
    }
}
