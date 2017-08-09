using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.Models.Enum;

namespace CSharpDemo.Models.Entity
{
    public class Group
    {
        public int GroupID { get; set; }
        public GroupName? GroupName { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
