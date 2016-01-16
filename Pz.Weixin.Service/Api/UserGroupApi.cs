using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api
{
    /*
    * create 2015-10-27
    * author:fyp
    * 获取用户组的API，包括创建，查询
    */
    public class UserGroupApi
    {
        /// <summary>
        /// 创建group  
        /// </summary>
        public const string CreateGroup_Url = "https://api.weixin.qq.com/cgi-bin/groups/create?access_token={0}";

        /// <summary>
        /// 获取当前用户（微信公众号）的所有组
        /// </summary>
        public const string GetGroups_Url = "https://api.weixin.qq.com/cgi-bin/groups/get?access_token={0}";

        /// <summary>
        /// 查询某个用户的所在组
        /// </summary>
        public const string GetUserInGroup_Url = "https://api.weixin.qq.com/cgi-bin/groups/getid?access_token={0}";
        /// <summary>
        /// 更新某个组名
        /// group  id =100 name="新的组名"
        /// </summary>
        public const string UpdateGroup_Url = "https://api.weixin.qq.com/cgi-bin/groups/update?access_token={0}";

        /// <summary>
        /// 移动某个用户去某个组
        /// openid  to_groupid
        /// </summary>
        public const string MoveUserToAnotherGroup_Url = "https://api.weixin.qq.com/cgi-bin/groups/members/update?access_token={0}";
    }
}
