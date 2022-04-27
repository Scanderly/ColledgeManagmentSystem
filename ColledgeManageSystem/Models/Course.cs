using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColledgeManageSystem.Models
{
    public class Course : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }

    }
}