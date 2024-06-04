using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Baitapbuoi19.DataAccess.DTO;
using Baitapbuoi19.Models;
using Baitapbuoi19.DataAccess.Services;
using Baitapbuoi19.DataAccess.IServices;

namespace Baitapbuoi19.Controllers
{
    public class StudentsController : Controller
    {

        private readonly IStudentServices _studentServices;
        public StudentsController(IStudentServices studentServices)
        {
            _studentServices = studentServices;
        }
        public IActionResult Index()
        {
            var students = _studentServices.GetAllStudents();
            return View(students);
        }
       
        // Hiển thị form để thêm học sinh mới
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý dữ liệu từ form thêm học sinh mới
        [HttpPost]
        public async Task<JsonResult> AddStudents(StudentRequestData requestData)
        {
            var model = new ReturnData();
            try
            {
                if (requestData == null
                    || string.IsNullOrEmpty(requestData.StudentName)
                    || string.IsNullOrEmpty(requestData.StudentGender)
                    || string.IsNullOrEmpty(requestData.StudentEmail)
                    )
                {
                    model.ReturnCode = -1;
                    model.ReturnMsg = "Dữ liệu không được trống";
                    return Json(model);
                }

                var rs = await new Baitapbuoi19.DataAccess.Services.StudentServices().AddStudent(requestData);

                model.ReturnCode = rs.ReturnCode;
                model.ReturnMsg = rs.ReturnMsg;
                return Json(model);
            }
            catch (Exception ex)
            {

                throw;
            }

            return Json(model);
        }
    }
}
