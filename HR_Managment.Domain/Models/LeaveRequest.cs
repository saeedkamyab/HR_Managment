using HR_Managment.Domain.Models.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace HR_Managment.Domain.Models
{
    public class LeaveRequest : BaseEntity<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public string? RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }


        #region Relation to LeaveType
        [Required]
        public required LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        #endregion

    }
}
