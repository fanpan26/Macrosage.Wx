using Pz.Weixin.Config.Api;
using Pz.Weixin.Config.Api.Model.Result;
using Pz.Weixin.Logic.AccessToken;
using Pz.Weixin.Utils.Common.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Logic.User
{
    /*
     * create 2015-10-27
     * 用户基础信息帮助类
     * 获取用户基础信息，读取UserInfoApi中的api
     */
    public class UserHelper
    {
        #region 获取用户的基本信息
        /// <summary>
        /// 获取用户的基本信息
        /// </summary>
        /// <param name="openId">用户的openId</param>
        /// <returns></returns>
        public static GetUserInfoResult GetUserInfo(string openId)
        {
            //接口url
            string url = string.Format(UserInfoApi.GetUserInfo_Url, AccessToken.AccessTokenHelper.AccessToken, openId);
            return CommonSend.Send<GetUserInfoResult>("", url, null, Utils.Logic.Enum.WxRequestType.RequestTypeGet);
        }
        #endregion

        #region   获取所有关注公众号的openid
        /// <summary>
        /// 获取所有关注公众号的openid
        /// </summary>
        /// <returns></returns>
        public static GetAllSubScriptUserOpenIdResult GetAllUserOpenIds()
        {
            return ApiHandlerWapper.TryCommonApi<GetAllSubScriptUserOpenIdResult>(accessToken =>
            {
                return CommonSend.Send<GetAllSubScriptUserOpenIdResult>(accessToken,
                   UserInfoApi.GetSubscriptUserOpenIdsAll_Url, null, Utils.Logic.Enum.WxRequestType.RequestTypeGet);
            }, null);
        }
        #endregion
    }
}
