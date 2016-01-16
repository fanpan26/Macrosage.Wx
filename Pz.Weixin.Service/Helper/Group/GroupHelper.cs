using Pz.Weixin.Config.Api;
using Pz.Weixin.Config.Api.Model;
using Pz.Weixin.Config.Api.Model.Result;
using Pz.Weixin.Utils.Common.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Logic.Group
{
    /*
    * create 2015-10-27
    * author:fyp
    * 用户组的帮助类，创建组，查询组
    */
    public class GroupHelper
    {
        #region 添加用户分组
        /// <summary>
        /// 添加组
        /// </summary>
        /// <param name="groupName">组名</param>
        /// <returns>返回添加结果</returns>
        public static CreateGroupResult CreateUserGroup(string groupName)
        {
           return AccessToken.ApiHandlerWapper.TryCommonApi<CreateGroupResult>(accessToken =>
           {
               CreateGroup data = new CreateGroup
               {
                   group = new UserGroup
                   {
                       name = groupName
                   }
               };
               // var data = new { group = group };
               return CommonSend.Send<CreateGroupResult>(AccessToken.AccessTokenHelper.AccessToken, UserGroupApi.CreateGroup_Url, data);
           });
        }
        #endregion

        #region 获取当前用户分组 所有
        /// <summary>
        /// 获取用户的当前分组数据
        /// </summary>
        /// <returns></returns>
        public static GetGroupResult GetGroups()
        {
            return CommonSend.Send<GetGroupResult>(AccessToken.AccessTokenHelper.AccessToken, UserGroupApi.GetGroups_Url, null, Utils.Logic.Enum.WxRequestType.RequestTypeGet);
        }
        #endregion

        #region 获取某个用户当前所在的组
        public static GetUserGroupResult GetUserGroupByOpenId(string openId)
        {
            return AccessToken.ApiHandlerWapper.TryCommonApi<GetUserGroupResult>(accessToken =>
            {
                var data = new
                {
                    openid = openId
                };
                return CommonSend.Send<GetUserGroupResult>(accessToken, UserGroupApi.GetUserInGroup_Url, data);
            });

        }
        #endregion

        #region 修改分组名
        /// <summary>
        /// 根据分组id，新的分组名称修改分组名
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="newGroupName"></param>
        /// <returns></returns>
        public RequestErrorResult UpdateGroupName(int groupId, string newGroupName)
        {
            return AccessToken.ApiHandlerWapper.TryCommonApi<RequestErrorResult>(accessToken =>
            {
                CreateGroup updateGroup = new CreateGroup
                {
                    group = new UserGroup
                    {
                        id = groupId,
                        name = newGroupName
                    }
                };

                return CommonSend.Send<RequestErrorResult>(accessToken, UserGroupApi.UpdateGroup_Url, updateGroup);
            });
        }
        #endregion

        #region 移动用户分组

        /// <summary>
        /// 讲某个用户移动到某个组
        /// </summary>
        /// <param name="openId">用户的openid</param>
        /// <param name="to_groupid">将要移动的组id</param>
        /// <returns></returns>
        public static RequestErrorResult MoveUserToAnogherGroup(string openId, int to_groupid)
        {
            return AccessToken.ApiHandlerWapper.TryCommonApi<RequestErrorResult>(accessToken =>
           {
               var data = new
               {
                   openid = openId,
                   to_groupid = to_groupid
               };
               return CommonSend.Send<RequestErrorResult>(accessToken, UserGroupApi.MoveUserToAnotherGroup_Url, data);
           });
        }
        #endregion



    }
}
