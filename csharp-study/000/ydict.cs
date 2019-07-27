using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Collections;
using System.Collections.Generic;

namespace YDict_cmd
{
    class TranslateResult
    {
        string translate;
        string query;
        string errorCode;
        List<string> web;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var translate_result = YouDaoTranslateTool("cool boy");
            Console.WriteLine(translate_result);
        }

        /// <summary>
        /// 调用：http://fanyi.youdao.com/openapi.do?keyfrom=sasfasdfasf&key=1177596287&type=data&doctype=json&version=1.1&q=中国人
        /// 返回的json格式如下：
        /// {"translation":["The Chinese"],"basic":{"phonetic":"zhōng guó rén","explains":["Chinese","Chinaman","Chinese people","Chinee","chow"]}
        ///  * ,"query":"中国人","errorCode":0,"web":[{"value":["Chinaren","Chinese people","The Chinese","Chinese person"],"key":"中国人"},
        ///  * {"value":["中国人"],"key":"中国人"},{"value":["CHINA LIFE","LFC","china life insurance","YZC"],"key":"中国人寿"},{"value":["Human Rights in China","HRIC"],"key":"中国人权"},
        ///  * {"value":["China Life Insurance Company","China Life Insurance","China Life","China Life Insurance Co Ltd"],"key":"中国人寿保险"},
        ///  * {"value":["Chinese name","Chinese Names in English","Courtesy Name"],"key":"中国人名"},{"value":["Chinese Names"],"key":"中国人的名字"},
        ///  * {"value":["CJOL"],"key":"中国人才热线"},{"value":["American Born Chinese"],"key":"美生中国人"},{"value":["Chinese Characteristics"],"key":"中国人德行"}]}*/
        /// </summary>
        private static string YouDaoTranslateTool(string sourceWord)
        {
            var proxy = new WebProxy("10.191.131.15", 3128)
            {
                Credentials = new NetworkCredential("F3216338", "samsung00s"),
                BypassProxyOnLocal = true
            };

            string serverUrl = string.Format("{0}{1}", 
                @"http://fanyi.youdao.com/openapi.do?keyfrom=sasfasdfasf&key=1177596287&type=data&doctype=json&version=1.1&q=",
                HttpUtility.UrlEncode(sourceWord)
            );
            
            WebRequest request = WebRequest.Create(serverUrl);
            request.Proxy = proxy;
            
            WebResponse response = request.GetResponse();
            string resJson = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
            //int textIndex = resJson.IndexOf("translation") + 15;
            //int textLen = resJson.IndexOf("\"]", textIndex) - textIndex;
            //return resJson.Substring(textIndex, textLen);
            return resJson;
        }
    }
}
