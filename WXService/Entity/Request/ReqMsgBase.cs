using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXService.Entity.Request
{
    public class ReqMsgBase
    {
         /// <summary>
        /// 发送方帐号
        /// </summary>
        public string FromUserName { get; set; }

        /// <summary>
        /// 接收方账号
        /// </summary>
        public string ToUserName { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public string MsgType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        public string MsgId { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ReqMsgBase()
        { }
    }
}
