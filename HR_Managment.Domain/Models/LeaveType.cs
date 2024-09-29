using HR_Managment.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace HR_Managment.Domain.Models
{
    public class LeaveType:BaseEntity<int>
    {
        [Required]
        public required string Name { get; set; }
        [Required]
        public int DefaultDay { get; set; }
    }
}
