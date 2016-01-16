using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api
{

    public class AccessTokenApi
    {
        #region api
        private const string AccessToken_Url = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";
        #endregion

        public static string AccessToken_FullUrl
        {
            get
            {
                return string.Format(AccessToken_Url, App.App.AppId, App.App.AppSecret);
            }
        }


    }
}
