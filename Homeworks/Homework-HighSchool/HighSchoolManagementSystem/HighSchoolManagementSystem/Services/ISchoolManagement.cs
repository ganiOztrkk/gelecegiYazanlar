using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolManagementSystem.Services
{
    public interface ISchoolManagement
    {
        public void AddClassroom(IClassroom classroom);
        public void RemoveClassroom(IClassroom classroom);
        public List<IClassroom> GetClassrooms();


        public void AddTeacher(ITeacher teacher);
        public void RemoveTeacher(ITeacher teacher);
        public ITeacher? FindTeacherByID(int id);
        public List<ITeacher> GetTeachers();


        public void AddStudent(IStudent student);
        public void RemoveStudent(IStudent student);
        public IStudent? FindStudentByID(int id);
        public List<IStudent> GetStudents();
    }
}
