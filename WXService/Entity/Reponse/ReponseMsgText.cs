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
    public class ReponseMsgText : ReponseMsgBase
    {
        public ReponseMsgText()
        {
            this.MsgType = MsgTypeEnum.TEXT;
        }
        /// <summary>
        /// 内容
        /// </summary>
        [XmlIgnore]
        public string Content { get; set; }

        [XmlElement("Content")]
        public XmlNode ContentXmlNode
        {
            get
            {
                return new XmlDocument().CreateCDataSection(this.Content);
            }
            set { }
        }
    }
}
