using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entry;

namespace WindowsFormsApp1.com.group.Pages
{
    class GlobalData
    {
        public static String stuId;
        public static String ExcuseReason;
        public static String StartTimeY;
        public static String StartTimeM;
        public static String StartTimeD;
        public static String EndTimeY;
        public static String EndTimeM;
        public static String EndTimeD;
        public static String ExceseTotalDays;
        public static String SearchInfo;
        public static User user;
        public static string getExcuseInfo()
        {
            return "ExcuseReason=" + ExcuseReason + ",StartTime=" + StartTimeY + "/" + StartTimeM + "/" + StartTimeD + ",EndTime=" + EndTimeY + "/" + EndTimeM + "/" + EndTimeD;
        }
    }
}
