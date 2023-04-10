using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighSchoolManagementSystem.Services;

namespace HighSchoolManagementSystem.Entities
{
    public class Student : IStudent
    {
        private static int _studentID = 0;
        public Student(string studentName)
        {
            StudentID = ++_studentID;
            StudentName = studentName;
        }

        public int StudentID { get; }
        public string StudentName { get; set; }
        public void SendHomework(ITeacher teacher)
        {
            Console.WriteLine($"{StudentName} adlı öğreci, {teacher.TeacherName} adlı öğretmenin ödevini iletti.");
        }
    }
}
