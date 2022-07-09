using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manegament_System.Models
{
    public class EmployeeDetails
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public long EmployeeNumber { get; set; }
        public DateTime EmployeeDateJoined { get; set; }
        public string EmployeeDepartment { get; set; }

        public int AvaiableLeave { get; set; }
    }
}
