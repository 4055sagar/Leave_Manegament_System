using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manegament_System.Models
{
    public class MyLeaveSectionModel
    {
        public int LeaveId { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string LeaveType { get; set; }
        public string Status { get; set; }

        public string Reason { get; set; }
        public DateTime ApplicationOn { get; set; }
        public string ManagerComments { get; set; }
    }
}
