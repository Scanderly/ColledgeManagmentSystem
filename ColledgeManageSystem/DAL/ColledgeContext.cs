using ColledgeManageSystem.Models;
using ColledgeManageSystem.SeedData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ColledgeManageSystem.DAL
{
    public class ColledgeContext:DbContext
    {
        public ColledgeContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}