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
    public class ClickEventHandler:IHandler
    {
         /// <summary>
        /// 请求事件实体
        /// </summary>
        private ReqEventClick  reqEvent { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="requestXml"></param>
        public ClickEventHandler(ReqEventClick reqEvent)
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
            string eventKey = reqEvent.EventKey;
            if (eventKey.Equals("law"))
            {
                ReponseMsgNews mn = new ReponseMsgNews();
                mn.ToUserName = reqEvent.FromUserName;
                mn.FromUserName = reqEvent.ToUserName;
                mn.ArticleCount = 3;
                Article CountryPlanningLaw = new Article();
                CountryPlanningLaw.Title = "中华人民共和国人口与计划生育法";
                CountryPlanningLaw.Url = "http://www.gdwst.gov.cn/a/falvfagui/201002037485.html";
                mn.Articles.Add(CountryPlanningLaw);
                Article CantonPlanningLaw = new Article();
                CantonPlanningLaw.Title = "广东省人口与计划生育条例";
                CantonPlanningLaw.Url = "http://210.76.65.92:9010/pub/rdweb/lfzw/dfxfgxxcx/gdrdcwh/201404/t20140404_141654.html";
                mn.Articles.Add(CantonPlanningLaw);
                Article FlowPlanningLaw = new Article();
                FlowPlanningLaw.Title = "流动人口计划生育工作条例";
                FlowPlanningLaw.Url = "http://www.gov.cn/zhengce/2009-05/20/content_2602541.htm";
                mn.Articles.Add(FlowPlanningLaw);
                response = mn.ToXml();

            }
            else {
                string eventValue = GetEventValue(eventKey);
                ReponseMsgText mt = new ReponseMsgText();
                mt.ToUserName = reqEvent.FromUserName;
                mt.FromUserName = reqEvent.ToUserName;
                mt.Content = eventValue;
                response = mt.ToXml();
            }
            return response;
        }

        private string GetEventValue(string eventKey)
        {
            string eventValue = string.Empty;
            PlanningCertificateMsg pcMsg = new PlanningCertificateMsg();
            switch (eventKey)
            {
                case "birth":
                    eventValue =  pcMsg.GetBirthList();
                    break;
                case "marriage":
                    eventValue =  pcMsg.GetMarriageList();
                    break;
                case "planning":
                    eventValue =  pcMsg.GetPlanningList();
                    break;
                case "aids":
                    eventValue =  pcMsg.GetAidsList();
                    break;
                case "otherPlanning":
                    eventValue =  pcMsg.getOtherPlanningMsg();
                    break;
                case "oneTwo":
                    eventValue =  pcMsg.getOneTwoList();
                    break;
                case "cooperative":
                    eventValue =  pcMsg.getCooperativeList();
                    break;
                case "reward":
                    eventValue =  pcMsg.getRewardList();
                    break;
                case "law":
                    eventValue =  pcMsg.GetDefaultMsg();
                    break;
                case "activity":
                    eventValue =  pcMsg.GetDefaultMsg();
                    break;
                case "phone":
                    eventValue =  pcMsg.getPhoneServiceMsg();
                    break;
                case "online":
                    eventValue =  pcMsg.GetDefaultMsg();
                    break;
                case "characteristic":
                    eventValue =  pcMsg.GetDefaultMsg();
                    break;

            }
            return eventValue;
        }
    }
}
