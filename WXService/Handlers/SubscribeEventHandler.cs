using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.Entity.Request.Event;
using WXService.Entity.Reponse;
using WXService.Helper;
using WXService.Message;

namespace WXService.Handlers
{
    class SubscribeEventHandler:IHandler
    {
         /// <summary>
        /// 请求事件实体
        /// </summary>
        private ReqEventBase reqEvent { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="requestXml"></param>
        public SubscribeEventHandler(ReqEventBase reqEvent)
        {
            this.reqEvent = reqEvent;
        }
        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        public string HandleRequest()
        {
            string response = string.Empty;

            //回复欢迎消息
            ReponseMsgText mt = new ReponseMsgText();
            mt.ToUserName = reqEvent.FromUserName;
            mt.FromUserName = reqEvent.ToUserName;
            //mt.CreateTime = DateTimeHelper.GetNowTime();
            //mt.MsgType = MsgTypeEnum.TEXT;
            PlanningCertificateMsg pcMsg = new PlanningCertificateMsg();
            mt.Content = pcMsg.GetAttentionMsg();
            response = mt.ToXml();
            return response;
        }
    }
}
