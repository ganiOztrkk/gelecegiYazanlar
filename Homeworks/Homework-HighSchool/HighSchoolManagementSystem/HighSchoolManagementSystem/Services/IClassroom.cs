using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolManagementSystem.Services
{
    public interface IClassroom
    {
        public int ClassroomID { get; }
        public string ClassroomName { get; set; }
        public ITeacher? Teacher { get; set; }
        List<IStudent> Students { get; set; }

    }
}
