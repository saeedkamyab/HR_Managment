using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.DTOs.LeaveType
{
    public class LeaveTypeDto:BaseDto<int>
    {
        [Required]
        public required string Name { get; set; }
        [Required]
        public int DefaultDay { get; set; }
    }
}
