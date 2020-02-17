using System.Collections;
using System.IO;
using System.Text;

namespace Library
{
    static public class BuildTarget
    {
        public static void BuildTargetNews(string []fileNames) {
            // 检查传入选中状态数组是否为空
            if (fileNames != null)
            {
                // 先删除再新建重写，避免重复
                File.Delete("../../" + "Properties\\Get_Notifications\\dist\\Target_news.txt");
                foreach (string s in fileNames)
                {
                    string path = "../../" + "Properties\\Get_Notifications\\dist\\" + s;
                    // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
                    string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
                    File.AppendAllLines("../../" + "Properties\\Get_Notifications\\dist\\Target_news.txt", allLines);
                }
            }
            // 如果为空则删除原来的文件
            else
            {
                File.Delete("../../" + "Properties\\Get_Notifications\\dist\\Target_news.txt");
            }
        }
        public static void BulidTargetNotification(string []fileNames) {
            // 检查传入选中状态数组是否为空
            if (fileNames != null)
            {
                File.Delete("../../" + "Properties\\Get_Notifications\\dist\\Target_notification.txt");
                foreach (string s in fileNames)
                {
                    string path = "../../" + "Properties\\Get_Notifications\\dist\\" + s;
                    // 使用Encoding.GetEncording("utf-8")解决中文读取乱码的问题
                    string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
                    File.AppendAllLines("../../" + "Properties\\Get_Notifications\\dist\\Target_notification.txt", allLines);
                }
            }
            // 如果为空则删除原来的文件
            else
            {
                File.Delete("../../" + "Properties\\Get_Notifications\\dist\\Target_news.txt");
            }
        }
    }
}