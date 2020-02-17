using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.com.group.Tools
{
    public class Elect
    {
        String getTime()
        {
            String res = DateTime.Now.ToString();
            return res;
        }

        int GetElect(int roomId)
        {
            String currentTime = this.getTime();
            String url = "http://202.116.25.12/login.aspx";
            Dictionary<String, String> getCookie = new Dictionary<string, string>();
            getCookie.Add("__LASTFOCUS","");
            getCookie.Add("__VIEWSTATE", "/wEPDwULLTE5ODQ5MTY3NDlkZM4DISokA1JscbtlCdiUVQMwykIc");
            getCookie.Add("__VIEWSTATEGENERATOR", "C2EE9ABB");
            getCookie.Add("__EVENTTARGET", "");
            getCookie.Add("__EVENTARGUMENT", "");
            getCookie.Add("__EVENTVALIDATION", "/wEWBQLz+M6SBQK4tY3uAgLEhISACwKd+7q4BwKiwImNC7oxDnFDxrZR6l5WlUJDrpGZXrmN");
            getCookie.Add("hidtime", currentTime);
            getCookie.Add("txtname", roomId + "");
            getCookie.Add("txtpwd", "");
            getCookie.Add("ctl01", "");
            String[] header = {
             "Host:202.116.25.12",
             "Connection:keep-alive",
             "Origin:http://202.116.25.12",
             "X-Requested-With:XMLHttpRequest",
             "User-Agent:Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36",
             "Content-Type:application/x-www-form-urlencoded; charset=UTF-8",
             "Accept:*/*",
             "Referer:http://202.116.25.12/default.aspx",
             "Accept-Encoding:gzip, deflate",
             "Accept-Language:en,zh-CN,zh;q=0.8",
            };
            WebRequest request = WebRequest.Create(url);
            request.Method="POST";

            WebResponse response = request.GetResponse();

            return 2;
        }
    }
}
