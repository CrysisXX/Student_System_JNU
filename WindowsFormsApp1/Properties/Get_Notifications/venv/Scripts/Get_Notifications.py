
import requests
from bs4 import BeautifulSoup


def get_all_title_name(url):
    """
    获取第一页的所有通知的标题
    :return:
    """
    title_name_list = []
    r = requests.get(url, timeout=30)

    # 解决中文乱码问题
    if r.encoding == 'ISO-8859-1':
        encodings = requests.utils.get_encodings_from_content(r.text)
        if encodings:
            encoding = encodings[0]
        else:
            encoding = r.apparent_encoding
    else:
        encoding = r.encoding
    encode_content = r.content.decode(encoding, 'replace').encode('utf-8', 'replace').decode('utf-8')

    # 获得网页源代码
    soup = BeautifulSoup(encode_content, 'lxml')

    # 获取首页所有通知的标题
    name_content_list = soup.find_all('h3', {'class': 'media-heading'})
    for name in name_content_list:
        title_name_list.append(name.text)

    # 返回首页所有的通知标题
    return title_name_list


def get_all_title_date(url):
    """
    获取第一页的所有通知的日期
    :return:
    """
    title_date_list = []
    r = requests.get(url, timeout=30)

    # 解决中文乱码问题
    if r.encoding == 'ISO-8859-1':
        encodings = requests.utils.get_encodings_from_content(r.text)
        if encodings:
            encoding = encodings[0]
        else:
            encoding = r.apparent_encoding
    else:
        encoding = r.encoding
    encode_content = r.content.decode(encoding, 'replace').encode('utf-8', 'replace').decode('utf-8')

    # 获得网页源代码
    soup = BeautifulSoup(encode_content, 'lxml')

    # 获取首页所有通知的日期和月份年份信息
    day_content_list = soup.find_all('strong')
    year_month_content_list = soup.find_all('small')

    # 首页展示12条通知信息
    for i in range(12):
        title_date_list.append(year_month_content_list[i].text + '-' + day_content_list[i].text)

    # 返回首页所有的通知日期
    return title_date_list


def get_all_title_link(url):
    """
    获取第一页的所有通知的URL
    :return:
    """
    title_list = []
    title_link_list = []
    title_name_list = []
    r = requests.get(url, timeout=30)

    # 解决中文乱码问题
    if r.encoding == 'ISO-8859-1':
        encodings = requests.utils.get_encodings_from_content(r.text)
        if encodings:
            encoding = encodings[0]
        else:
            encoding = r.apparent_encoding
    else:
        encoding = r.encoding
    encode_content = r.content.decode(encoding, 'replace').encode('utf-8', 'replace').decode('utf-8')

    # 获得网页源代码
    soup = BeautifulSoup(encode_content, 'lxml')
    # 获取title信息的主体
    title_body = soup.find_all('div', {'class': 'col-lg-12 col-md-12'})

    # 获取首页所有通知的链接
    link_content_list = title_body[0].find_all('a')
    # 网站通用头链接
    head_url = 'https://zh.jnu.edu.cn/'
    for link in link_content_list:
        title_link_list.append((head_url, link['href'][1:]))

    # # 获取首页所有通知的标题
    # name_content_list = soup.find_all('h3', {'class': 'media-heading'})
    # for name in name_content_list:
    #     title_name_list.append(name.text)
    #
    # # 首页总共有12条通知
    # for i in range(12):
    #     title_list.append((title_name_list[i], title_link_list[i]))

    # 返回首页所有的通知链接
    return title_link_list


def get_notification_txt(notification_type, notification_url):
    """
    写入txt文件函数
    """
    # notification_type代表属于通知类型（校区公告、讲座报告、学生通知及教师通知等）
    # notification_url代表相应通知类型的总url
    file_name = notification_type + '_notification.txt'
    title_link_list = get_all_title_link(notification_url)
    title_name_list = get_all_title_name(notification_url)
    title_date_list = get_all_title_date(notification_url)

    title_list_file = open(file_name, mode='w', encoding='utf-8')
    for i in range(12):
        # number_str = str(i + 1) + '.'
        # title_list_file.write(number_str)
        # title_list_file.write('\n')
        title_list_file.writelines(title_name_list[i])
        title_list_file.write('\n')
        title_list_file.writelines(title_date_list[i])
        title_list_file.write('\n')
        title_list_file.writelines(title_link_list[i])
        title_list_file.write('\n')
    title_list_file.close()


def main():
    get_notification_txt('Campus', 'https://zh.jnu.edu.cn/8366/list.htm')
    get_notification_txt('Lecture', 'https://zh.jnu.edu.cn/8367/list.htm')
    get_notification_txt('Student', 'https://zh.jnu.edu.cn/8378/list.htm')
    get_notification_txt('Teacher', 'https://zh.jnu.edu.cn/8379/list.htm')


if __name__ == '__main__':
    main()
