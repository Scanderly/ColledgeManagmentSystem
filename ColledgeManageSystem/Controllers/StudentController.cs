using ColledgeManageSystem.Models;
using ColledgeManageSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColledgeManageSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IGenericRepository<Student> _repo;
        //private readonly ColledgeContext _context;
        public StudentController()
        {
            _repo = new GenericRepository<Student>();

        }

        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Create(Student student)
        {
            _repo.CreateItem(student);
            return Json(student, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetList()
        {
            var students = _repo.GetAllEntities();
            return Json(students, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetById(int? id)
        {
            var student = _repo.GetItemById(id);
            return Json(student, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Edit()
        {
            return View();
        }
        public JsonResult Update(Student student)
        {
            _repo.Update(student);
            string res = "Updated";
            return Json(res, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int? id)
        {
            _repo.Delete(id);
            string res = "Deleted";
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}