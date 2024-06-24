using HR_Managment.Application.DTOs;
using MediatR;

namespace HR_Managment.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {

    }
}
