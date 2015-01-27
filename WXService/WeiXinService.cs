using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml.Linq;
using WXService.Handlers;
using WXService.Common;
using WXService.Entity.Request;
using WXService.Factory;
using WXService.HttpUtility;

namespace WXService
{
    public class WeiXinService
    {
        private HttpRequest request { get; set; }

        public WeiXinService() { }

        public WeiXinService(HttpRequest request)
        {
            this.request = request;
        }

        public string Execute()
        {
            if (request.HttpMethod.ToUpper().Equals("GET"))
            {
                string signature = request.QueryString[CommonEnum.SIGNATURE];
                string timestamp = request.QueryString[CommonEnum.TIMESTAMP];
                string nonce = request.QueryString[CommonEnum.NONCE];
                if (CheckSignature.Check(signature, timestamp, nonce))
                {
                    return HttpContext.Current.Request.QueryString[CommonEnum.ECHOSTR];
                }
                else
                {
                    return string.Empty;
                }

            }
            else
            {
                string requestXml = RequestUtility.ReadRequest(request);
                ReqMsgBase reqMsg = ReqMsgFactory.GetReqMsgEntity(XDocument.Parse(requestXml));
                return ResponseMsg(reqMsg);
            }
        }




        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        public string ResponseMsg(ReqMsgBase reqMsg)
        {
            IHandler handler = HandlerFactory.CreateHandler(reqMsg);
            if (handler != null)
            {
                return handler.HandleRequest();
            }

            return string.Empty;
        }
    }
}
