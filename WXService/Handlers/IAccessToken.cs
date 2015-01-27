using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WXService.Handlers
{
    public interface IAccessToken
    {
        /// 获取凭证接口
        /// </summary>
        /// <param name="appid">第三方用户唯一凭证</param>
        /// <param name="secret">第三方用户唯一凭证密钥，既appsecret</param>
       string GetAccessToken(string appid, string secret);
    }
}
