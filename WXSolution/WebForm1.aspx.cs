using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WXService.Helper;
using WXService.Entity.Reponse;
using WXService.Entity.Request;
using WXService.Factory;
using System.Xml.Linq;
using WXService.Handlers;
using WXService;

namespace WXSolution
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //RepMsgText tm = new RepMsgText();
            //tm.ToUserName = "ToUserName";
            //tm.FromUserName = "ToUserName";
            //tm.CreateTime = DateTimeHelper.GetNowTime();
            //tm.Content = "欢迎您关注沙坪人口公众微信号，更多功能正在开发中！";
            string xml = " <xml><ToUserName><![CDATA[toUser]]></ToUserName><FromUserName><![CDATA[fromUser]]></FromUserName> <CreateTime>1348831860</CreateTime>"+
            "<MsgType><![CDATA[text]]></MsgType><Content><![CDATA[this is a test]]></Content><MsgId>1234567890123456</MsgId></xml>";
            ReqMsgBase reqMsg = ReqMsgFactory.GetReqMsgEntity(XDocument.Parse(xml));
            WeiXinService wxs = new WeiXinService();
            this.label2.Text = wxs.ResponseMsg(reqMsg);
        }
    }
}