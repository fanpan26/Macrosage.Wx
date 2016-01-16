using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api
{
    /*
     * create 2015-10-27
     * 用户信息接口
     * accesstoken 调用凭证
     * openid 用户的微信关注所生成的Id
     * lang 默认zh_CN简体中文
     * 返回的用户json
     * nickname昵称，sex性别，city城市，country国家，province省份，language语言，headimageurl用户头像，subscribe_time关注时间
     */
    public class UserInfoApi
    {
        public const string GetUserInfo_Url = "https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}&lang=zh_CN";

        /// <summary>
        /// 获取关注列表 的openid，next_openid,暂时不传
        /// </summary>
        public const string GetSubscriptUserOpenIdsAll_Url = "https://api.weixin.qq.com/cgi-bin/user/get?access_token={0}&next_openid=";
        /// <summary>
        /// 分页查询openid
        /// </summary>
        public const string GetSubscriptUserOpenIdsByNext_Url = "https://api.weixin.qq.com/cgi-bin/user/get?access_token={0}&next_openid={1}";
    }
}
