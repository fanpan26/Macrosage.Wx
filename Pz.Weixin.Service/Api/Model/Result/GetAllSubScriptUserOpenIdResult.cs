using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api.Model.Result
{

    /*
        * create 2015-10-27
        * author:fyp
        * 获取所有关注微信公众号的openid
        */
    public class GetAllSubScriptUserOpenIdResult
    {
        public int total { get; set;}
        public int count { get; set; }
        public OpenIdList data { get; set; }
        public string next_openid { get; set; }
    }

    public class OpenIdList
    {
        public List<string> openid { get; set; }
    }
}
