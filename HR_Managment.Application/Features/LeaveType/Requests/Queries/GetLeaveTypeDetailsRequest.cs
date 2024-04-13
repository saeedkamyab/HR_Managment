using HR_Managment.Application.DTOs;
using MediatR;

namespace HR_Managment.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeDetailsRequest:IRequest<LeaveTypeDto>
    {
        public int Id { get; set; }
    }
}
