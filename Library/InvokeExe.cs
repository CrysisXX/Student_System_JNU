using System;
using System.Diagnostics;

namespace Library
{
    public class InvokeExe
    {
        public string invoke(string path,string workingDirectroy,string[] parameters)
        {
            Process p = new Process();
            p.StartInfo.FileName = path;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WorkingDirectory = workingDirectroy;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            
            foreach(string s in parameters)
            {
                p.StandardInput.WriteLine(s);
            }
            string res = null;
            while (p.StandardOutput.Peek() > -1)
            {
                res += (p.StandardOutput.ReadLine());
            }
            p.WaitForExit();
            return res;
        }
    }
}