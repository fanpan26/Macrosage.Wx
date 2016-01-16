using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api
{
    /*
     *上传Api
     * 
     */
    public class UploadApi
    {
        /*
         * access_token调用凭证
         * type   iamge图像,voice语音,video视频,thumb缩略图
         * media  form-data 中媒体文件标识，有filename，filelength，content-type
         */
        public const string Upload_Url = "http://file.api.weixin.qq.com/cgi-bin/media/upload?access_token={0}&type={1}";

        /*
         * 上传新闻的Url，上传前需要获取thumb_media_id
         */
        public const string Upload_NewsUrl = "https://api.weixin.qq.com/cgi-bin/media/uploadnews?access_token={0}";

    }
}
