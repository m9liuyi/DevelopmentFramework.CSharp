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
    public interface IZJBankCodeManager : IIoC
    {
        ZJBankCodeDTO Get(int itemId);
        IList<ZJBankCodeDTO> List(ZJBankCodeQueryParameter param);
        ZJBankCodeDTO Create(ZJBankCodeDTO item);
        ZJBankCodeDTO Update(ZJBankCodeDTO item);
        void Delete(int itemId);
    }
}
