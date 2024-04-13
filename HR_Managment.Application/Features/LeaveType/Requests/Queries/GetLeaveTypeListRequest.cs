using HR_Managment.Application.DTOs;
using MediatR;

namespace HR_Managment.Application.Features.LeaveType.Requests.Queries
{
    public class GetLeaveTypeListRequest : IRequest<List<LeaveTypeDto>>
    {

    }
}
