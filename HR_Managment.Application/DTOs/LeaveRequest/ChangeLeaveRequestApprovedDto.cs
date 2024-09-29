using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovedDto:BaseDto<int>
    {
        public bool? Approved { get; set; }
    }
}
