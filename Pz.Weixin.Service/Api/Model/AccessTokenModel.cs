using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Config.Api.Model
{
    /*
     *  AccessToken模型，
     * {"access_token":"Vk3CRNrMDlcuH-jKzTCJaVZuxfsNFb-wtLa16g4D3hMWMIS6ZNA69hhhiayDmVfrZ7MHr3rI2nXFYT-WUSEHiZEtaH2YqQFd_KUhS9yG1qA","expires_in":7200}
     */
    public class AccessTokenModel
    {
        public AccessTokenModel(string accessToken,int expiresIn)
        {
            _accessToken = accessToken;
            _expiresIn = expiresIn;
            _createTime = DateTime.Now;
        }

        private string _accessToken;
        private int _expiresIn;
        private DateTime _createTime;
        public DateTime CreateTime { get { return _createTime; } }
        public string Access_Token { get { return _accessToken; } set { _accessToken = value; } }
        public int Expires_In { get { return _expiresIn; } set { _expiresIn = value; } }

        /// <summary>
        /// 是否过期，根据返回的过期时间和当前时间对比，过期了就重新请求一个新的
        /// </summary>
        public bool TimeOut
        {
            get
            {
                TimeSpan ts = DateTime.Now - this._createTime;
                return ts.TotalSeconds > this._expiresIn;
            }
        }
    }
}
