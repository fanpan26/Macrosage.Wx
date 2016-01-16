using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Macrosage.Utility;
using Pz.Weixin.Config.Api.Model;
using Pz.Weixin.Utils.Logic.Enum;
using Pz.Weixin.Utils.Logic.Excetion;
namespace Pz.Weixin.Utils.Common.Http
{
    public static class Get
    {
        public static T GetJson<T>(string url, Encoding encoding = null)
        {
            string returnText = RequestUtility.HttpGet(url, encoding);

            if (returnText.Contains("errcode"))
            {
                //可能发生错误
                RequestErrorResult errorResult = JsonHelper.ToDeserializeObject<RequestErrorResult>(returnText);
                if (errorResult.errcode != WxRequestCode.RequestCode_Success.GetHashCode())
                {
                    //发生错误
                    throw new WxException(string.Format("Get请求错误，Api：{0},error：{1}", url, errorResult.errmsg), null, true,errorResult.errcode);
                }
            }

            T result = JsonHelper.ToDeserializeObject<T>(returnText);

            return result;
        }

        public static void Download(string url, Stream stream)
        {
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
            //ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);  

            WebClient wc = new WebClient();
            var data = wc.DownloadData(url);
            foreach (var b in data)
            {
                stream.WriteByte(b);
            }
        }
    }
}
