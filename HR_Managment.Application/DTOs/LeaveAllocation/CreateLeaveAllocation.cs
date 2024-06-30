using HR_Managment.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocation:BaseDto<int>
    {
        public int DayCount { get; set; }
        public int Period { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
