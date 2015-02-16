using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.Entity.Reponse;

namespace WXService.Message
{
    public class PlanningArticles
    {
        private string serverUrl = "http://spjs.chinacloudsites.cn/static/";
        /// <summary>
        /// 办理生育服务证
        /// </summary>
        /// <returns></returns>
        public List<Article> GetBirthArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "办理一胎生育审核登记程序";
            articleOne.Url = serverUrl+"11OneBaby.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDn8zDicZXicJnFedghbWoq8PiaK7YxDqn02xcMVmK5d4tzBGGOLKqRYqLQ/0";
            Articles.Add(articleOne);
            Article articleTwo = new Article();
            articleTwo.Title = "办理再生育审批登记程序";
            articleTwo.Url = serverUrl+"12ReBirth.html";
            articleTwo.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDiaYicicibfnRGHd7xUatEU72BxUo44H4Tiaq13FoNs5jAYhQEHdhYyHQZVw/0";
            Articles.Add(articleTwo);
            Article articleThree = new Article();
            articleThree.Title = "领取或补领《计划生育服务证》";
            articleThree.Url = serverUrl+"13PlanBirth.html";
            articleThree.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDL1YN2H2iaTrNGvBvEGLmaTUXVL8psiaNib0KRTseUg61ibNVwY3XDZicGiaQ/0";
            Articles.Add(articleThree);
            return Articles;
        }

