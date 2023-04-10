using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HighSchoolManagementSystem.Services
{
    public interface IStudent
    {
        public int StudentID { get;}
        public string StudentName { get; set; }
        public void SendHomework(ITeacher teacher);
    }
}
