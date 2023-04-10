using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolManagementSystem.Services
{
    public interface ITeacher
    {
        public int TeacherID { get;}
        public string TeacherName { get; set; }
    }
}
