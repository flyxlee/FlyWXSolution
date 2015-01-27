using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXService.Entity.Request
{
    public class ReqMsgText : ReqMsgBase
    {
        /// <summary>
        /// 文本消息内容
        /// </summary>
        public string Content { get; set; }

        public ReqMsgText(){}
    }
}
