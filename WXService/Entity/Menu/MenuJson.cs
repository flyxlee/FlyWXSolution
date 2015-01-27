using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WXService.Entity.Menu
{
    /// <summary>
    /// 菜单的Json字符串对象
    /// </summary>
    public class MenuJson
    {
        public List<MenuInfo> button { get; set; }

        public MenuJson()
        {
            button = new List<MenuInfo>();
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    /// <summary>
    /// 菜单列表的Json对象
    /// </summary>
    public class MenuListJson
    {
        public MenuJson menu { get; set; }
    }
}
