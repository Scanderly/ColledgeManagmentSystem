﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ColledgeManageSystem.Models
{
    public class Teacher : Entity
    {
        public string FullName { get; set; }
        public DateTime BirthdayDate { get; set; }
        public decimal Salary { get; set; }

    }
}