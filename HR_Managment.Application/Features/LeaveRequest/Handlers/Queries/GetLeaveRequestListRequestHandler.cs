using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.DTOs.LeaveRequest;
using HR_Managment.Application.Features.LeaveRquest.Requests.Queries;
using MediatR;

namespace HR_Managment.Application.Features.LeaveRquest.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler :
        IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<LeaveRequestDto>> Handle(GetLeaveRequestListRequest request,
            CancellationToken cancellationToken)
        {
           var LeaveTypeList=await _leaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveRequestDto>>(LeaveTypeList);
        }

    }
}
