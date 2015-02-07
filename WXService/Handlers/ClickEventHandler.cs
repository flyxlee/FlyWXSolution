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
            ReponseMsgText mt = new ReponseMsgText();
            mt.ToUserName = reqEvent.FromUserName;
            mt.FromUserName = reqEvent.ToUserName;
            if (eventKey.Equals("activity"))
            {
                mt.Content = GetEventValue(eventKey);
                response = mt.ToXml();
            }
            else if (eventKey.Equals("phone"))
            {
                mt.Content = GetEventValue(eventKey);
                response = mt.ToXml();
            }
            else if (eventKey.Equals("online"))
            {
                mt.Content = GetEventValue(eventKey);
                response = mt.ToXml();
            }
            else
            {
                response = GetNews(eventKey);
            }
            return response;
        }

        private string GetNews(string eventKey)
        {
            string news = string.Empty;
            PlanningArticles pa = new PlanningArticles();
            ReponseMsgNews mn = new ReponseMsgNews();
            mn.ToUserName = reqEvent.FromUserName;
            mn.FromUserName = reqEvent.ToUserName;
            switch (eventKey)
            {
                case "birth":
                    mn.Articles = pa.GetBirthArticles();                   
                    break;
                case "marriage":
                    mn.Articles = pa.GetMarriageArticles();
                    break;
                case "planning":
                    mn.Articles = pa.GetPlanningArticles();
                    break;
                case "aids":
                    mn.Articles = pa.GetAidsArticles();
                    break;
                //case "otherPlanning":
                //    mn.Articles = 
                //    break;
                case "oneTwo":
                    mn.Articles = pa.GetOneTwoArticles();
                    break;
                case "cooperative":
                    mn.Articles = pa.GetCooperativeArticles();
                    break;
                case "reward":
                    mn.Articles = pa.GetRewardArticles();
                    break;
                case "law":
                    mn.Articles = pa.GetLawArticles();
                    break;
                //case "activity":
                //    news = pcMsg.GetDefaultMsg();
                //    break;
                //case "phone":
                //    news = pcMsg.getPhoneServiceMsg();
                //    break;
                //case "online":
                //    news = pcMsg.GetDefaultMsg();
                //    break;
                case "characteristic":
                    mn.Articles = pa.GetCharacteristicArticles();
                    break;

            }
            return mn.ToXml();
        }
       

        private string GetEventValue(string eventKey)
        {
            string eventValue = string.Empty;
            PlanningCertificateMsg pcMsg = new PlanningCertificateMsg();
            switch (eventKey)
            {
                //case "birth":
                //    eventValue =  pcMsg.GetBirthList();
                //    break;
                //case "marriage":
                //    eventValue =  pcMsg.GetMarriageList();
                //    break;
                //case "planning":
                //    eventValue =  pcMsg.GetPlanningList();
                //    break;
                //case "aids":
                //    eventValue =  pcMsg.GetAidsList();
                //    break;
                //case "otherPlanning":
                //    eventValue =  pcMsg.getOtherPlanningMsg();
                //    break;
                //case "oneTwo":
                //    eventValue =  pcMsg.getOneTwoList();
                //    break;
                //case "cooperative":
                //    eventValue =  pcMsg.getCooperativeList();
                //    break;
                //case "reward":
                //    eventValue =  pcMsg.getRewardList();
                //    break;
                //case "law":
                //    eventValue =  pcMsg.GetDefaultMsg();
                //    break;
                case "activity":
                    eventValue =  pcMsg.GetDefaultMsg();
                    break;
                case "phone":
                    eventValue =  pcMsg.getPhoneServiceMsg();
                    break;
                case "online":
                    eventValue =  pcMsg.GetDefaultMsg();
                    break;
                //case "characteristic":
                //    eventValue =  pcMsg.GetDefaultMsg();
                //    break;

            }
            return eventValue;
        }
    }
}
