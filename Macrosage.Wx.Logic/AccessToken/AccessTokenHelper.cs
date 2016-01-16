using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pz.Weixin.Config;
using Pz.Weixin.Config.Api.Model;
using Pz.Weixin.Utils;
using Pz.Weixin.Config.Api;
using Pz.Weixin.Utils.Common.Http;
using Macrosage.Utility.Cache;
using Pz.Weixin.Config.App;
using Macrosage.Utility;

namespace Pz.Weixin.Logic.AccessToken
{
    public class AccessTokenHelper
    {
       // private static object _lock = new object();
        private static object _token_lock = new object();
        private static AccessTokenModel _token;
        public static bool Refresh = false;

        private static AccessTokenModel getAccessToken()
        {
            var accessTokenResult = Get.GetJson<AccessTokenModel>(AccessTokenApi.AccessToken_FullUrl, Encoding.UTF8);
            return accessTokenResult;
        }

        public static string AccessToken
        {
            get
            {
                return TokenModel.Access_Token;
            }
        }
        public static AccessTokenModel TokenModel
        {
            get
            {
                //如果token是空，或者token 已经过期了，那么请求接口
                if (_token.IsNull() || _token.TimeOut || Refresh)
                {
                    lock (_token_lock)
                    {
                        var model = getAccessToken();
                        _token = new AccessTokenModel(model.Access_Token, model.Expires_In);
                        Refresh = false;//讲需要刷新在改成false
                    }
                }
                return _token;
            }
        }

    }
}
