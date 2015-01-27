using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WXService.HttpUtility;
using Newtonsoft.Json;

namespace WXService.Helper
{
    public class JsonHelper<T>
    {
        public static T ConvertJson(string url)
        {
            string content = RequestUtility.HttpGet(url);
            T result = JsonConvert.DeserializeObject<T>(content);
            return result;
        }

        public static T ConvertJson(string url, string postData)
        {
            string content = RequestUtility.HttpPost(url, postData);

            T result = JsonConvert.DeserializeObject<T>(content);
            return result;
        }

        public static T ConvertObjJson(string obj)
        {
            T result = JsonConvert.DeserializeObject<T>(obj);
            return result;
        }
    }
}
