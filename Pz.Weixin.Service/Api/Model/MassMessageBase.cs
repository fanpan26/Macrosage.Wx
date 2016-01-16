using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api.Model
{
    public class MassMessageBase
    {
        /// <summary>
        /// openid列表
        /// </summary>
        public List<string> touser { get; set; }
        /// <summary>
        /// 消息类型
        /// 外界不可以访问，初始化的时候会给相应的值
        /// </summary>
        public string msgtype { get; protected set; }
        public MassMessageBase(List<string> openids)
        {
            this.touser = openids;
        }
        public MassMessageBase() { }
    }

    /// <summary>
    /// 文本类型的内容
    /// </summary>
    public class MassMessageText : MassMessageBase
    {
        public MassMessageTextDetail text { get; set; }
        public MassMessageText()
        {
            this.msgtype = "text";
            text = new MassMessageTextDetail();
        }
        public MassMessageText(List<string> openids)
            : base(openids)
        {
            this.msgtype = "text";
            text = new MassMessageTextDetail();
        }
    }

    /// <summary>
    /// 语音类型的内容
    /// </summary>
    public class MassMessageVoice : MassMessageBase
    {
        public MassMessageMediaDetail voice { get; set; }
        public MassMessageVoice()
        {
            this.msgtype = "voice";
            voice = new MassMessageMediaDetail();
        }
        public MassMessageVoice(List<string> openids)
            : base(openids)
        {
            this.msgtype = "voice";
            voice = new MassMessageMediaDetail();
        }
    }

    /// <summary>
    /// 图片类型的内容
    /// </summary>
    public class MassMessageImage : MassMessageBase
    {
        public MassMessageMediaDetail image { get; set; }
        public MassMessageImage()
        {
            this.msgtype = "image";
            image = new MassMessageMediaDetail();
        }
        public MassMessageImage(List<string> openids)
            : base(openids)
        {
            this.msgtype = "image";
            image = new MassMessageMediaDetail();
        }
    }

    /// <summary>
    /// 视频类型的内容
    /// </summary>
    public class MassMessageVideo : MassMessageBase
    {
        public MassMessageVideoDetail video { get; set; }
        public MassMessageVideo()
        {
            this.msgtype = "video";
            video = new MassMessageVideoDetail();
        }

        public MassMessageVideo(List<string> openids)
            : base(openids)
        {
            this.msgtype = "video";
            video = new MassMessageVideoDetail();
        }
    }
    /// <summary>
    /// 新闻类型内容
    /// </summary>
    public class MassMessageNews : MassMessageBase
    {
        public MassMessageMediaDetail mpnews { get; set; }
        public MassMessageNews()
        {
            this.msgtype = "mpnews";
            mpnews = new MassMessageMediaDetail();
        }
        public MassMessageNews(List<string> openids)
            : base(openids)
        {
            this.msgtype = "mpnews";
            mpnews = new MassMessageMediaDetail();
        }
    }

    /// <summary>
    /// 文本类型的详细内容
    /// </summary>
    public class MassMessageTextDetail
    {
        public string content { get; set; }
    }

   
    /// <summary>
    /// 语音或者媒体
    /// </summary>
    public class MassMessageMediaDetail
    {
        public string media_id { get; set; }
    }

   
    /// <summary>
    /// 视频详细
    /// </summary>
    public class MassMessageVideoDetail : MassMessageMediaDetail
    {
        public string title { get; set; }
        public string description { get; set; }
    }

}
