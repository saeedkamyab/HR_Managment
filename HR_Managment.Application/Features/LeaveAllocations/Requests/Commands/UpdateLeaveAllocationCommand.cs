﻿using HR_Managment.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand:IRequest<Unit>
    {
        public required LeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
