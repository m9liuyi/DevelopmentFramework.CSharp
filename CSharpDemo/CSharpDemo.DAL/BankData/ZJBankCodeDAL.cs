using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.DAL.Interface;
using CSharpDemo.Models.Entity.ORM;
using CSharpDemo.Models.DTO;
using CSharpDemo.Models.Entity;

namespace CSharpDemo.DAL
{
    public class ZJBankCodeDAL : GenericRepository<ZJBankCodeDTO, ZJBankCode>, IZJBankCodeDAL
    {
        public ZJBankCodeDAL(CSharpDemoContext _context) : base(_context)
        {

        }
    }
}
