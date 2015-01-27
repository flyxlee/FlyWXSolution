using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using WXService.Common;
using WXService.Entity.Request;

namespace WXService.Entity.Reponse
{
    [XmlRoot(ElementName = "xml")]
    public class ReponseMsgCustomerService : ReponseMsgBase
    {
        public ReponseMsgCustomerService()
        {
            this.MsgType = MsgTypeEnum.Transfer_Customer_Service;
        }

        public ReponseMsgCustomerService(ReqMsgText req) : this()
        {
            this.ToUserName = req.FromUserName;
            this.FromUserName = req.ToUserName;
            
        }
    }
}
