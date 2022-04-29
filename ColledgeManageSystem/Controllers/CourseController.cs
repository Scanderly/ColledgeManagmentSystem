using ColledgeManageSystem.Models;
using ColledgeManageSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColledgeManageSystem.Controllers
{
    public class CourseController : Controller
    {
        private readonly IGenericRepository<Course> _repo;
        //private readonly ColledgeContext _context;
        public CourseController()
        {
            _repo = new GenericRepository<Course>();

        }

        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public JsonResult Create(Course course)
        {
            
            _repo.CreateItem(course);
            return Json(course, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetList()
        {
            var courses = _repo.GetAllEntities();
            return Json(courses, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCourseById(int? id)
        {
            var course = _repo.GetItemById(id);
            return Json(course, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Edit(int? id)
        {
            var course = _repo.GetItemById(id);
            return View(course);
        }
        public JsonResult Update(Course course)
        {
            _repo.Update(course);
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