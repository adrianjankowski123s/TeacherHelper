using Microsoft.AspNetCore.Mvc;
using TeacherHelper.DataAccess.Repository.IRepository;
using TeacherHelper.Models;

namespace TeacherHelperWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeacherController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public TeacherController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Teacher> objTeacherList = _unitOfWork.Teacher.GetAll();
            return View();
        }

        //GET
        public IActionResult Upsert(int? id)
        {
            Teacher teacher = new();
            if (id == null || id == 0)
            {
                return View(teacher);
            }
            else
            {
                teacher = _unitOfWork.Teacher.GetFirstOrDefault(u => u.Id == id);

                if (teacher == null)
                {
                    return NotFound();
                }
                return View(teacher);
            }


        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var teacherList = _unitOfWork.Teacher.GetAll();
            return Json(new { data = teacherList });
        }
        #endregion

    }
}
