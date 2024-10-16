﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Managment.Application.DTOs.LeaveType;

namespace HR_Managment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto:BaseDto<int>
    {
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
        public required CreateLeaveTypeDto LeaveType { get; set; }
    }
}
