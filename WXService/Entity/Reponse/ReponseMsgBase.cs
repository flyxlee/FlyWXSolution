using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using WXService.Helper;

namespace WXService.Entity.Reponse
{
    [XmlRoot(ElementName = "xml")]
    public class ReponseMsgBase
    {
        /// <summary>
        /// 接收方账号
        /// </summary>
        [XmlIgnore]
        public string ToUserName { get; set; }

         /// <summary>
        /// 发送方帐号
        /// </summary>
        [XmlIgnore]
        public string FromUserName { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlIgnore]
        public string MsgType { get;  set; }

        [XmlElement("ToUserName")]
        public XmlNode ToUserNameXmlNode
        {
            get
            {
                return new XmlDocument().CreateCDataSection(this.ToUserName);
            }
            set { }
        }

        [XmlElement("FromUserName")]
        public XmlNode FromUserNameXmlNode
        {
            get
            {
                return new XmlDocument().CreateCDataSection(this.FromUserName);
            }
            set { }
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }

        [XmlElement("MsgType")]
        public XmlNode MsgTypeXmlNode
        {
            get
            {
                return new XmlDocument().CreateCDataSection(this.MsgType);
            }
            set { }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public ReponseMsgBase()
        { }

        public virtual string ToXml()
        {
            this.CreateTime = DateTimeHelper.GetNowTime();
            return EntityXmlHelper.ConvertEntityToXml(this);
        }
    }
}
