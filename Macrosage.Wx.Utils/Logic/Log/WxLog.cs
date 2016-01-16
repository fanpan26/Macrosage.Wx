using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Macrosage.Utility;
using Pz.Weixin.Utils.Logic.Excetion;

namespace Pz.Weixin.Utils.Logic.Log
{
    public class WxLog
    {
        public static void Log(string msg)
        {
            Log("Normal", msg);
        }

        public static void Log(WxException ex)
        {
            Log(ex.Message);
        }
        public static void Log(string title, string msg)
        {
            LogHelper.ErrorLog(string.Format("Pz.Weixin_{0}",title), msg);
        }
    }
}
