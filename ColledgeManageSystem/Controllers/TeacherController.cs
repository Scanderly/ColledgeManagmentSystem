using ColledgeManageSystem.DAL;
using ColledgeManageSystem.Models;
using ColledgeManageSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColledgeManageSystem.Controllers
{
    public class TeacherController : Controller
    {
        private readonly IGenericRepository<Teacher> _repo;
        private readonly ColledgeContext _context;
        public TeacherController()
        {
            _repo = new GenericRepository<Teacher>();
           
        }

        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetList()
        {
            var teachers = _repo.GetAllEntities();
            return Json(teachers,JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetTeacherById(int? id)
        {
            var teacher = _repo.GetItemById(id);
            return Json(teacher, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Edit()
        {
            return View();
        }
        public JsonResult Update(Teacher teacher)
        {
            _repo.Update(teacher);
            string res = "Updated";
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}