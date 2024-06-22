using HR_Managment.Domain.Models;

namespace HR_Managment.Application.DTOs
{
    public class LeaveAllocationDto:BaseDto<int>
    {
        public int DayCount { get; set; }
        public int Period { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
      
    }
}
