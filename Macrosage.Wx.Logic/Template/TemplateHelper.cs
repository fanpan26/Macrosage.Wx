using Macrosage.Wx.Config.Api;
using Macrosage.Wx.Config.Api.Model;
using Pz.Weixin.Logic.AccessToken;
using Pz.Weixin.Utils.Common.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macrosage.Wx.Logic.Template
{
    public class TemplateHelper
    {
        /// <summary>
        /// 发送模板
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string SendTempalte(TemplateMessage message)
        {
            return ApiHandlerWapper.TryCommonApi<string>(accessToken =>
            {
                return CommonSend.Send<string>(accessToken, TemplateApi.SendTemplate_Url, message);
            }, null);
        }
    }
}
