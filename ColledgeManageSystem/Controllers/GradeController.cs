using ColledgeManageSystem.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColledgeManageSystem.Controllers
{
    public class GradeController : Controller
    {
        // GET: Grade
        ColledgeContext context = new ColledgeContext();

        public ActionResult Index()
        {
            var grades = context.Grades.Include(g => g.Student).Include(g => g.Subject);
            ViewBag.StudentId = new SelectList(context.Students, "Id", "FullName");
            ViewBag.SubjectId = new SelectList(context.Subjects, "Id", "Name");
            return View(grades.ToList());
        }
    }
}