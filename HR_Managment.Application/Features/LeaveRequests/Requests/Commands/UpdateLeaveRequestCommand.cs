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
    public class UpdateLeaveRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public required UpdateLeaveRequestDto LeaveRequestDto { get; set; }
        public required ChangeLeaveRequestApprovedDto ChangeLeaveRequestApprovedDto { get; set; }

    }
  
}
