import re
# import matplotlib.pyplot as plt
import chardet
import requests

# # 解决横纵坐标中文显示问题
# plt.rcParams['font.sans-serif'] = ['SimHei']
# plt.rcParams['axes.unicode_minus'] = False


class ChaDianFei(object):
    def __init__(self, DormNum):
        self.LoginUrl = "http://202.116.25.12/Login.aspx"   # 登陆的url
        self.default_url = "http://202.116.25.12/default.aspx"      # default的url
        self.DormNum = DormNum                      # 宿舍号
        self.cookie = self.GetCookie()              # 获取页面cookie

        # 获取 VIEWSTATE 和 EVENTVALIDATION 以及宿舍对应的编号self.num
        info = self.GetV_E()
        self.viewstate = info['VIEWSTATE']
        self.eventvalidation = info['EVENTVALIDATION']

    def Query(self):
        print ("宿舍号: %d" % self.DormNum)
        self.RestPower()
        self.UsedHistroy()
        # self.UsedHistroy()

        # 获取页面cookie
    def GetCookie(self):
        # Returns:
        # 返回登陆cookie
        headers = {
            "Accept": "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8",
            "Accept-Encoding": "gzip, deflate, sdch",
            "Accept-Language": "zh-CN,zh;q=0.8",
            "Cache-Control": "max-age=0",
            "Connection": "keep-alive",
            "Content-Length": "302",
            "Content-Type": "application/x-www-form-urlencoded",
            "Referer": "http://202.116.25.12/Login.aspx",
            "Host": "202.116.25.12",
            "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36",
            "Upgrade-Insecure-Requests": "1",
        }
        data = {
            "__LASTFOCUS": "",
            "__EVENTTARGET": "",
            "__EVENTARGUMENT": "",
            "__VIEWSTATE": "/wEPDwULLTE5ODQ5MTY3NDlkZM4DISokA1JscbtlCdiUVQMwykIc",
            "__EVENTVALIDATION": "/wEWBQLz+M6SBQK4tY3uAgLEhISACwKd+7q4BwKiwImNC7oxDnFDxrZR6l5WlUJDrpGZXrmN",
            "__VIEWSTATEGENERATOR": "C2EE9ABB",
            "txtname": str(self.DormNum),
            #"hidtime": time.strftime('%F %X'),
            "txtpwd": "",
            "ctl01": "",
        }
        s = requests.Session()
        r = s.post(url=self.LoginUrl, headers=headers, data=data)
        cookie = r.headers.get("set-cookie")
        cookie = cookie.split(";")
        cookie = cookie[0] + ";" + cookie[2][8:]
        return cookie


    def GetV_E(self):
        # Returns:
        # 返回Info是一个字典，包含VIEWSTATE和EVENTVALIDATION
        headers = {
            "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36",
            "cookie": self.cookie,
            "Connection": "keep-alive"
        }

        r = requests.get(url=self.default_url, headers=headers)
        #content = r.content
        encode_type = chardet.detect(r.content)
        content = r.content.decode(encode_type['encoding'], errors="ignore")
        regular = {
            'viewstate': re.compile(r'id="__VIEWSTATE" value="(.+)" />'),
            'eventvalidation': re.compile(r'id="__EVENTVALIDATION" value="(.+)" />')
        }
        Info = dict()
        Info['VIEWSTATE'] = regular['viewstate'].findall(content)[0]
        Info['EVENTVALIDATION'] = regular['eventvalidation'].findall(content)[0]
        part = re.compile(r'"(\[电表\]\|.+?)"')
        self.num = str(part.findall(content)[0])
        return Info


    def RestPower(self):
        # Returns:
        # 输出剩余电量
        data = {
            "__EVENTTARGET": "RegionPanel1$Region2$GroupPanel1$ContentPanel1$DDL_监控项目",
            "__VIEWSTATE": self.viewstate,
            "__VIEWSTATEGENERATOR": "CA0B0334",
            "__EVENTVALIDATION": self.eventvalidation,
            "PandValue": "10",
            "hidpageCurrentSize": "1",
            "hidpageSum": "1",
            "hidpageCurrentSize2": "1",
            "hidpageSum2": "4",
            "hidpageCurrentSize3": "1",
            "hidpageSum3": "25",
            # "RegionPanel1$Region3$ContentPanel3$txtstarOld": "2017-5-2",
            # "RegionPanel1$Region3$ContentPanel3$txtstar": "2017-6-2",
            "__12_value": self.num,
            #"RegionPanel1$Region3$ContentPanel3$tb_ammeterNumb": self.num[0:4] + self.num[5:],
            "__41_value": "00900200",
            "RegionPanel1$Region1$GroupPanel2$Grid3$Toolbar2$pagesize3": "1",
            "RegionPanel1$Region1$GroupPanel2$Grid2$Toolbar3$pagesize2": "1",
            "RegionPanel1$Region1$GroupPanel2$Grid1$Toolbar1$pagesize": "1",
            "__box_page_state_changed": "false",
            "__12_last_value": self.num,
            "__41_last_value": "00000000",
            "__box_ajax_mark": "true",
        }
        headers = {
            "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36",
            "cookie": self.cookie
        }
        r = requests.Session().post(url=self.default_url, data=data, headers=headers)
        # res=r.content
        encode_type = chardet.detect(r.content)
        res = r.content.decode(encode_type['encoding'], errors="ignore")
        part = re.compile(r'box\.__27\.setValue\("(.+?)"\)')
        res = part.findall(res)[0]
        print ("当前剩余电量: %s度" % res)
        #print time.ctime()




    def UsedHistroy(self):
        # Returns:
        # 直接输出电量使用记录
        data = {
            "__EVENTTARGET": "RegionPanel1$Region1$GroupPanel2$Grid2$Toolbar3$pagesize2",
            "__VIEWSTATE": self.viewstate,
            "__VIEWSTATEGENERATOR": "CA0B0334",
            "__EVENTVALIDATION": self.eventvalidation,
            "PandValue": "10",
            "hidpageCurrentSize": "1",
            "hidpageSum": "1",
            "hidpageCurrentSize2": "1",
            "hidpageSum2": "4",
            "hidpageCurrentSize3": "1",
            "hidpageSum3": "25",
            # "RegionPanel1$Region3$ContentPanel3$txtstarOld": "2017-5-2",
            # "RegionPanel1$Region3$ContentPanel3$txtstar": "2017-6-2",
            "__12_value": self.num,
            "RegionPanel1$Region3$ContentPanel3$tb_ammeterNumb": "[电表]000001213787",
            "__41_value": "00000000",
            "RegionPanel1$Region1$GroupPanel2$Grid3$Toolbar2$pagesize3": "1",
            "RegionPanel1$Region1$GroupPanel2$Grid2$Toolbar3$pagesize2": "4",
            "RegionPanel1$Region1$GroupPanel2$Grid1$Toolbar1$pagesize": "1",
            "__box_page_state_changed": "true",
            "__12_last_value": self.num,
            "__41_last_value": "00000000",
            "__box_ajax_mark": "true",
        }
        headers = {
            "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KUsedHistroy, like Gecko) Chrome/58.0.3029.110 Safari/537.36",
            "cookie": self.cookie,
            "X-Requested-With": "XMLHttpRequest"
        }

        r = requests.Session().post(url=self.default_url, data=data, headers=headers)
        res = r.text.split('[')
        part = re.compile(r'"(.+?)"')

        # 将列表反向，是为了让日期降序输出
        res.reverse()
        print ('********************************')
        print ("电量使用历史记录: \n")
        print ("   日期      用电量   用电金额")
        date_list = []
        electricity_list = []
        money_list = []
        for x in res[1:-2]:
            x = part.findall(x)
            print ("%s    %s度    %s元"  % (x[0],x[1],x[2]))
            date_list.append(x[0][5:])
            electricity_list.append(float(x[1]))
            money_list.append(float(x[2]))

        # # 爬取是按时间降序，绘图需要升序
        # date_list.reverse()
        # electricity_list.reverse()
        # money_list.reverse()
        # # print(date_list)
        # plt.plot(date_list, electricity_list, 'b*-', alpha=0.5, linewidth=2)
        # plt.xticks(rotation=45) # 旋转x轴刻度
        # plt.xlabel('日期')
        # plt.ylabel('用电量（度）')
        # plt.title('日用电量折线图(2019)')
        # plt.ylim((0, 50))
        # for x, y in zip(date_list, electricity_list):
        #     plt.text(x, y + 0.7, '%.2f' % y, ha='center', va='bottom', fontsize=10.5)
        # plt.savefig('elect_curve.jpg')
        # # plt.show()
        # plt.cla()
        #
        # plt.plot(date_list, money_list, 'b*-', alpha=0.5, linewidth=2)
        # plt.xticks(rotation=45)  # 旋转x轴刻度
        # plt.xlabel('日期')
        # plt.ylabel('用电费用（元）')
        # plt.title('日用电费用折线图(2019)')
        # plt.ylim((0, 20))
        # for x, y in zip(date_list, money_list):
        #     plt.text(x, y + 0.7, '%.2f' % y, ha='center', va='bottom', fontsize=10.5)
        # plt.savefig('fee_curve.jpg')
        # # plt.show()

        # 写入txt
        file_name = 'ElectInfo.txt'
        elect_file = open(file_name, mode='w', encoding='utf-8')
        count = 0
        for i in date_list:
            count += 1

        for j in range(count):
            elect_file.writelines(date_list[j])
            elect_file.write('\n')
            elect_file.writelines(str(electricity_list[j]))
            elect_file.write('度')
            elect_file.write('\n')
            elect_file.writelines(str(money_list[j]))
            elect_file.write('元')
            elect_file.write('\n')

        elect_file.close()


if __name__ == '__main__':
    try:
        dormNum = int(input())
        dorm=ChaDianFei(DormNum=dormNum)
        dorm.Query()
    except AttributeError:
        print("宿舍号有误")
