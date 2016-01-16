using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macrosage.Wx.Config.Api.Model
{
    public class TemplateMessage
    {
        public string touser { get; set; }
        public string template_id { get; set; }
        public string url { get; set; }
        public string topcorlor { get; set; }
        public virtual object data { get; set; }
    }
}
