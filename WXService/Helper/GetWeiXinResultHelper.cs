using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.Entity.ReturnCode;

namespace WXService.Helper
{
    public class GetWeiXinResultHelper
    {
        public static ErrJson GetExecuteResult(string url, string postData = null)
        {
            ErrJson result = new ErrJson();
            try
            {
                if (postData != null)
                {
                    result = JsonHelper<ErrJson>.ConvertJson(url, postData);
                }
                else
                {
                    result = JsonHelper<ErrJson>.ConvertJson(url);
                }
            }
            catch (Exception e)
            {
                result.errmsg = e.ToString();
            }
            return result;
        }
    }
}
