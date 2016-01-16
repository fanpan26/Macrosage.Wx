using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api.Model.Result
{
    public class CreateGroupResult
    {
        public UserGroup group { get; set; } 
    }

    /// <summary>
    /// 获取某个用户所在的组 结果
    /// </summary>
    public class GetUserGroupResult
    {
        public int groupid { get; set; }
    }
}
