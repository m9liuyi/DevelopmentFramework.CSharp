using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Utility
{
    public static class LogHelper
    {
        private static ILog logger;

        private static void InitLog4Net()
        {
            if (logger == null)
            {
                var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "bin/log4net.config");
                XmlConfigurator.ConfigureAndWatch(logCfg);

                logger = LogManager.GetLogger(typeof(LogHelper));
            }
        }

        public static void LogInformation(string info)
        {
            InitLog4Net();
            logger.Info(info);
        }

        public static void LogError(string error)
        {
            InitLog4Net();
            logger.Error(error);
        }
    }
}
