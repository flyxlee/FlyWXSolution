using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.Entity.Menu;
using Newtonsoft.Json;
using WXService.Helper;
using WXService.HttpUtility;
using WXService.Entity.ReturnCode;

namespace WXService.Handlers
{
    public class MenuApi : IMenuApi
    {
        public MenuJson GetMenu(string accessToken)
        {
            MenuJson menu = null;

            var url = string.Format("https://api.weixin.qq.com/cgi-bin/menu/get?access_token={0}", accessToken);
            MenuListJson list = JsonHelper<MenuListJson>.ConvertJson(url);
            if (list != null) 
            {
                menu = list.menu;
            }
            return menu;
        }

        public ErrJson CreateMenu(string accessToken, MenuJson menuJson)
        {
            var url = string.Format("https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}", accessToken);
            string postData = menuJson.ToJson();

            return GetWeiXinResultHelper.GetExecuteResult(url, postData);
        }

        public ErrJson DeleteMenu(string accessToken)
        {
            var url = string.Format("https://api.weixin.qq.com/cgi-bin/menu/delete?access_token={0}", accessToken);
            return GetWeiXinResultHelper.GetExecuteResult(url);
        }
    }
}
