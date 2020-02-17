import urllib.request as ur
import urllib.parse
import http.cookiejar
import chardet
import requests
import re
from PIL import Image


class GetCourseInfo2(object):
    def __init__(self, UserId, Pw):
        self.LoginUrl = "https://jwxt.jnu.edu.cn/Login.aspx"
        self.Course_url = "https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_Xk_PyfaCx.aspx"
        self.UserId = UserId
        self.Pw = Pw
        self.LoginVE = dict()
        self.CookieText = self.getCookieText()

        vrifyCodeUrl = "https://jwxt.jnu.edu.cn/ValidateCode.aspx"
        file = ur.urlopen(vrifyCodeUrl)
        pic = file.read()
        path = 'vcode.png'
        localpic = open(path, 'wb')
        localpic.write(pic)
        localpic.close()
        # image = Image.open(path)
        # print("输入验证码:")
        # image.show()
        self.vCode = input()
        self.LoginCookie = self.getLoginCookie()

    def getCookieText(self):
        viewstatepart = re.compile(r'id="__VIEWSTATE"\s*value="(.*)"\s/>')
        eventvalidationpart = re.compile(r'id="__EVENTVALIDATION"\s*value="(.*)"\s/>')
        html = requests.get(self.LoginUrl).text
        self.LoginVE['VIEWSTATE'] = viewstatepart.findall(html)[0]
        self.LoginVE['EVENTVALIDATION'] = eventvalidationpart.findall(html)[0]
        cj = http.cookiejar.LWPCookieJar()
        cookie_support = ur.HTTPCookieProcessor(cj)
        opener = ur.build_opener(cookie_support)
        ur.install_opener(opener)

        hostOpen = ur.urlopen(self.LoginUrl)

        cookieText = ''
        for item in cj:
            cookieText = cookieText + item.name + '=' + item.value + '&'
        cookieText = cookieText[0:-1]
        return cookieText

    def getLoginCookie(self):
        # data = {
        #     "__VIEWSTATE": "/wEPDwUKMjA1ODgwODUwMg9kFgJmD2QWAgIBDw8WAh4EVGV4dAUk5pqo5Y2X5aSn5a2m57u85ZCI5pWZ5Yqh566h55CG57O757ufZGRk9KoyGrj1hrb/xZF6g8lZ2QQ9do4=",
        #     "__VIEWSTATEGENERATOR": "C2EE9ABB",
        #     "__EVENTVALIDATION": "/wEWBwLR44D1DQKDnbD2DALVp9zJDAKi+6bHDgKC3IeGDAKt86PwBQLv3aq9B47pXW7QJikyEA9+7Kos193HV3sp",
        #     "txtYHBS": str(self.UserId),
        #     "txtYHMM": str(self.Pw),
        #     "txtFJM": str(self.vCode),
        #     "btnLogin": "登    录",
        # }
        data = {
            "__VIEWSTATE": self.LoginVE['VIEWSTATE'],
            "__VIEWSTATEGENERATOR": "C2EE9ABB",
            "__EVENTVALIDATION": self.LoginVE['EVENTVALIDATION'],
            "txtYHBS": str(self.UserId),
            "txtYHMM": str(self.Pw),
            "txtFJM": str(self.vCode),
            "btnLogin": "登    录",
        }
        data = urllib.parse.urlencode(data)
        headers = {
            "accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3",
            "accept-encoding": "gzip, deflate, br",
            "accept-language": "zh-CN,zh;q=0.9",
            "cache-control": "max-age=0",
            "content-length": str(len(data)),
            "content-type": "application/x-www-form-urlencoded",
            "cookie": str(self.CookieText),
            "origin": "https://jwxt.jnu.edu.cn",
            "referer": "https://jwxt.jnu.edu.cn/Login.aspx",
            "upgrade-insecure-requests": "1",
            "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
        }
        s = requests.Session()
        r = s.post(url=self.LoginUrl, headers=headers, data=data.encode('GB2312'))
        cookie = r.headers.get("set-cookie")
        # print(r.content.decode('GB2312'))
        # print(cookie)
        return cookie

    def GetCourseTable(self):
        headers = {
            "accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3",
            "accpet-encoing": "gzip, deflate, br",
            "accpet-language": "zh-CN,zh;q=0.9",
            "cache-control": "max-age=0",
            "cookie": self.CookieText,
            "upgrade-insecure-requests": "1",
            "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36",
            "Connection": "keep-alive"
        }
        r = requests.get(url=self.Course_url, headers=headers)
        encode_type = chardet.detect(r.content)
        content = r.content.decode(encode_type['encoding'])
        part = re.compile(r'<td>(.*)</td><td>(\d{8})</td><td>(.*)</td><td>(\d\.\d\d)</td><td>(\d*\.\d)</td><td>(.*)</td><td>(.*)</td><td>(.*)</td>')
        result = part.findall(content)
        pagepart = re.compile(r'<a href="javascript:__doPostBack\(\'grdvJhkc\',\'Page\$(\d)\'\)">\d</a></td>\s*</tr>')
        pageNo = pagepart.findall(content)
        viewstatepart = re.compile(r'id="__VIEWSTATE"\s*value="(.*)"\s/>')
        eventvalidationpart = re.compile(r'id="__EVENTVALIDATION"\s*value="(.*)"\s/>')
        # print("网页源代码：")
        # print(content)

        userInfo = self.getUserInfo(content)
        postdata = {
            "__EVENTTARGET": "grdvJhkc",
            "__EVENTARGUMENT": "",
            "__VIEWSTATE": "",
            "__VIEWSTATEGENERATOR": "78ACC0FA",
            "__EVENTVALIDATION": "",
            "txtNjL": userInfo["txtNjL"],
            "txtJdL": userInfo["txtJdL"],
            "txtXzL": userInfo["txtXzL"],
            "txtZsdxL": userInfo["txtZsdxL"],
            "txtZyfxL": userInfo["txtZyfxL"],
            "txtXyL": userInfo["txtXyL"],
            "txtXxlbL": userInfo["txtXxlbL"],
            "txtZyL": userInfo["txtZyL"],
            "txtPyccL": userInfo["txtPyccL"],
            "hidZx": userInfo["hidZx"],
            "hidXh": userInfo["hidXh"],
            "txtXiaoQu": userInfo["txtXiaoQu"]
        }
        postheaders = {
            "accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3",
            "accept-encoding": "gzip, deflate, br",
            "accept-language": "zh-CN,zh;q=0.9",
            "cache-control": "max-age=0",
            "content-length": "",
            "content-type": "application/x-www-form-urlencoded",
            "cookie": str(self.CookieText),
            "origin": "https://jwxt.jnu.edu.cn",
            "referer": "https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_Xk_PyfaCx.aspx",
            "upgrade-insecure-requests": "1",
            "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
        }
        file_name = 'courseInfo.txt'
        course_file = open(file_name, mode='w', encoding='utf-8')
        # print("总页数：")
        page = pageNo[0]
        # print(pageNo[0])
        # print("课程信息：")
        # print("第1页")
        # course_file.write("第1页\n")
        for ret in result:
            # print(ret)
            for it in ret:
                course_file.write(it+"|")
            course_file.write('\n')
        for i in range(1, int(page)):
            viewstate = viewstatepart.findall(content)[0]
            eventvalidation = eventvalidationpart.findall(content)[0]
            postdata["__EVENTARGUMENT"] = "Page$"+str(i+1)
            postdata["__VIEWSTATE"] = str(viewstate)
            postdata["__EVENTVALIDATION"] = str(eventvalidation)
            encodedata = urllib.parse.urlencode(postdata)
            postheaders["content-length"] = str(len(encodedata))
            s = requests.Session()
            r = s.post(url=self.Course_url, headers=postheaders, data=encodedata.encode('GB2312'))
            content = r.content.decode('GB2312')
            pageret = part.findall(content)
            # print("第"+str(i+1)+"页")
            # course_file.write("第"+str(i+1)+"页\n")
            for info in pageret:
                # print(info)
                for item in info:
                    course_file.write(item+"|")
                course_file.write('\n')

    def getUserInfo(self, htmlcontent):
        userInfo = {
            "txtNjL": "",
            "txtJdL": "",
            "txtXzL": "",
            "txtZsdxL": "",
            "txtZyfxL": "",
            "txtXyL": "",
            "txtXxlbL": "",
            "txtZyL": "",
            "txtPyccL": "",
            "hidZx": "",
            "hidXh": "",
            "txtXiaoQu": ""
        }
        return userInfo

    def getPage(self):
        headers = {
            "accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3",
            "accpet-encoing": "gzip, deflate, br",
            "accpet-language": "zh-CN,zh;q=0.9",
            "cache-control": "max-age=0",
            "cookie": self.CookieText,
            "upgrade-insecure-requests": "1",
            "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36",
            "Connection": "keep-alive"
        }
        r = requests.get(url=self.Course_url, headers=headers)
        content = r.content.decode('GB2312')
        viewstatepart = re.compile(r'id="__VIEWSTATE"\s*value="(.*)"\s/>')
        eventvalidationpart = re.compile(r'id="__EVENTVALIDATION"\s*value="(.*)"\s/>')
        data = {
            "__EVENTTARGET": "",
            "__EVENTARGUMENT": "",
            "__VIEWSTATE": viewstatepart.findall(content)[0],
            "__VIEWSTATEGENERATOR": "78ACC0FA",
            "__EVENTVALIDATION": eventvalidationpart.findall(content)[0],
            "txtNjL": "",
            "txtJdL": "",
            "txtXzL": "",
            "txtZsdxL": "",
            "txtZyfxL": "",
            "txtXyL": "",
            "txtXxlbL": "",
            "txtZyL": "",
            "txtPyccL": "",
            "hidZx": "",
            "hidXh": "",
            "txtXiaoQu": "",
            "btnXfyq": "学分要求及已获学分"
        }
        encodedata = urllib.parse.urlencode(data)
        headers = {
            "accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3",
            "accept-encoding": "gzip, deflate, br",
            "accept-language": "zh-CN,zh;q=0.9",
            "cache-control": "max-age=0",
            "content-length": str(len(encodedata)),
            "content-type": "application/x-www-form-urlencoded",
            "cookie": str(self.CookieText),
            "origin": "https://jwxt.jnu.edu.cn",
            "referer": "https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_Xk_PyfaCx.aspx",
            "upgrade-insecure-requests": "1",
            "user-agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.131 Safari/537.36",
        }
        s = requests.Session()
        r = s.post(url=self.Course_url, headers=headers, data=encodedata.encode('GB2312'))
        # encode_type = chardet.detect(r.content)
        # result = r.content.decode(encode_type['encoding'])
        # result = r.content
        result = r.content.decode('gb18030')
        #print(result)
        default_file = open("default_page.html", mode='w', encoding='utf-8')
        default_file.write(result)
        default_file.close()

if __name__ == '__main__':
    try:
        id = input()
        password = input()
        course = GetCourseInfo2(id, password)
        course.GetCourseTable()
        course.getPage()
    except AttributeError:
        print("登录问题")