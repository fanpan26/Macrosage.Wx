using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api.Model
{
    /// <summary>
    /// 用户组
    /// </summary>
   public class UserGroup
    {
       public string name { get; set; }
       public int id { get; set; }
    }
    /// <summary>
    /// post 数据添加用户组
    /// </summary>
   public class CreateGroup
   {
       public UserGroup group { get; set; }
   }
}
