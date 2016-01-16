
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pz.Weixin.Test.Controllers
{
    public class WxController : Controller
    {
        /*
         微信测试
         */
        // GET: Wx
        public ActionResult Index()
        {
            string path = "/Content/wxtest.png";
            
            //测试上传缩略图，测试成功
           // var result = MediaUploadHelper.UploadForeverMedia(@HttpContext.Server.MapPath(path), Utils.Logic.Enum.WxUploadFileType.UploadFileTypeThumb);
           
            //测试上传图片，测试成功
            //var result1 = MediaUploadHelper.UploadForeverMedia(@HttpContext.Server.MapPath(path), Utils.Logic.Enum.WxUploadFileType.UploadFileTypeImage);


            //上传文章素材，成功  mlZu5lflRASHTXamOcZvVaM67WllXXZTAiQ0s-LRysLNeL3c1VrbQP-GJnlo0CbB 测试成功
            //var result = MediaUploadHelper.UploadForeverNews(new UploadNews
            //{
            //    articles = new List<Article> { 
            //         new Article{
            //          author="小盘子",
            //          content="内容测试", 
            //          content_source_url="http://acad.rucslhr.gurucv.com/share/space?cv=0", 
            //          digest="描述啦啦啦啦", 
            //          thumb_media_id="L3EPzsZ5bu00RNV0QR6P9vxorI460ApEZZfJVLMFJT0FFu8hdVQJujrB01ZkNm5X",
            //          title="这是测试标题吧"
            //         }
            //    }
            //});

            //获取用户的基础信息 测试成功
            /*
             * {"subscribe":1,"openid":"o7s-WuEoqMxwIADOUIe8mkCZVi2Y",
             * "nickname":"余晶莹",
             * "sex":1,
             * "language":"zh_CN",
             * "city":"东城",
             * "province":"北京",
             * "country":"中国",
             * "headimgurl":"http:\/\/wx.qlogo.cn\/mmopen\/PiajxSqBRaEJ2ZECkDvreSHEiakBg4sdjME2S5XArZYiaB5b292BdkiaXkib1jEOB2Um9IMgUujaG5T32KJaU3a9q6Q\/0",
             * "subscribe_time":1445083700,"remark":"","groupid":0}
             */
            //var result = UserHelper.GetUserInfo("o7s-WuEoqMxwIADOUIe8mkCZVi2Y");

            //获取用户的所有分组 测试成功
            /*
             * {"groups":[{"id":0,"name":"未分组","count":1235},{"id":1,"name":"黑名单","count":0},{"id":2,"name":"星标组","count":0},{"id":100,"name":"后台管理组","count":10}]}
             */
            //var result = GroupHelper.GetGroups();

            //获取当前用户所在的组 测试通过
            //var result = GroupHelper.GetUserGroupByOpenId("o7s-WuEoqMxwIADOUIe8mkCZVi2Y");
            
            //获取所有关注微信公众号的openid 测试通过
            //var result = UserHelper.GetAllUserOpenIds();
            return View();
        }
    }
}