using Macrosage.Utility;
using Pz.Weixin.Config.App;
using Pz.Weixin.Utils.Logic.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Utils.Common.Http
{
    public class CommonSend
    {
        /// <summary>
        /// 通用发送请求类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="accessToken"></param>
        /// <param name="urlFormat"></param>
        /// <param name="data"></param>
        /// <param name="sendType"></param>
        /// <param name="timeOut"></param>
        /// <param name="checkValidationResult"></param>
        /// <returns></returns>
        public static T Send<T>(string accessToken, string urlFormat, object data, WxRequestType sendType = WxRequestType.RequestTypePost, int timeOut = App.AppRequestTimeOut, bool checkValidationResult = false)
        {
            var url = string.IsNullOrEmpty(accessToken) ? urlFormat : string.Format(urlFormat, accessToken);
            switch (sendType)
            {
                case WxRequestType.RequestTypeGet:
                    return Get.GetJson<T>(url);
                case WxRequestType.RequestTypePost:
                    var jsonString = data.ToJson();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        var bytes = Encoding.UTF8.GetBytes(jsonString);
                        ms.Write(bytes, 0, bytes.Length);
                        ms.Seek(0, SeekOrigin.Begin);

                        return Post.PostGetJson<T>(url, null, ms, timeOut: timeOut, checkValidationResult: checkValidationResult);
                    }
                default:
                    throw new ArgumentOutOfRangeException("sendType");
            }
        }
    }
}
