using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.Models.DTO;
using CSharpDemo.Models.Entity;

namespace CSharpDemo.DAL.Interface
{
    public interface IZJBankCodeDAL : IGenericRepository<ZJBankCodeDTO, ZJBankCode>
    {
        
    }
}
