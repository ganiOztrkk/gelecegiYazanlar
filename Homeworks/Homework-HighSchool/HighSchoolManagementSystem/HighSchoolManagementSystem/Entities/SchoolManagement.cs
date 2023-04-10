using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighSchoolManagementSystem.ExtensionMethods;
using HighSchoolManagementSystem.Services;

namespace HighSchoolManagementSystem.Entities
{
    public class SchoolManagement : ISchoolManagement
    {
        public ISchool School { get; set; }

        public SchoolManagement(ISchool school)
        {
            School = school;
        }

        public void AddClassroom(IClassroom classroom) => School.Classrooms.Add(classroom);

        public void RemoveClassroom(IClassroom classroom) => School.Classrooms.Remove(classroom);
        
        public List<IClassroom> GetClassrooms() => School.Classrooms;

        public void AddTeacher(ITeacher teacher) => School.Teachers.Add(teacher);

        public void RemoveTeacher(ITeacher teacher) => School.Teachers.Remove(teacher);

        public List<ITeacher> GetTeachers() => School.Teachers;


        public ITeacher? FindTeacherByID(int id)
        {
            var filtredTeacher = School.Teachers.FirstOrDefault(x => x.TeacherID == id);
            if (filtredTeacher == null)
            {
                Messages.IDNotFound();
            }
            return filtredTeacher;
        }


        public void AddStudent(IStudent student) => School.Students.Add(student);

        public void RemoveStudent(IStudent student) => School.Students.Remove(student);

        public List<IStudent> GetStudents() => School.Students;

        public IStudent? FindStudentByID(int id)
        {
            var filtredStudent = School.Students.FirstOrDefault(x=>x.StudentID == id);
            if (filtredStudent == null)
            {
                Messages.IDNotFound();
            }
            return filtredStudent;
        }
    }
}
