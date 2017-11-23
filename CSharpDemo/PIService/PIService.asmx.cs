using CSharpDemo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace CSharpDemo.PIService
{
    /// <summary>
    /// Summary description for PIService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    //[WebService(Namespace = "urn:gmk:service-zj", Name = "PIService")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PIService : System.Web.Services.WebService
    {
        [WebMethod]
        public string PINotification2()
        {
            try
            {
                LogHelper.LogInformation("你好");
                return "你好";
            }
            catch (Exception e)
            {
                LogHelper.LogError("你不好" + e.ToString());
                return "你不好";
            }
        }

        [WebMethod]
        public DT_TM2NET PINotification(DT_TM2NET data)
        {
            LogHelper.LogInformation("PINotification Start: " + data.ToString());

            try
            {
                data.xmlDataOut = "hello world 1";
                data.xmlEx = "hellow world 2";
                LogHelper.LogInformation("PINotification End: ");
                return data;
            }
            catch (Exception e)
            {
                data.xmlEx = e.ToString();
                LogHelper.LogError("PINotification Error: " + e.ToString());
                return data;
            }
        }
    }

    public class DT_TM2NET
    {
        public string WFID { get; set; }

        public string Point { get; set; }

        public string xmlKey { get; set; }

        public string xmlDataIn { get; set; }

        public string xmlDataOut { get; set; }

        public string xmlEx { get; set; }
    }
}
