using System;

namespace WindowsFormsApp1.com.group.Entry
{
    [Serializable]
    public class ElectInfo
    {
        string time;
        string elect;

        public override string ToString()
        {
            return base.ToString()+":time="+time+",elect="+elect;
        }

        public string Time { get => time; set => time = value; }
        public string Elect { get => elect; set => elect = value; }
    }
}