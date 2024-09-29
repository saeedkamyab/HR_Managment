using HR_Managment.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace HR_Managment.Domain.Models
{
    public class LeaveAllocation:BaseEntity<int>
    {
        public int DayCount { get; set; }
        public int Period { get; set; }

        #region Relation to LeaveType
        [Required]
        public required LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        #endregion
    }
}