        /// <summary>
        /// 流动人口婚育证明
        /// </summary>
        /// <returns></returns>
        public List<Article> GetMarriageArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "沙坪户籍未婚者办理《流动人口婚育证明》";
            articleOne.Url = serverUrl+"21FlowWebBirth.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDfUy4ODe0bsYia0gWPKwLn7lPXJQoRuu43NdvlAbs0wNY57R0H7VIS4g/0";
            Articles.Add(articleOne);
            Article articleTwo = new Article();
            articleTwo.Title = "沙坪户籍已婚者办理《流动人口婚育证明》";
            articleTwo.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mD75meZOZh1jhL2n4zMjm3t3x3fs8BHayx0zCERd8QNIa4xr7jOFRh4Q/0";
            articleTwo.Url = serverUrl+"22MarriedWebBirth.html";
            Articles.Add(articleTwo);
            Article articleThree = new Article();
            articleThree.Title = "外来流动人口办理《流动人口婚育证明》";
            articleThree.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mD75meZOZh1jhL2n4zMjm3t3x3fs8BHayx0zCERd8QNIa4xr7jOFRh4Q/0";
            articleThree.Url = serverUrl+"23FloatingPopulationWebBirth.html";
            Articles.Add(articleThree);
            return Articles;
        }



        /// <summary>
        /// 办理各类计生证明
        /// </summary>
        /// <returns></returns>
        public List<Article> GetPlanningArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "沙坪户籍人口办理计生证明";
            articleOne.Url = serverUrl+"31EveryPlanProve.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDDVK7fX9SvWqKQFYPjRenaODia1NhENJFkl50wDrjq8RW8adiaI0brSLQ/0";
            Articles.Add(articleOne);
            Article articleTwo = new Article();
            articleTwo.Title = "广东省内流动人口办理计生证明";
            articleTwo.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDoZyZdXgmK1OfQ8bfbHToXOIuXfb54uJe8P1xYiaURXN09QKltrWuaAw/0";
            articleTwo.Url = serverUrl+"32InProvinceFloatingPopulationPaln.html";
            Articles.Add(articleTwo);
            Article articleThree = new Article();
            articleThree.Title = "广东省外流动人口办理计生证明";
            articleThree.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDqYU3nJGoG5PdghzTd9lIHRRk3jM5DVpZQWNCoSUkPNnrs7lK2pSmTg/0";
            articleThree.Url = serverUrl+"33FloatingPopulationPaln.html";
            Articles.Add(articleThree);
            Article articleFour = new Article();
            articleFour.Title = "办理《独生子女父母光荣证》程序";
            articleFour.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDqneJH0CNrtCRSEsne5oxwqwU3EWZFyPJWQxF92SkicicamFMgHwib6iaqQ/0";
            articleFour.Url = serverUrl+"34OneChildParents.html";
            Articles.Add(articleFour);
            return Articles;
        }

        /// <summary>
        /// 计划生育奖励/扶助申领
        /// </summary>
        /// <returns></returns>
        public List<Article> GetAidsArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "农村计划生育家庭奖励金申领";
            articleOne.Url = serverUrl+"41CountryFamilyBonus.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDYia24lFebmWPiaDo2iaMZVrKiaaxw8lVdDTiaBq8d4uAzkooojuMJiaCjicicw/0";
            Articles.Add(articleOne);
            Article articleTwo = new Article();
            articleTwo.Title = "农村计划生育节育奖励金申领";
            articleTwo.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDYOdgDUOKRRxW6mP4uIOkc767cjZm0NCeI9kHnwHqSKicibPFzAR3DgDQ/0";
            articleTwo.Url = serverUrl+"42CountryPlanBonus.html";
            Articles.Add(articleTwo);
            Article articleThree = new Article();
            articleThree.Title = "城镇独生子女父母计划生育奖励金申领";
            articleThree.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mD9Koz8EODJcWwa5zhj4q7e9mgFicsz90wk7csd5pfuL1ePRYSNAEFpUw/0";
            articleThree.Url = serverUrl+"43CityParentPlanBonus.html";
            Articles.Add(articleThree);
            Article articleFour = new Article();
            articleFour.Title = "计划生育家庭特别扶助金申领";
            articleFour.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDUamUNB3ibcHDHpL0GtpGvWNc0Zf4xns3TsH1uylGDCTJ8dQCwWlmsZA/0";
            articleFour.Url = serverUrl+"44PlanFamilySpecialBonus.html";
            Articles.Add(articleFour);
            return Articles;
        }

        /// <summary>
        /// 单独两孩政策
        /// </summary>
        /// <returns></returns>
        public List<Article> GetOneTwoArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "“单独两孩”的实施时间及独生子女的界定";
            articleOne.Url = serverUrl+"51DefinitionOnlyChild.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDsgPkicRDMNiaG0u8aIRaYpLaVcSGEZicicLOEhXeOM3aicmdFZ5m7HDsgxg/0";
            Articles.Add(articleOne);
            Article articleTwo = new Article();
            articleTwo.Title = "“单独两孩”的衔接";
            articleTwo.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3MvHDtfemkyMEaql5iaSUqt9g9QSV4PAVXL5sp8TbKreNrqic1L9cr8gmok5bJmx4oxJ7kJd6IQn9dQ/0";
            articleTwo.Url = serverUrl+"52OnlyTowChildJoin.html";
            Articles.Add(articleTwo);
            Article articleThree = new Article();
            articleThree.Title = "单独再婚夫妇的生育政策";
            articleThree.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDtBQ9akFQrFXB51DafaHyQoDpfuRoZ5MDiav4zXfOyZZ9ib40jFXq6BdA/0";
            articleThree.Url = serverUrl+"53MarriedAgainBirth.html";
            Articles.Add(articleThree);
            Article articleFour = new Article();
            articleFour.Title = "“单独两孩”再生育的申请和审批流程";
            articleFour.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDrFTBjkgQSdoFOWrP00vOONE7R4eoSbBt5eX48b0QichvR7xFDLEZ22g/0";
            articleFour.Url = serverUrl+"54MarriedAgainBirthApproval.html";
            Articles.Add(articleFour);
            return Articles;
        }

        /// <summary>
        /// 农村合作医疗
        /// </summary>
        /// <returns></returns>
        public List<Article> GetCooperativeArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "农村合作医疗申请对象条件";
            articleOne.Url = serverUrl+"61RuralCooperativeApplication.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mD7YgZT5NrUVMD94mz6kadN1jUOuOQmOwicVh1LdW2PTVqhkyZZlrK9VA/0";
            Articles.Add(articleOne);
            Article articleTwo = new Article();
            articleTwo.Title = "农村合作医疗申请资料";
            articleTwo.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDg3zdvb9WLYPAy1wXagJThcwXSXfspsdh9sUtABsD7ceKNNvXCGNqmg/0";
            articleTwo.Url = serverUrl+"62RuralCooperativeAppliedData.html";
            Articles.Add(articleTwo);
            Article articleThree = new Article();
            articleThree.Title = "农村合作医疗办理程序";
            articleThree.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDrFTBjkgQSdoFOWrP00vOONE7R4eoSbBt5eX48b0QichvR7xFDLEZ22g/0";
            articleThree.Url = serverUrl+"63RuralCooperativeGoThrough.html";
            Articles.Add(articleThree);
            return Articles;
        }

        /// <summary>
        /// 农村计划生育奖励/扶助
        /// </summary>
        /// <returns></returns>
        public List<Article> GetRewardArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "农村计划生育家庭奖励";
            articleOne.Url = serverUrl+"71RuralFamilyPlanningReward.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDWkcdtjmgnlWunSZ7R4nuZ9vjhaIqy8rmhibqItohWt5PpRjckWb9siaQ/0";
            Articles.Add(articleOne);
            Article articleTwo = new Article();
            articleTwo.Title = "“农村计划生育节育奖励";
            articleTwo.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mD0x37M6DUicX5Gjrp0yg2Jtkibjq1KJTmHyicEHFNGCNcpFNgAm9PH9DKQ/0";
            articleTwo.Url = serverUrl+"72RuralPlanningBirthControlReward.html";
            Articles.Add(articleTwo);
            Article articleThree = new Article();
            articleThree.Title = "独生子女计划生育奖励";
            articleThree.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDDwhQUO6Q9pHDGtMBXyDA9lp21vjzFJnKKicMcFa45F2tOxuJILxtFmA/0";
            articleThree.Url = serverUrl+"73TownFamilyPlanningReward.html";
            Articles.Add(articleThree);
            Article articleFour = new Article();
            articleFour.Title = "计划生育家庭特别扶助金";
            articleFour.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PnIbiaS1iciapMHvdecoQj7mDuOiauLmLhXAhglkGoA2ZWzQeYZsye6WKejhMVwfvccTY8DBh2E50fdA/0";
            articleFour.Url = serverUrl+"74FamilyPlanningSpecialAssistance.html";
            Articles.Add(articleFour);
            return Articles;
        }

        /// <summary>
        /// 政策法规
        /// </summary>
        /// <returns></returns>
        public List<Article> GetLawArticles()
        {
            List<Article> Articles = new List<Article>();
            Article CountryPlanningLaw = new Article();
            CountryPlanningLaw.Title = "中华人民共和国人口与计划生育法";
            CountryPlanningLaw.Url = "http://www.gdwst.gov.cn/a/falvfagui/201002037485.html";
            CountryPlanningLaw.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3MvHDtfemkyMEaql5iaSUqt99qO75SCQBCCQ96NTx9aeOIJhVibdAqpibbfgq5YPw66uk68o89b6icdCA/0";
            Articles.Add(CountryPlanningLaw);
            Article CantonPlanningLaw = new Article();
            CantonPlanningLaw.Title = "广东省人口与计划生育条例";
            CantonPlanningLaw.Url = serverUrl+"CantonPlanningLaw.html";
            CantonPlanningLaw.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PLCNr6mJx8tO9JehdrgpSA5AxfTwmKiad5IDq6Vv2vD1lMSUtYAvyQ4r4wnBhiaBFOib0mUc0u8z88Q/0";
            Articles.Add(CantonPlanningLaw);
            Article FlowPlanningLaw = new Article();
            FlowPlanningLaw.Title = "流动人口计划生育工作条例";
            FlowPlanningLaw.Url = "http://www.gov.cn/zhengce/2009-05/20/content_2602541.htm";
            FlowPlanningLaw.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PLCNr6mJx8tO9JehdrgpSACt5OtlCwtB0mWIwljYEZicsmV2N7k6yicqLr3YjzbuIJn2JN1LcCNEicg/0";
            Articles.Add(FlowPlanningLaw);
            return Articles;

        }


        /// <summary>
        /// 保健卫生知识
        /// </summary>
        /// <returns></returns>
        public List<Article> GetHealthArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "H7N9禽流感病毒";
            articleOne.Url = serverUrl + "H7N9.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PE6b0aqU8icJn9nzdxNt0FyIedgfs89CD2CBKxZdTwJaz2KqdcmU7e6qqcN6oD5L61oiae4nO7fia6A/0";
            Articles.Add(articleOne);
            Article articleTwo = new Article();
            articleTwo.Title = "诺如病毒性肠胃炎";
            articleTwo.Url = serverUrl + "NorwalkViruses.html";
            articleTwo.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PE6b0aqU8icJn9nzdxNt0FyRgzFtUicib3ria9LTaEOUB4E47IiaibcHIqXXgKcSaYTzyFcsgiaj8oJPqyA/0";
            Articles.Add(articleTwo);
            Article articleThree = new Article();
            articleThree.Title = "健康教育处方1";
            articleThree.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PfCvHjuJ0mcHPLbMj3WtRe1kBzPdHusjxorXtys9GQnpqkYfOPCbiaUa013oOPSEhsNmeCskb7icug/0";
            articleThree.Url = serverUrl + "HealthEducation1.html";
            Articles.Add(articleThree);
            Article articleFour = new Article();
            articleFour.Title = "健康教育处方2";
            articleFour.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PfCvHjuJ0mcHPLbMj3WtRe6ga1hhmicRZLWnO4sqbId01q9XG59N8ffjGOU0XacE26m1pvtdGYzYQ/0";
            articleFour.Url = serverUrl + "HealthEducation2.html";
            Articles.Add(articleFour);
            Article articleFive = new Article();
            articleFive.Title = "健康教育处方3";
            articleFive.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PfCvHjuJ0mcHPLbMj3WtReSZkRaXffKKsKSqrSkJYg8vibPJ4Heb21iby4cQAfm7s0t8FCPz25cXIA/0";
            articleFive.Url = serverUrl + "HealthEducation3.html";
            Articles.Add(articleFive);
            return Articles;
        }

        /// <summary>
        /// 特色工作
        /// </summary>
        /// <returns></returns>
        public List<Article> GetCharacteristicArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "鹤山市沙坪街道东升社区积极创建省级群众自治示范居";
            articleOne.Url = serverUrl + "AutonomousDemonstration.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3OXdo1zgzUQJZChahHMpcAxKBvvibv7KB53aGcnVEnykPBmeoWE05ibFtOZn1yI3mgV2yCrqkogp6WQ/0";
            articleOne.Description = "东升社区人口计生工作一直走在街道的前列，连续多年政策生育率都达到95%以上。在沙坪街道办的支持下，东升社区共投入20多万元新建了人口文化园，建造了以“倡导文明生育观、促进家庭和谐幸福”为主题的一家三口雕塑，从特具人口文化底藴的人文雕塑到篮球场，从健身器材到悠闲小径，从独树一格的计生宣传牌到石椅，处处都渗透着健康文明幸福的生活理念……";
            Articles.Add(articleOne);
            return Articles;
        }

        /// <summary>
        /// 通知通告
        /// </summary>
        /// <returns></returns>
        public List<Article> GetActivityArticles()
        {
            List<Article> Articles = new List<Article>();
            Article articleOne = new Article();
            articleOne.Title = "B超检查通知";
            articleOne.Url = serverUrl + "BUltrasound.html";
            articleOne.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PfCvHjuJ0mcHPLbMj3WtRe7bYEPmw8uwJ11icSGicLSgyhQU8IR2RIJaRj50W85ib8B9smRgsyABib8w/0";
            Articles.Add(articleOne);
            Article articleTwo = new Article();
            articleTwo.Title = "致外来工朋友的一封信";
            articleTwo.Url = serverUrl + "MigrantWorker.html";
            articleTwo.PicUrl = "https://mmbiz.qlogo.cn/mmbiz/WQN53PGdv3PfCvHjuJ0mcHPLbMj3WtReXe2wULYANb0MzQU0uBK0WArz7vNZyvq2gAHia3H8ZuOsax0c9XWzvtQ/0";
            Articles.Add(articleTwo);
            return Articles;
        }
        
    }
}
