using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.Entity.Reponse;
using WXService.Entity.Request;
using WXService.Message;
using WXService.Common;

namespace WXService.Handlers
{
    class TextHandler : IHandler
    {
        /// <summary>
        /// 请求的消息实体
        /// </summary>
        private ReqMsgText reqMsg { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="requestXml">请求的xml</param>
        public TextHandler(ReqMsgText reqMsg)
        {
            this.reqMsg = reqMsg;
        }
        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        public string HandleRequest()
        {
            string response = string.Empty;
            string content = reqMsg.Content.Trim();
            if (string.IsNullOrEmpty(content))
            {
                PlanningCertificateMsg pcMsg = new PlanningCertificateMsg();                
                ReponseMsgText mt = new ReponseMsgText();
                mt.ToUserName = reqMsg.FromUserName;
                mt.FromUserName = reqMsg.ToUserName;
                mt.Content = pcMsg.GetDefaultMsg();
                response = mt.ToXml();
            }
            else if (content.ToUpper().Equals("LY"))
            {
                ReponseMsgCustomerService mcs = new ReponseMsgCustomerService(reqMsg);
                response = mcs.ToXml();
            }
            else
            {
                response = HandleOther(content);
            }         
            return response;
        }
        /// <summary>
        /// 处理消息
        /// </summary>
        /// <param name="mt"></param>
        /// <returns></returns>
        private string HandleOther(string requestContent)
        {
            string responseContent = string.Empty;
            ReponseMsgText mt = new ReponseMsgText();
            
            //进行发送者、接收者转换
            mt.ToUserName = reqMsg.FromUserName;
            mt.FromUserName = reqMsg.ToUserName;
            PlanningCertificateMsg pcMsg = new PlanningCertificateMsg();
            if (requestContent.EndsWith("11"))
            {
                responseContent =  pcMsg.GetOneBabyMsg();
            }
            else if (requestContent.EndsWith("12"))
            {
                responseContent =  pcMsg.GetReBirthMsg();
            }
            else if (requestContent.EndsWith("13"))
            {
                responseContent =  pcMsg.GetPlanBirthMsg();
            }
            else if (requestContent.EndsWith("21"))
            {
                responseContent =  pcMsg.GetFlowWebBirthMsg();
            }
            else if (requestContent.EndsWith("22"))
            {
                responseContent =  pcMsg.GetMarriedWebBirthMsg();
            }
            else if (requestContent.EndsWith("23"))
            {
                responseContent =  pcMsg.GetFloatingPopulationWebBirthMsg();
            }
            else if (requestContent.EndsWith("31"))
            {
                responseContent =  pcMsg.GetEveryPlanProveMsg();
            }
            else if (requestContent.EndsWith("32"))
            {
                responseContent = pcMsg.GetInProvinceFloatingPopulationPalnMsg();
            }
            else if (requestContent.EndsWith("33"))
            {
                responseContent = pcMsg.GetFloatingPopulationPalnMsg();
            }
            else if (requestContent.ToLower().EndsWith("34"))
            {
                responseContent = pcMsg.GetOneChildParentsMsg();
            }
            else if (requestContent.ToLower().EndsWith("41"))
            {
                responseContent = pcMsg.GetCountryFamilyBonusMsg();
            }
            else if (requestContent.ToLower().EndsWith("42"))
            {
                responseContent = pcMsg.GetCountryPlanBonusMsg();
            }
            else if (requestContent.ToLower().EndsWith("43"))
            {
                responseContent = pcMsg.GetCityParentPlanBonusMsg();
            }
            else if (requestContent.ToLower().EndsWith("44"))
            {
                responseContent = pcMsg.GetPlanFamilySpecialBonusMsg();
            }
            else if (requestContent.ToLower().EndsWith("51"))
            {
                responseContent = pcMsg.getDefinitionOnlyChildMsg();
            }
            else if (requestContent.ToLower().EndsWith("52"))
            {
                responseContent = pcMsg.getOnlyTowChildJoinMsg();
            }
            else if (requestContent.ToLower().EndsWith("53"))
            {
                responseContent = pcMsg.getMarriedAgainBirthMsg();
            }
            else if (requestContent.ToLower().EndsWith("54"))
            {
                responseContent = pcMsg.getMarriedAgainBirthApprovalMsg();
            }
            else if (requestContent.ToLower().EndsWith("61"))
            {
                responseContent = pcMsg.getRuralCooperativeApplicationMsg();
            }
            else if (requestContent.ToLower().EndsWith("62"))
            {
                responseContent = pcMsg.getRuralCooperativeAppliedDataMsg();
            }
            else if (requestContent.ToLower().EndsWith("63"))
            {
                responseContent = pcMsg.getRuralCooperativeGoThroughMsg();
            }
            else if (requestContent.ToLower().EndsWith("71"))
            {
                responseContent = pcMsg.getRuralFamilyPlanningRewardMsg();
            }
            else if (requestContent.ToLower().EndsWith("72"))
            {
                responseContent = pcMsg.getRuralPlanningBirthControlRewardMsg();
            }
            else if (requestContent.ToLower().EndsWith("73"))
            {
                responseContent = pcMsg.getTownFamilyPlanningRewardMsg();
            }
            else if (requestContent.ToLower().EndsWith("74"))
            {
                responseContent = pcMsg.getFamilyPlanningSpecialAssistanceMsg();
            }
            else
            {
                responseContent =  pcMsg.GetDefaultMsg();
            }
            mt.Content = responseContent;
            string response = mt.ToXml();
            return response;
        }


    }
}
