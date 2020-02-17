import urllib.request as ur
import urllib.parse
import http.cookiejar
import requests
import re
from PIL import Image


class LoginCookie(object):
    def __init__(self, userId, pw):
        self.LoginUrl = "https://jwxt.jnu.edu.cn/Login.aspx"
        self.Course_url = "https://jwxt.jnu.edu.cn/Secure/PaiKeXuanKe/wfrm_Xk_PyfaCx.aspx"
        self.UserId = userId
        self.Pw = pw
        self.CookieText = self.getCookieText()

        vrifyCodeUrl = "https://jwxt.jnu.edu.cn/ValidateCode.aspx"
        file = ur.urlopen(vrifyCodeUrl)
        pic = file.read()
        path = 'vcode.png'
        localpic = open(path, 'wb')
        localpic.write(pic)
        localpic.close()
        image = Image.open(path)
        # print("输入验证码:")
        image.show()
        self.vCode = input()

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


if __name__ == '__main__':
    try:
        id = input()
        password = input()
        course = LoginCookie(id, password)
        print(course.CookieText)
    except AttributeError:
        print("登录问题")