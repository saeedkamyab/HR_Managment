using HR_Managment.Application.DTOs.LeaveTypeDtos;
using HR_Managment.Domain.Models;

namespace HR_Managment.Application.DTOs.LeaveAllocationDtos
{
    public class LeaveAllocationDto
    {
        public int DayCount { get; set; }
        public int Period { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

    }
}
