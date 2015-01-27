using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXService.Handlers
{
    interface IHandler
    {
        /// <summary>
        /// 处理请求
        /// </summary>
        /// <returns></returns>
        string HandleRequest();
    }
}
