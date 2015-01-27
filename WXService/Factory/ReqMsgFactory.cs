using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.Entity.Request;
using System.Xml.Linq;
using WXService.Entity.Request.Event;
using WXService.Helper;
using WXService.Common;

namespace WXService.Factory
{
    public class ReqMsgFactory
    {
        public static ReqMsgBase GetReqMsgEntity(XDocument doc)
        {
            ReqMsgBase reqMsg = null;
            string msgType = doc.Root.Element(CommonEnum.MSG_TYPE).Value;
            switch (msgType)
            {
                case MsgTypeEnum.TEXT:
                    reqMsg = new ReqMsgText();
                    break;
                case MsgTypeEnum.EVENT:
                    string eventType = doc.Root.Element(CommonEnum.EVENT_TYPE).Value;
                    switch (eventType)
                    {
                       case "subscribe":
                           reqMsg = new ReqEventSubscribe();
                           break;
                       case "CLICK":
                           reqMsg = new ReqEventClick();
                           break;
                    }
                    break;
            }
            EntityXmlHelper.FillEntityWithXml(reqMsg,doc);
            return reqMsg;
        }
    }
}
