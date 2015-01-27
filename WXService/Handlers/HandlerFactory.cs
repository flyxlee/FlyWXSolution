using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using WXService.Entity.Request;
using WXService.Entity.Request.Event;
using WXService.Common;

namespace WXService.Handlers
{
    class HandlerFactory
    {
        /// <summary>
        /// 创建处理器
        /// </summary>
        /// <param name="requestXml">请求的xml</param>
        /// <returns>IHandler对象</returns>
        public static IHandler CreateHandler(ReqMsgBase reqMsg)
        {
            IHandler handler = null;
            if (reqMsg != null)
            {

                string msgType = reqMsg.MsgType;

                switch (msgType)
                {
                    case MsgTypeEnum.TEXT:
                        handler = new TextHandler((ReqMsgText)reqMsg);
                        break;
                    case MsgTypeEnum.EVENT:
                        ReqEventBase reqEvent =(ReqEventBase)reqMsg;
                        string eventType = reqEvent.Event;
                        switch (eventType)
                        {
                            case "subscribe":
                                handler = new SubscribeEventHandler((ReqEventSubscribe)reqMsg);
                                break;
                            case "CLICK":
                                handler = new ClickEventHandler((ReqEventClick)reqMsg);
                                break;
                        }
                        break;
                }
            }

            return handler;
        }
    }
}
