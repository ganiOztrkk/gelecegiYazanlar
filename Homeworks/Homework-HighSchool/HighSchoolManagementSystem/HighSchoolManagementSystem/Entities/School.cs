using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighSchoolManagementSystem.Services;

namespace HighSchoolManagementSystem.Entities
{
    public class School : ISchool
    {
        public School(string schoolName)
        {
            SchoolName = schoolName;
            Classrooms = new List<IClassroom>();
            Teachers = new List<ITeacher>();
            Students = new List<IStudent>();
        }

        public string SchoolName { get; set; }
        public List<IClassroom> Classrooms { get; set; }
        public List<ITeacher> Teachers { get; set; }
        public List<IStudent> Students { get; set; }
    }
}
