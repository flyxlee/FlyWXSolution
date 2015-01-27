using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace WXService.Entity.Reponse
{
    [XmlRoot(ElementName = "xml")]
    public class Article
    {
        /// <summary>
        /// 图文消息标题
        /// </summary>
        [XmlIgnore]
        public String Title { get; set; }

        [XmlElement("Title")]
        public XmlNode TitleXmlNode
        {
            get
            {
                return new XmlDocument().CreateCDataSection(this.Title);
            }
            set { }
        }

        /// <summary>
        /// 图文消息描述
        /// </summary>
        [XmlIgnore]
        public String Description { get; set; }

        [XmlElement("Description")]
        public XmlNode DescriptionXmlNode
        {
            get
            {
                return new XmlDocument().CreateCDataSection(this.Description);
            }
            set { }
        }

        /// <summary>
        /// 图片链接，支持JPG、PNG格式，较好的效果为大图360*200，小图200*200
        /// </summary>
        [XmlIgnore]
        public String PicUrl { get; set; }

        [XmlElement("PicUrl")]
        public XmlNode PicUrlXmlNode
        {
            get
            {
                return new XmlDocument().CreateCDataSection(this.PicUrl);
            }
            set { }
        }

        /// <summary>
        /// 点击图文消息跳转链接
        /// </summary>
        [XmlIgnore]
        public String Url { get; set; }

        [XmlElement("Url")]
        public XmlNode UrlXmlNode
        {
            get
            {
                return new XmlDocument().CreateCDataSection(this.Url);
            }
            set { }
        }
    }
}
