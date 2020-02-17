using System;
using System.IO;

namespace Library
{
    public class checkDir
    {
        public bool check(string url)
        {
            try
            {
                if (!Directory.Exists(url))//如果不存在就创建file文件夹　　             　　              
                    Directory.CreateDirectory(url);//创建该文件夹　　            
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}