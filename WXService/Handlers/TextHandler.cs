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
            ReponseMsgText mt = new ReponseMsgText();
            string content = reqMsg.Content.Trim();
            if (string.IsNullOrEmpty(content))
            {
                PlanningCertificateMsg pcMsg = new PlanningCertificateMsg();
                response =  pcMsg.GetDefaultMsg();
            }
            else
            {
                response = HandleOther(content);
            }
            mt.Content = response;
            //进行发送者、接收者转换
            mt.ToUserName = reqMsg.FromUserName;
            mt.FromUserName = reqMsg.ToUserName;
            //mt.MsgType = CommonEnum.TEXT;
            response = mt.ToXml();
            return response;
        }
        /// <summary>
        /// 处理其他消息
        /// </summary>
        /// <param name="mt"></param>
        /// <returns></returns>
        private string HandleOther(string requestContent)
        {
            string response = string.Empty;
            PlanningCertificateMsg pcMsg = new PlanningCertificateMsg();
            if (requestContent.EndsWith("11"))
            {
                response =  pcMsg.GetOneBabyMsg();
            }
            else if (requestContent.EndsWith("12"))
            {
                response =  pcMsg.GetReBirthMsg();
            }
            else if (requestContent.EndsWith("13"))
            {
                response =  pcMsg.GetPlanBirthMsg();
            }
            else if (requestContent.EndsWith("21"))
            {
                response =  pcMsg.GetFlowWebBirthMsg();
            }
            else if (requestContent.EndsWith("22"))
            {
                response =  pcMsg.GetMarriedWebBirthMsg();
            }
            else if (requestContent.EndsWith("23"))
            {
                response =  pcMsg.GetFloatingPopulationWebBirthMsg();
            }
            else if (requestContent.EndsWith("31"))
            {
                response =  pcMsg.GetEveryPlanProveMsg();
            }
            else if (requestContent.EndsWith("32"))
            {
                response = pcMsg.GetInProvinceFloatingPopulationPalnMsg();
            }
            else if (requestContent.EndsWith("33"))
            {
                response = pcMsg.GetFloatingPopulationPalnMsg();
            }
            else if (requestContent.ToLower().EndsWith("34"))
            {
                response = pcMsg.GetOneChildParentsMsg();
            }
            else if (requestContent.ToLower().EndsWith("41"))
            {
                response = pcMsg.GetCountryFamilyBonusMsg();
            }
            else if (requestContent.ToLower().EndsWith("42"))
            {
                response = pcMsg.GetCountryPlanBonusMsg();
            }
            else if (requestContent.ToLower().EndsWith("43"))
            {
                response = pcMsg.GetCityParentPlanBonusMsg();
            }
            else if (requestContent.ToLower().EndsWith("44"))
            {
                response = pcMsg.GetPlanFamilySpecialBonusMsg();
            }
            else if (requestContent.ToLower().EndsWith("51"))
            {
                response = pcMsg.getDefinitionOnlyChildMsg();
            }
            else if (requestContent.ToLower().EndsWith("52"))
            {
                response = pcMsg.getOnlyTowChildJoinMsg();
            }
            else if (requestContent.ToLower().EndsWith("53"))
            {
                response = pcMsg.getMarriedAgainBirthMsg();
            }
            else if (requestContent.ToLower().EndsWith("54"))
            {
                response = pcMsg.getMarriedAgainBirthApprovalMsg();
            }
            else if (requestContent.ToLower().EndsWith("61"))
            {
                response = pcMsg.getRuralCooperativeApplicationMsg();
            }
            else if (requestContent.ToLower().EndsWith("62"))
            {
                response = pcMsg.getRuralCooperativeAppliedDataMsg();
            }
            else if (requestContent.ToLower().EndsWith("63"))
            {
                response = pcMsg.GetDefaultMsg();
            }
            else if (requestContent.ToLower().EndsWith("71"))
            {
                response = pcMsg.getRuralFamilyPlanningRewardMsg();
            }
            else if (requestContent.ToLower().EndsWith("72"))
            {
                response = pcMsg.getRuralPlanningBirthControlRewardMsg();
            }
            else if (requestContent.ToLower().EndsWith("73"))
            {
                response = pcMsg.getTownFamilyPlanningRewardMsg();
            }
            else if (requestContent.ToLower().EndsWith("74"))
            {
                response = pcMsg.getFamilyPlanningSpecialAssistanceMsg();
            }
            else
            {
                response =  pcMsg.GetDefaultMsg();
            }

            return response;
        }


    }
}
