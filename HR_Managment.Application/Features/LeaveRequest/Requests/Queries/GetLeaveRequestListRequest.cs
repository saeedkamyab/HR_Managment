using HR_Managment.Application.DTOs.LeaveRequestDtos;
using MediatR;

namespace HR_Managment.Application.Features.LeaveRquest.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestDto>>
    {

    }
}
