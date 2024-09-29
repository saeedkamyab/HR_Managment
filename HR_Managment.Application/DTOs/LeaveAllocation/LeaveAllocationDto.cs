using HR_Managment.Application.DTOs.LeaveType;
using HR_Managment.Domain.Models;

namespace HR_Managment.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto<int>
    {
        public int DayCount { get; set; }
        public int Period { get; set; }
        public required CreateLeaveTypeDto LeaveType { get; set; } 
        public int LeaveTypeId { get; set; }

    }
}
