using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WwwPracticeDb.Models;

namespace WwwFinal.Controllers
{
    public class LoginState
    {
        public int LoginID { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }

        public LoginState()
        {
            
        }

        public void LoginTeacher(TeacherModel t)
        {
            LoginID = t.teacherID;
            firstName = t.firstName;
            LastName = t.lastName;
            email = t.email;
        }

        public int GetTeacherID()
        {
            return this.LoginID;
        }

        public void empty()
        {
            LoginID = 0;
            firstName = null;
            LastName = null;
            email = null;
        }

        public void LoginStudent(StudentModel s)
        {
            LoginID = s.studentID;
            firstName = s.firstName;
            LastName = s.lastName;
            email = s.email;
        }
    }
}
