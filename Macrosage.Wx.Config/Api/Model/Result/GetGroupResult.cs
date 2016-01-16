using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api.Model.Result
{
    [Serializable]
    public class GetGroupResult
    {
       public List<GroupResultDetail> groups { get; set; }
    }

    [Serializable]
    public class GroupResultDetail : UserGroup
    {
        public int count { get; set; }
    }
}
