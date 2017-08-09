using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.Models.Enum;

namespace CSharpDemo.Models.DTO
{
    public class GroupDTO
    {
        public int GroupID { get; set; }
        public GroupName? GroupName { get; set; }

        public virtual ICollection<EnrollmentDTO> Enrollments { get; set; }
    }
}
