using HR_Managment.Domain.Models.Common;

namespace HR_Managment.Domain.Models
{
    public class LeaveType:BaseEntity<int>
    {
        public required string Name { get; set; }
        public int DefaultDay { get; set; }
    }
}
