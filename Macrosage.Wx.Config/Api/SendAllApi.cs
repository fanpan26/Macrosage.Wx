using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api
{
    /*
     * 群发信息Api
     * 创建 2015-10-26
     * touser 图文消息的接受者为 openid  list
     * mpnews 用于设定即将发送的图文消息
     * media_id用于群发消息的media_id
     * msgtype 消息类型 mpnews  text voice  video image
     * title 消息标题
     * description消息描述
     * thumb_media_id 视频缩略图的媒体Id
     */
    public class SendAllApi
    {
        public const string SendAllByOpenId_Url = "https://api.weixin.qq.com/cgi-bin/message/mass/send?access_token={0}";
    }
}
