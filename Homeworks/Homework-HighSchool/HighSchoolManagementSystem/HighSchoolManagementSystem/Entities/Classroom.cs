using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighSchoolManagementSystem.Services;

namespace HighSchoolManagementSystem.Entities
{
    public class Classroom : IClassroom
    {
        private static int _classroomID = 0;

        public Classroom(string classroomName)
        {
            ClassroomID = ++_classroomID;
            ClassroomName = classroomName;
            Students = new List<IStudent>();
        }

        public int ClassroomID { get;}
        public string ClassroomName { get; set; }
        public ITeacher? Teacher { get; set; }
        public List<IStudent> Students { get; set; }
    }
}
