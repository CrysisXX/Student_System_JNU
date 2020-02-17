using System.IO;
using System.Text;

namespace Library
{
    public class TxtOperator
    {
       public string[] readTxt(string path)
        {
            string[] allLines = File.ReadAllLines(path, Encoding.GetEncoding("utf-8"));
            return allLines;
        }
    }
}