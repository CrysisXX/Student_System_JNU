using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entry
{
    [Serializable]
    public class User
    {
        private String name="";
        private String school="";
        private String major="";
        private int studentId=0;
        private int roomId=0;
        private int cardId=0;
        private String jwxtpassword="";
        private String password="";

        public override string ToString()
        {
            return base.ToString()+":name = "+name+",school="+school+",major="+major+",studentId="+studentId+",roomId="+roomId+",cardId="+cardId+",jwxtPassword="+jwxtpassword+",password="+password;
        }

        public string Name { get => name; set => name = value; }
        public string School { get => school; set => school = value; }
        public string Major { get => major; set => major = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public int RoomId { get => roomId; set => roomId = value; }
        public int CardId { get => cardId; set => cardId = value; }
        public string Jwxtpassword { get => jwxtpassword; set => jwxtpassword = value; }
        public string Password { get => password; set => password = value; }
    }
}
