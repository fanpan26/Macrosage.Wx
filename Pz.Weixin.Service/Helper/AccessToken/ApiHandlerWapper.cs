using Pz.Weixin.Utils.Logic.Enum;
using Pz.Weixin.Utils.Logic.Excetion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pz.Weixin.Logic.AccessToken
{
    /// <summary>
    /// 针对AccessToken无效或过期的自动处理类
    /// </summary>
    public static class ApiHandlerWapper
    {
        /// <summary>
        /// 使用AccessToken进行操作时，如果遇到AccessToken错误的情况，重新获取AccessToken一次，并重试。
        /// 使用此方法之前必须使用AccessTokenContainer.Register(_appId, _appSecret);或JsApiTicketContainer.Register(_appId, _appSecret);方法对账号信息进行过注册，否则会出错。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fun"></param>
        /// <param name="accessTokenOrAppId">AccessToken或AppId。如果为null，则自动取已经注册的第一个appId/appSecret来信息获取AccessToken。</param>
        /// <param name="retryIfFaild">请保留默认值true，不用输入。</param>
        /// <returns></returns>
        public static T TryCommonApi<T>(Func<string, T> fun, string accessToken = null, bool retryIfFaild = true)
        {
            T result = default(T);

            try
            {
                //accessToken 重新获取
                if (accessToken == null)
                {
                    accessToken = AccessTokenHelper.AccessToken;
                }
                result = fun(accessToken);
            }
            catch (WxException ex)
            {
                //如果失败了，那么在获取一次
                if (retryIfFaild
                    && ex.ErrorCode == WxRequestCode.RequestCode_IllegalAccessToken.GetHashCode())
                {
                    //尝试重新验证
                    AccessTokenHelper.Refresh = true;//需要刷新
                    accessToken = AccessTokenHelper.AccessToken;
                    result = TryCommonApi(fun, accessToken, false);
                }
                else
                {
                    throw;
                }
            }

            return result;
        }

    }
}
