using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpDemo.Utility;

namespace CSharpDemo.Tests.Controllers
{
    public class BaseTest
    {
        public BaseTest()
        {
            MapperHelper.RegisterMappings();
        }
    }
}
