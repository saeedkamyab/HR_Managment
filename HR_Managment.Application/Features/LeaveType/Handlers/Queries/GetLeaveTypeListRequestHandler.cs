using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.DTOs;
using HR_Managment.Application.Features.LeaveType.Requests.Queries;
using MediatR;

namespace HR_Managment.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler :
        IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request,
            CancellationToken cancellationToken)
        {
           var LeaveTypeList=await _leaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveTypeDto>>(LeaveTypeList);
        }
    }
}
