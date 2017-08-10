using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.DAL;
using CSharpDemo.Models.DTO;
using CSharpDemo.Models.QueryParameter;
using CSharpDemo.BL.Interface;

namespace CSharpDemo.BL
{
    public class ContractManager : IContractManager
    {

        private ContactRepository contactRep = null;


        public ContractManager()
        {
            this.contactRep = new ContactRepository();
        }

        public ContactDTO Get(int id)
        {
            return this.contactRep.Get(id);
        }

        public List<ContactDTO> List(ContactQueryParameter param)
        {
            return this.contactRep.List(param);
        }

        public ContactDTO Create(ContactDTO contact)
        {
            return this.contactRep.Create(contact);
        }

        public ContactDTO Update(ContactDTO contact)
        {
            return this.contactRep.Update(contact);
        }


        public void Delete(int contactId)
        {
            this.contactRep.Delete(contactId);
        }
    }
}
