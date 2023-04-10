using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighSchoolManagementSystem.Services;

namespace HighSchoolManagementSystem.Entities
{
    public class ClassroomManagement : IClassroomManagement
    {
        private readonly IClassroom _classroom;

        public ClassroomManagement(IClassroom classroom)
        {
            _classroom = classroom;
        }

        public void AssignTeacher(ITeacher teacher) => _classroom.Teacher = teacher;

        public void AssignStudent(IStudent student) => _classroom.Students.Add(student);

    }
}
