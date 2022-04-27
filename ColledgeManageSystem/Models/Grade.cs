using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColledgeManageSystem.Models
{
    public class Grade : Entity
    {
        public int StudentId { get; set; }
        public int SubjectId { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }

    }
}