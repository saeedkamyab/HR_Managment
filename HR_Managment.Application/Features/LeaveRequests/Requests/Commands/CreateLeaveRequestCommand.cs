using HR_Managment.Application.DTOs.LeaveRequest;
using HR_Managment.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int> 
    {
        public required LeaveRequestDto LeaveRequestDto { get; set; }

    }
}
