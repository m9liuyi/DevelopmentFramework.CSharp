using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.Models.DTO;
using CSharpDemo.Models.QueryParameter;
using CSharpDemo.Models.Common;

namespace CSharpDemo.BL.Interface
{
    public interface IContractManager : IIoC
    {
        ContactDTO Get(int id);
        List<ContactDTO> List(ContactQueryParameter param);
        ContactDTO Create(ContactDTO contact);
        ContactDTO Update(ContactDTO contact);
        void Delete(int contactId);
    }
}
