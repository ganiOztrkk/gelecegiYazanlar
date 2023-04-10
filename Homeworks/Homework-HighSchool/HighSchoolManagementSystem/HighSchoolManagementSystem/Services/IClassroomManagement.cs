using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolManagementSystem.Services
{
    public interface IClassroomManagement
    {
        public void AssignTeacher(ITeacher teacher);
        public void AssignStudent(IStudent student);

    }
}
