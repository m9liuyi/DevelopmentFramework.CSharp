﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Models.Entity
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int ContactID { get; set; }
        public int GroupID { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Group Group { get; set; }
    }
}
