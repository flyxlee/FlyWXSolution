using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using WXService.Common;

namespace WXService.Entity.Reponse
{
    [XmlRoot(ElementName = "xml")]
    public class ReponseMsgNews : ReponseMsgBase
    {
        public ReponseMsgNews()
        {
            this.MsgType = MsgTypeEnum.NEWS;
            this.Articles = new List<Article>();
        }
        /// <summary>
        /// 图文消息个数，限制为10条以内
        /// </summary>
        [XmlIgnore]
        public int ArticleCount { get; set; }

        [XmlElement("ArticleCount")]
        public XmlNode ArticleCountXmlNode
        {
            get
            {
                return new XmlDocument().CreateCDataSection(this.ArticleCount.ToString());
            }
            set { }
        }

        /// <summary>
        /// 图文列表。
        /// 多条图文消息信息，默认第一个item为大图,注意，如果图文数超过10，则将会无响应
        /// </summary>
        [System.Xml.Serialization.XmlArrayItem("item")]
        public List<Article> Articles { get; set; }
    }
}
