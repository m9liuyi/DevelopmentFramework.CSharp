using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.Models.Entity.ORM;
using CSharpDemo.Models.DTO;

namespace CSharpDemo.DAL
{
    public class ContactRepository
    {
        private CSharpDemoContext context = null;

        public ContactRepository()
        {
            context = new CSharpDemoContext();
        }

        public void Create(ContactDTO contact)
        {

        }
    }
}
