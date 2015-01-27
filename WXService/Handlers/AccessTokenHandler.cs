using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.Helper;
using WXService.HttpUtility;
using WXService.Entity.ReturnCode;

namespace WXService.Handlers
{
    public class AccessTokenHandler : IAccessToken
    {
        public string GetAccessToken(string appid, string secret)
        {
            //正常情况下access_token有效期为7200秒,这里使用缓存设置短于这个时间即可
            string access_token = MemoryCacheHelper.GetCacheItem<string>("access_token", delegate()
            {
                string grant_type = "client_credential";
                var url = string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type={0}&appid={1}&secret={2}",
                                        grant_type, appid, secret);

                string result = RequestUtility.HttpGet(url);
                string token = string.Empty;
                if (result.Contains("access_token"))
                {
                   AccessTokenInfo at = JsonHelper<AccessTokenInfo>.ConvertObjJson(result);
                   token = at.access_token;
                }         
                return token;
            },
                new TimeSpan(0, 0, 7000)//7000秒过期
            );

            return access_token;
        }
    }
}
