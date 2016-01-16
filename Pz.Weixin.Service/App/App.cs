using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Macrosage.Utility;

namespace Pz.Weixin.Config.App
{
    public class App
    {
        /// <summary>
        /// 公众平台AppId
        /// </summary>
        public static string AppId {
            get
            {
                return getConfigValue("weixin_appid");
            }
        }

        /// <summary>
        /// 公众平台AppSecret
        /// </summary>
        public static string AppSecret {
            get
            {
                return getConfigValue("weixin_secret");
            }
        }

        public const int AppRequestTimeOut = 10000;

        public static readonly string TokenCache = string.Format("WeiXin_Token_SDK_{0}_{1}", AppId, AppSecret);
        /// <summary>
        /// 网页授权获取用户基本信息code
        /// </summary>
        public static readonly string TicketCache = string.Format("WeiXin_Code_SDK_{0}_{1}", AppId, AppSecret);

        #region 私有方法，读取配置文件，如果没有，抛出异常
        private static string getConfigValue(string key)
        {
            var value = AppSettings.GetValue(key);
            if (value.IsNull())
            {
                throw new ArgumentNullException(string.Format("please check config key:{0}"),key);
            }
            return value;
        }
        #endregion
    }
}
