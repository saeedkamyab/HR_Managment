﻿using HR_Managment.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HR_Managment.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailsRequest:IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
