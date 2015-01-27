using System;
using System.Text;
using System.Web;
using System.IO;
using System.Net;

namespace WXService.HttpUtility
{
    public class RequestUtility
    {
        /// <summary>
        /// 读取请求对象的内容
        /// 只能读一次
        /// </summary>
        /// <param name="request">HttpRequest对象</param>
        /// <returns>string</returns>
        public static string ReadRequest(HttpRequest request)
        {
            string reqStr = string.Empty;
            using (Stream s = request.InputStream)
            {
                using (StreamReader reader = new StreamReader(s, Encoding.UTF8))
                {
                    reqStr = reader.ReadToEnd();
                }
            }
            return reqStr;
        }

        /// <summary>
        /// 使用Get方法获取字符串结果（没有加入Cookie）
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string HttpGet(string url, Encoding encoding = null)
        {
            WebClient wc = new WebClient();
            wc.Encoding = encoding ?? Encoding.UTF8;
            return wc.DownloadString(url);
        }

        public static string HttpPost(string url, string postData, Encoding encoding = null, CookieContainer cookieContainer = null)
        {
            var postBytes = postData == null ? new byte[0] : Encoding.UTF8.GetBytes(postData);
            //MemoryStream ms = new MemoryStream();
            //ms.Write(postBytes, 0, postBytes.Length);
            //ms.Seek(0, SeekOrigin.Begin);

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postBytes.Length;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.KeepAlive = true;

            if (cookieContainer != null)
            {
                request.CookieContainer = cookieContainer;
            }

            //ms.Position = 0;

            //直接写入流
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(postBytes, 0, postBytes.Length);

            //byte[] buffer = new byte[1024];
            //int bytesRead = 0;
            //while ((bytesRead = ms.Read(buffer, 0, buffer.Length)) != 0)
            //{
            //    requestStream.Write(buffer, 0, bytesRead);
            //}
            //ms.Close();

            requestStream.Close();//关闭文件访问

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (cookieContainer != null)
            {
                response.Cookies = cookieContainer.GetCookies(response.ResponseUri);
            }

            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader myStreamReader = new StreamReader(responseStream, encoding ?? Encoding.GetEncoding("utf-8")))
                {
                    string retString = myStreamReader.ReadToEnd();
                    return retString;
                }
            }
        }

    }
}
