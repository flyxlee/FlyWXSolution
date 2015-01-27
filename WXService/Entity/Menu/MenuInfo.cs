using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using WXService.Common;

namespace WXService.Entity.Menu
{
    public class MenuInfo
    {
        public string name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string key { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<MenuInfo> sub_button { get; set; }

        public MenuInfo() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="buttonType"></param>
        /// <param name="value"></param>
        public MenuInfo(string name,string buttonType,string value)
        {
            this.name = name;
            this.type = buttonType;
            if (buttonType.Equals(ButtonType.CLICK))
            {
                this.key = value;
            }
            else if (buttonType.Equals(ButtonType.VIEW))
            {
                this.url = value;
            }
        }

        public MenuInfo(string name, IEnumerable<MenuInfo> sub_button)
        {
            this.name = name;
            this.sub_button = new List<MenuInfo>();
            this.sub_button.AddRange(sub_button);
        }
    }
}
