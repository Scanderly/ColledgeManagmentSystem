using ColledgeManageSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColledgeManageSystem.ViewModels
{
    public class CourseItems
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public int TeachersNumber { get; set; } 
        public int StudentsNumber { get; set; }
        public decimal Grades { get; set; }
        

    }
}