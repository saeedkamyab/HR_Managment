namespace HR_Managment.Application.DTOs.LeaveType
{
    public class CreateLeaveTypeDto : BaseDto<int>
    {
        public required string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
