using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.Entity.Menu;
using WXService.Entity.ReturnCode;

namespace WXService.Handlers
{
    public interface IMenuApi
    {
        /// <summary>
        /// 获取菜单数据
        /// </summary>
        /// <param name="accessToken">调用接口凭证</param>
        /// <returns></returns>
        MenuJson GetMenu(string accessToken);

        /// <summary>
        /// 创建菜单
        /// </summary>
        /// <param name="accessToken">调用接口凭证</param>
        /// <param name="menuJson">菜单对象</param>
        /// <returns></returns>
        ErrJson CreateMenu(string accessToken, MenuJson menuJson);

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="accessToken">调用接口凭证</param>
        /// <returns></returns>
        ErrJson DeleteMenu(string accessToken);
    }
}
