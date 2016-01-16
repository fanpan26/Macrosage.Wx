
using Pz.Weixin.Config.Api;
using Pz.Weixin.Config.Api.Model;
using Pz.Weixin.Config.App;
using Pz.Weixin.Logic.AccessToken;
using Pz.Weixin.Utils.Common.Http;
using Pz.Weixin.Utils.Logic.Enum;
using Pz.Weixin.Utils.Logic.Excetion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Logic.MediaUpload
{
    /// <summary>
    /// 媒体上传类
    /// </summary>
    public class MediaUploadHelper
    {

        /// <summary>
        /// 私有方法，根据类型获取相应的要请求的Url
        /// </summary>
        /// <param name="fileType"></param>
        /// <returns></returns>
        private static string getUploadUrlByType(WxUploadFileType fileType)
        { 
            string accessToken = AccessToken.AccessTokenHelper.TokenModel.Access_Token;
            //string accessToken = "HPzro0z2w2Rc1goLiMUTR3TTCqrtW7yb6KTFcy_muEeVHFS01kdA-eeqWqz62HUyzzeJgp0f8lVm0slyNBAnXFXowES7aJXuB1-HTvvc_AI";
            string type = string.Empty;
            switch (fileType)
            { 
                case Utils.Logic.Enum.WxUploadFileType.UploadFileTypeImage:
                    type = "image";
                    break;
                case Utils.Logic.Enum.WxUploadFileType.UploadFileTypeThumb:
                    type = "thumb";
                    break;
                case Utils.Logic.Enum.WxUploadFileType.UploadFileTypeVideo:
                    type = "video";
                    break;
                case Utils.Logic.Enum.WxUploadFileType.UploadFileTypeVoice:
                    type = "voice";
                    break;
            }
            return string.Format(UploadApi.Upload_Url, accessToken, type);
        }

        /// <summary>
        /// 新增其他类型永久素材(图片（image）、语音（voice）和缩略图（thumb）)
        /// </summary>
        /// <param name="accessTokenOrAppId"></param>
        /// <param name="file">文件路径,需要上传全路径</param>
        /// <param name="timeOut">代理请求超时时间（毫秒）</param>
        /// <returns></returns>
        public static UploadForeverMediaResult UploadForeverMedia(string file, WxUploadFileType fileType, int timeOut = App.AppRequestTimeOut)
        {
            if (fileType == WxUploadFileType.UploadFileTypeVideo) {
                throw new WxException("请使用 UploadForeverVideo 方法上传视频！");
            }
            var url = getUploadUrlByType(fileType);
            var fileDictionary = new Dictionary<string, string>();
            fileDictionary["media"] = file;
            return Post.PostFileGetJson<UploadForeverMediaResult>(url, null, fileDictionary, null, timeOut: timeOut);
        }

        /// <summary>
        /// 上传永久视频素材
        /// </summary>
        /// <param name="file">素材地址</param>
        /// <param name="title">标题</param>
        /// <param name="introduction">描述</param>
        /// <param name="fileType">类型，默认视频</param>
        /// <param name="timeOut">超时</param>
        /// <returns></returns>
        public static UploadForeverMediaResult UploadForeverVideo(string file, string title, string introduction, WxUploadFileType fileType = WxUploadFileType.UploadFileTypeVideo, int timeOut = App.AppRequestTimeOut)
        {
            var url = getUploadUrlByType(fileType);

            var fileDictionary = new Dictionary<string, string>();
            fileDictionary["media"] = file;
            fileDictionary["description"] = string.Format("{{\"title\":\"{0}\", \"introduction\":\"{1}\"}}", title, introduction);

            return Post.PostFileGetJson<UploadForeverMediaResult>(url, null, fileDictionary, null, timeOut: timeOut);
        }

        /// <summary>
        /// 上传图文素材
        /// </summary>
        /// <param name="article">图文素材内容</param>
        /// <returns></returns>
        public static UploadForeverMediaResult UploadForeverNews(UploadNews article)
        {
            return ApiHandlerWapper.TryCommonApi<UploadForeverMediaResult>(accessToken =>
            {
                return CommonSend.Send<UploadForeverMediaResult>(AccessTokenHelper.AccessToken, UploadApi.Upload_NewsUrl, article);

            }, null);
           
        }

    }
}
