﻿using System;
using System.Text;

namespace WXService.Common
{
    public class CommonEnum
    {
        /// <summary>
        /// 加密签名
        /// </summary>
        public const string SIGNATURE = "signature";
        /// <summary>
        /// 时间戳
        /// </summary>
        public const string TIMESTAMP = "timestamp";
        /// <summary>
        /// 随机数
        /// </summary>
        public const string NONCE = "nonce";
        /// <summary>
        /// 随机字符串
        /// </summary>
        public const string ECHOSTR = "echostr";

        /// <summary>
        /// 发送人
        /// </summary>
        public const string FROM_USERNAME = "FromUserName";
        /// <summary>
        /// 开发者微信号
        /// </summary>
        public const string TO_USERNAME = "ToUserName";
        /// <summary>
        /// 消息内容
        /// </summary>
        public const string CONTENT = "Content";
        /// <summary>
        /// 消息创建时间 （整型）
        /// </summary>
        public const string CREATE_TIME = "CreateTime";
        /// <summary>
        /// 消息类型
        /// </summary>
        public const string MSG_TYPE = "MsgType";
        /// <summary>
        /// 消息id，64位整型
        /// </summary>
        public const string MSG_ID = "MsgId";

        public const string EVENT_KEY = "EventKey";

        public const string EVENT_TYPE = "Event";

    }

    public class MsgTypeEnum
    {
        public const string TEXT = "text";

        public const string IMAGE = "image";

        public const string VOICE = "voice";

        public const string VIDEO = "video";

        public const string MUSIC = "music";

        public const string NEWS = "news";

        public const string EVENT = "event";

        public const string Transfer_Customer_Service = "transfer_customer_service";
    }

    public class ButtonType
    {
        public const string CLICK = "click";

        public const string VIEW = "view"; 
    }

    /// <summary>
    /// 返回码（JSON）
    /// </summary>
    public enum ReturnCode
    {
        系统繁忙 = -1,
        请求成功 = 0,
        验证失败 = 40001,
        不合法的凭证类型 = 40002,
        不合法的OpenID = 40003,
        不合法的媒体文件类型 = 40004,
        不合法的文件类型 = 40005,
        不合法的文件大小 = 40006,
        不合法的媒体文件id = 40007,
        不合法的消息类型 = 40008,
        不合法的图片文件大小 = 40009,
        不合法的语音文件大小 = 40010,
        不合法的视频文件大小 = 40011,
        不合法的缩略图文件大小 = 40012,
        不合法的APPID = 40013,
        //不合法的access_token      =             40014,
        不合法的access_token = 40014,
        不合法的菜单类型 = 40015,
        //不合法的按钮个数             =          40016,
        //不合法的按钮个数              =         40017,
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
        缺少access_token参数 = 41001,
        缺少appid参数 = 41002,
        缺少refresh_token参数 = 41003,
        缺少secret参数 = 41004,
        缺少多媒体文件数据 = 41005,
        缺少media_id参数 = 41006,
        缺少子菜单数据 = 41007,
        access_token超时 = 42001,
        需要GET请求 = 43001,
        需要POST请求 = 43002,
        需要HTTPS请求 = 43003,
        多媒体文件为空 = 44001,
        POST的数据包为空 = 44002,
        图文消息内容为空 = 44003,
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
        不存在媒体数据 = 46001,
        不存在的菜单版本 = 46002,
        不存在的菜单数据 = 46003,
        解析JSON_XML内容错误 = 47001,
        api功能未授权 = 48001,
        用户未授权该api = 50001,

        //新加入的一些类型，以下文字根据P2P项目格式组织，非官方文字
        发送消息失败_48小时内用户未互动 = 10706,
        发送消息失败_该用户已被加入黑名单_无法向此发送消息 = 62751,
        发送消息失败_对方关闭了接收消息 = 10703,
        对方不是粉丝 = 10700
    }
}
