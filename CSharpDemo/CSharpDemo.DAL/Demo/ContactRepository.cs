using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.Models.Entity.ORM;
using CSharpDemo.Models.DTO;
using CSharpDemo.Utility;
using CSharpDemo.Models.Entity;
using CSharpDemo.Models.QueryParameter;
using CSharpDemo.DAL.Interface;

namespace CSharpDemo.DAL
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(CSharpDemoContext _context) : base(_context)
        {

        }

        public ContactDTO Get(int id)
        {
            var entity = this.Find(p => p.ID == id);
            return MapperHelper.MapTo<ContactDTO>(entity);
        }

        public List<ContactDTO> List(ContactQueryParameter param)
        {
            var entities = context.Contacts.ToList();
            return MapperHelper.MapTo<ContactDTO>(entities);
        }

        public ContactDTO Create(ContactDTO contact)
        {
            var entity = MapperHelper.MapTo<Contact>(contact);
            this.Add(entity);

            return MapperHelper.MapTo<ContactDTO>(entity);
        }

        public ContactDTO Update(ContactDTO contact)
        {
            var entity = context.Contacts.Where(p => p.ID == contact.ID).FirstOrDefault();

            this.Update(entity);

            context.SaveChanges();

            return MapperHelper.MapTo<ContactDTO>(entity);
        }

        public void Delete(int contactId)
        {
            var entity = context.Contacts.Where(p => p.ID == contactId).FirstOrDefault();
            this.Delete(entity);
        }
    }
}
