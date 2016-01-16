﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz.Weixin.Utils.Logic.Enum
{
    /// <summary>
    /// 微信消息返回代码
    /// </summary>
    public enum WxRequestCode
    {
        RequestCode_Busy = -1,//服务器繁忙，请稍候在试
        RequestCode_Success = 0,//请求成功
        RequestCode_WrongSecretOrAccessToken = 40001,//错误的appSecret或者accesstoken
        RequestCode_IllegalOpenId = 40003,//不合法的openid
        RequestCode_IllegalAppId = 40013,//不合法的appId
        RequestCode_IllegalAccessToken = 40014,//不合法的accesstoken
        RequestCode_NeedHttpGet = 43001,
        RequestCode_NeedHttpPost = 43002,
        RequestCode_NeedHttps = 43003,
        RequestCode_NeedParamAccessToken = 41001,
        RequestCode_NeedParamAppId = 41002,
        RequestCode_NeedParamRefreshToken = 41003,
        RequestCode_NeedParamAppSecret = 41004,
        RequestCode_NeedParamMediaData = 41005,
        RequestCode_NeedParamMediaId = 41006,
        RequestCode_NeedParamChildMenuData = 41007,
        RequestCode_NeedParamOauthCode = 41008,
        RequestCode_NeedParamOpenId = 41009,
        RequestCode_IllegalCertifyType = 40002,
        RequestCode_IllegalMediaFileType=40004,

        RequestCode_IllegalFileType = 40005,

        RequestCode_IllegalFileSize = 40006,

        RequestCode_IllegalMediaFileId = 40007,

        RequestCode_IllegalMessageType = 40008,

        RequestCode_IllegalImageFileSize = 40009,

        RequestCode_IllegalVoiceFileSize = 40010,

        RequestCode_IllegalVideoFileSize = 40011,

        RequestCode_IllegalThumbImageFileSize = 40012,
        
        不合法的菜单类型 = 40015,
        
        不合法的按钮个数1 = 40016,
        
        不合法的按钮个数2 = 40017,
        
        不合法的按钮名字长度 = 40018,
        
        不合法的按钮KEY长度 = 40019,
        
        不合法的按钮URL长度 = 40020,
        
        不合法的菜单版本号 = 40021,
        
        不合法的子菜单级数 = 40022,
        
        不合法的子菜单按钮个数 = 40023,
        
        不合法的子菜单按钮类型 = 40024,
        
        不合法的子菜单按钮名字长度 = 40025,
        
        不合法的子菜单按钮KEY长度 = 40026,
        
        不合法的子菜单按钮URL长度 = 40027,
        
        不合法的自定义菜单使用用户 = 40028,
        
        不合法的oauth_code = 40029,
       
        不合法的refresh_token = 40030,
        
        不合法的openid列表 = 40031,
       
        不合法的openid列表长度 = 40032,
        
        不合法的请求字符不能包含uxxxx格式的字符 = 40033,
       
        不合法的参数 = 40035,
       
        不合法的请求格式 = 40038,
        
        不合法的URL长度 = 40039,
        
        不合法的分组id = 40050,
       
        分组名字不合法 = 40051,
        access_token超时 = 42001,
       
        refresh_token超时 = 42002,
       
        oauth_code超时 = 42003,
        需要接收者关注 = 43004,
       
        需要好友关系 = 43005,
      
        多媒体文件为空 = 44001,
       
        POST的数据包为空 = 44002,
        
        图文消息内容为空 = 44003,
        
        文本消息内容为空 = 44004,
        
        多媒体文件大小超过限制 = 45001,
        
        消息内容超过限制 = 45002,
        
        标题字段超过限制 = 45003,
       
        描述字段超过限制 = 45004,
        
        链接字段超过限制 = 45005,
        
        图片链接字段超过限制 = 45006,
       
        语音播放时间超过限制 = 45007,
        
        图文消息超过限制 = 45008,
        
        接口调用超过限制 = 45009,
        
        创建菜单个数超过限制 = 45010,
       
        回复时间超过限制 = 45015,
        
        系统分组不允许修改 = 45016,
        
        分组名字过长 = 45017,
        
        分组数量超过上限 = 45018,
        
        不存在媒体数据 = 46001,
        
        不存在的菜单版本 = 46002,
        
        不存在的菜单数据 = 46003,
        
        解析JSON_XML内容错误 = 47001,
       
        api功能未授权 = 48001,
       
        用户未授权该api = 50001,
        
        参数错误invalid_parameter = 61451,
        
        无效客服账号invalid_kf_account = 61452,
       
        客服帐号已存在kf_account_exsited = 61453,
        /// <summary>
        /// 客服帐号名长度超过限制(仅允许10个英文字符，不包括@及@后的公众号的微信号)(invalid kf_acount length) 
        /// </summary>
        客服帐号名长度超过限制 = 61454,
        /// <summary>
        /// 客服帐号名包含非法字符(仅允许英文+数字)(illegal character in kf_account) 
        /// </summary>
        客服帐号名包含非法字符 = 61455,
        /// <summary>
        ///  	客服帐号个数超过限制(10个客服账号)(kf_account count exceeded) 
        /// </summary>
        客服帐号个数超过限制 = 61456,
        
        无效头像文件类型invalid_file_type = 61457,
       
        系统错误system_error = 61450,
        
        日期格式错误 = 61500,
       
        日期范围错误 = 61501,

        //新加入的一些类型，以下文字根据P2P项目格式组织，非官方文字
        发送消息失败_48小时内用户未互动 = 10706,
        
        发送消息失败_该用户已被加入黑名单_无法向此发送消息 = 62751,
        
        发送消息失败_对方关闭了接收消息 = 10703,
       
        对方不是粉丝 = 10700


    }

    /// <summary>
    /// 微信请求方式
    /// </summary>
    public enum WxRequestType
    { 
        //GET请求
        RequestTypeGet,
        //POST请求
        RequestTypePost
    }

    public enum WxUploadFileType
    {
        // iamge图像,voice语音,video视频,thumb缩略图
        UploadFileTypeVoice = 1,
        UploadFileTypeVideo = 2,
        UploadFileTypeThumb = 3,
        UploadFileTypeImage = 4
    }
}
