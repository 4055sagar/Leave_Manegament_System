using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Leave_Manegament_System.Models
{
    public class NewLeaveApplication
    {

         [Required]
         [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]        
        public DateTime EndDate { get; set; }
        [Required]
        public string LeaveType { get; set; }
        [Required]
        public string Reason { get; set; }  
    
    }
}
