using Pz.Weixin.Config.Api;
using Pz.Weixin.Config.Api.Model;
using Pz.Weixin.Logic.AccessToken;
using Pz.Weixin.Utils.Common.Http;
using Pz.Weixin.Utils.Logic.Excetion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Logic.Message
{
    public class MessageHelper
    {
        /// <summary>
        /// 基础方法 
        /// </summary>
        /// <param name="openIds">需要接受的openid列表</param>
        /// <param name="message">消息实体</param>
        /// <returns></returns>
        private static RequestSendAllResult SendMessagesToAll(object message)
        {
            return ApiHandlerWapper.TryCommonApi<RequestSendAllResult>(accessToken =>
            {
                return CommonSend.Send<RequestSendAllResult>(accessToken, SendAllApi.SendAllByOpenId_Url, message);

            }, null);
        }
        /// <summary>
        /// 基类传消息
        /// </summary>
        /// <param name="openIds"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static RequestSendAllResult SendBaseMessagesToAll(List<string> openIds, MassMessageBase message) {
            if (openIds == null || openIds.Count == 0) { throw new WxException("接收人OpenId为空"); }
            message.touser = openIds;
            return SendMessagesToAll(message);
        }

        #region 发送具体消息
        public static RequestSendAllResult SendBaseMessagesToAll(MassMessageBase message)
        {
            return SendMessagesToAll(message);
        }
        /// <summary>
        /// 发送文本消息
        /// </summary>
        /// <param name="message">发送文本消息</param>
        /// <returns></returns>
        public static RequestSendAllResult SendTextMessagesToAll(MassMessageText message)
        {
            return SendBaseMessagesToAll(message);
        }

        /// <summary>
        /// 发送图文消息
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static RequestSendAllResult SendNewsMessagesToAll(MassMessageNews message)
        {
            return SendBaseMessagesToAll(message);
        }

        public static RequestSendAllResult SendNewsMessagesToAll(string newsMedia_Id, params string[] openIds)
        {
            MassMessageNews news = new MassMessageNews(openIds.ToList());
            news.mpnews.media_id = newsMedia_Id;
            return SendBaseMessagesToAll(news);
        }
        /// <summary>
        /// 发送音频消息
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static RequestSendAllResult SendVoiceMessagesToAll(MassMessageVoice message)
        {
            return SendBaseMessagesToAll(message);
        }
        /// <summary>
        /// 发送图片消息
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static RequestSendAllResult SendImageMessagesToAll(MassMessageImage message)
        {
            return SendBaseMessagesToAll(message);
        }
        /// <summary>
        /// 发送图片，根据mediaId
        /// </summary>
        /// <param name="imageMedia_Id"></param>
        /// <param name="openIds"></param>
        /// <returns></returns>
        public static RequestSendAllResult SendImageMessagesToAll(string imageMedia_Id,params string[] openIds )
        {
            MassMessageImage image = new MassMessageImage(openIds.ToList());
            image.image.media_id = imageMedia_Id;
            return SendBaseMessagesToAll(image);
        }
        #endregion
    }
}
