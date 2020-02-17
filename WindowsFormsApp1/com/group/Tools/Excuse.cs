using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using TestLog4Net;
using WindowsFormsApp1.com.group.Pages;

namespace WindowsFormsApp1.com.group.Tools
{
    class Excuse
    {
        public void exportDoc()
        {
            try
            {
                Document doc = new Document();
                doc.LoadFromFile("../../../Templates/暨南大学学生请假申请表.docx");
                doc.Replace("$StartY", GlobalData.StartTimeY, false, false);
                doc.Replace("$StartM", GlobalData.StartTimeM, false, false);
                doc.Replace("$StartD", GlobalData.StartTimeD, false, false);
                doc.Replace("$EndY", GlobalData.EndTimeY, false, false);
                doc.Replace("$EndM", GlobalData.EndTimeM, false, false);
                doc.Replace("$EndD", GlobalData.EndTimeD, false, false);
                doc.Replace("$Reason", GlobalData.ExcuseReason, false, false);
                doc.Replace("$StudentId", GlobalData.user.StudentId+"", false, false);
                doc.Replace("$Name", GlobalData.user.Name, false, false);
                doc.Replace("$Major", GlobalData.user.Major, false, false);
                doc.Replace("$School", GlobalData.user.School, false, false);
                doc.Replace("$TotalDays", GlobalData.ExceseTotalDays, false, false);
                doc.SaveToFile("../../../ExceseRes/请假申请表.docx", FileFormat.Docx);
                MessageBox.Show("导出成功");
            }
            catch(System.NullReferenceException e)
            {
                MessageBox.Show("请先完善个人信息");
                LogHelper.WriteLog(typeof(Excuse), e);
            }
            catch(System.IO.IOException e)
            {
                MessageBox.Show("导出失败");
                LogHelper.WriteLog(typeof(Excuse), e);
            }

            //System.Diagnostics.Process.Start("Replace.docx");
        }

    }
}
