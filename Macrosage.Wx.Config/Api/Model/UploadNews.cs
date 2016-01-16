using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api.Model
{
    /*
     * 上传图文消息Model
     */
    public class UploadNews
    {
        /// <summary>
        /// 图文消息 1 - 10条
        /// </summary>
       public List<Article> articles { get; set; }
    }

    public class Article
    {
        /// <summary>
        /// 缩略图id
        /// </summary>
        public string thumb_media_id { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string author { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 点开原文链接地址
        /// </summary>
        public string content_source_url { get; set; }
        /// <summary>
        /// 点开原文后的内容可以包含html标签
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 图文信息的描述
        /// </summary>
        public string digest { get; set; }

    }
}
