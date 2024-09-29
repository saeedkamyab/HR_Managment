using HR_Managment.Application.DTOs.LeaveRequest;
using MediatR;

namespace HR_Managment.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestDetailsRequest:IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
