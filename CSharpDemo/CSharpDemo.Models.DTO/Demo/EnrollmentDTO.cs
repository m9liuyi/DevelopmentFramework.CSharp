using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Models.DTO
{
    public class EnrollmentDTO
    {
        public int EnrollmentID { get; set; }
        public int ContactID { get; set; }
        public int GroupID { get; set; }

        public virtual ContactDTO Contact { get; set; }
        public virtual GroupDTO Group { get; set; }
    }
}
