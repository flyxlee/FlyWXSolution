using System;
using System.Web;
using System.Configuration;
using System.IO;
using System.Text;
using System.Web.Security;
using WXService;

namespace WXSolution
{
    /// <summary>
    /// index 的摘要说明
    /// </summary>
    public class index : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            WeiXinService wxs = new WeiXinService(context.Request);
            string responseMsg = wxs.Execute();
            context.Response.Clear();
            context.Response.Charset = "UTF-8";
            context.Response.Write(responseMsg);
            context.Response.End();
        }


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}