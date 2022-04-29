﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ColledgeManageSystem.Models
{
    [Table("Subjects")]
    public class Subject : Entity
    {
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}