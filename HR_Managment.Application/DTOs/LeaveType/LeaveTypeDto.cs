namespace HR_Managment.Application.DTOs.LeaveType
{
    public class LeaveTypeDto : BaseDto<int>
    {
        public required string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
