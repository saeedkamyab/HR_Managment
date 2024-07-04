using HR_Managment.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveType.Requests.Commands
{
    public class CreateLeaveTypeCommand:IRequest<int>//I use int becuse I wanna get Id of a recorde that is inserted. 
    {
        public required LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
