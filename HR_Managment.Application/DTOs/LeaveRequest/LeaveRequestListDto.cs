using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto
    {
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
    }
}
