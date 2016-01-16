using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api.Model
{
    public class RequestErrorResult
    {
       //{"errcode":40001,"errmsg":"invalid credential, access_token is invalid or not latest hint: [ZVz9rA0324vr20]"}

        public int errcode { get; set; }
        public string errmsg { get; set; }
    }

    /// <summary>
    /// 群发消息，会返回一个msgid
    /// </summary>
    public class RequestSendAllResult : RequestErrorResult
    {
        public string msg_id { get; set; }
    }
}
