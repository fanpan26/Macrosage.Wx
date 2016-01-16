using Pz.Weixin.Utils.Logic.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Utils.Logic.Excetion
{
    public class WxException : System.Exception
    {
        public int ErrorCode = 0;
        public WxException(string message)
            : base(message, null)
        {
        }

        public WxException(string message, Exception inner)
            : base(message, inner)
        {
        }
        /// <summary>
        /// 抛异常时候自动记录日志
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        /// <param name="isLog"></param>
        public WxException(string message, Exception inner, bool isLog = false)
            : base(message, inner)
        {
            if (isLog) {
                WxLog.Log(this);
            }
        }

        public WxException(string message,Exception inner,bool isLog  = false,int errcode = 0)
        :base(message,inner){
            if (isLog) {
                WxLog.Log(this);
            }
            this.ErrorCode = errcode;
        }
    }
}
