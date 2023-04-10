using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolManagementSystem.Services
{
    public interface ISchool
    {
        public string SchoolName { get; set; }
        List<IClassroom> Classrooms { get; set; }
        List<ITeacher> Teachers { get; set; }
        List<IStudent> Students { get; set; }
    }
}
