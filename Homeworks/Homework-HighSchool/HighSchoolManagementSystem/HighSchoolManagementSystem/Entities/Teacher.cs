using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighSchoolManagementSystem.Services;

namespace HighSchoolManagementSystem.Entities
{
    public class Teacher : ITeacher
    {
        private static int _teacherID = 0;
        public Teacher(string teacherName)
        {
            TeacherID = ++_teacherID;
            TeacherName = teacherName;
        }

        public int TeacherID { get;}
        public string TeacherName { get; set; }
    }
}
