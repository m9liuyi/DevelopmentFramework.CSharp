using System.Collections.Generic;
using System.Linq;

using CSharpDemo.Models.QueryParameter;
using CSharpDemo.BL.Interface;
using CSharpDemo.DAL.Interface;
using CSharpDemo.Models.DTO;

namespace CSharpDemo.BL
{
    public class ZJBankCodeManager : IZJBankCodeManager
    {

        private IZJBankCodeDAL dal = null;


        public ZJBankCodeManager(IZJBankCodeDAL _dal)
        {
            this.dal = _dal;
        }

        public ZJBankCodeDTO Get(int id)
        {
            return this.dal.Find(p => p.ZJBankCodeID == id);
        }

        public IList<ZJBankCodeDTO> List(ZJBankCodeQueryParameter param)
        {
            return this.dal.FindList(p => p.ZJBankCodeID > 0, 
                true, 
                p => p.ZJBankCodeID)
                .ToList();
        }

        public ZJBankCodeDTO Create(ZJBankCodeDTO item)
        {
            return this.dal.Create(item);
        }

        public ZJBankCodeDTO Update(ZJBankCodeDTO item)
        {
            return this.dal.Update(item);
        }


        public void Delete(int itemId)
        {
            this.dal.Delete(this.Get(itemId));
        }
    }
}
