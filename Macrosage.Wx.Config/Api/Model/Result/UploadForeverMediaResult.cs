using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api.Model
{
    /*
     * {"type":"thumb","thumb_media_id":"1Q22HJnq-csLnj6FHkl5GPqV6Ll4ieGihtNtdRU9PSWBs1mj7IsswxMYyPVDqUFe","created_at":1445847395}
     * {"type":"image","media_id":"HJzrTTXc-91sUBauniNcUamkvZhDD6ub0NBht9WaNJ7uWSaNbg80PoYT1qFWOp4g","created_at":1445847395}
     */
    public class UploadForeverMediaResult
    {
        /// <summary>
        /// 上传文件的类型
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 缩略图id
        /// </summary>
        public string thumb_media_id { get; set; }
        /// <summary>
        /// 上传的图片id
        /// </summary>
        public string media_id { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public int created_at { get; set; }
    }
}
