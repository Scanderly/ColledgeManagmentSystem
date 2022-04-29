﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ColledgeManageSystem.Models
{
    [Table("Grades")]
    public class Grade : Entity
    {
        public decimal StudentGrade { get; set; }
        public int? StudentId { get; set; }
        public int? SubjectId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }

    }
}