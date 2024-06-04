using System.ComponentModel.DataAnnotations;

namespace Baitapbuoi19.Models
{
    public class Students
    {
        [Key]public int StudentID { get;set;}
        [Required(ErrorMessage = "Tên không được để trống.")]
        [StringLength(50, ErrorMessage = "Tên không được dài quá 50 ký tự.")]
        [RegularExpression(@"^[a-zA-Z0-9\s]*$", ErrorMessage = "Tên không được chứa ký tự đặc biệt.")]
        public string StudentName { get;set;}
        public string StudentGender { get;set;}
        public string StudentClass { get;set;}
        [EmailAddress(ErrorMessage = "Email không đúng định dạng.")]
        public string StudentEmail { get;set;}
        [Range(18, 100, ErrorMessage = "Tuổi phải từ 18 đến 100.")]
        public int StudentAge { get;set; }
    }
}
