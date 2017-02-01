using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_ex_104_student
{
    public class student
    {
        private string major;
        private int score1;
        private int score2;
        private int score3;
        private string studentfirstname;
        private string studentlastname;
        private string studentnumber;

        public student()
        {

        }
        
        public student(string sid)
        {
            studentnumber = sid;
        }
        
        public student(string sid, string lastname, string firstname)
        {
            studentnumber = sid;
            studentfirstname = firstname;
            studentlastname = lastname;
        }

        public student(string sid, string lastname, string firstname, int s1, int s2, int s3, string maj)
        {
            studentnumber = sid;
            studentfirstname = firstname;
            studentlastname = lastname;
            score1 = s1;
            score2 = s2;
            score3 = s3;
            major = maj;

        }
    }
}
