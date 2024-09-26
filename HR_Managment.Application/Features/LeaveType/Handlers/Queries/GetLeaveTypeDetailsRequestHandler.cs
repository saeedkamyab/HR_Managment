using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.DTOs.LeaveType;
using HR_Managment.Application.Features.LeaveType.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveType.Handlers.Queries
{
    public class GetLeaveTypeDetailsRequestHandler :
        IRequestHandler<GetLeaveTypeDetailsRequest, CreateLeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailsRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<CreateLeaveTypeDto> Handle(GetLeaveTypeDetailsRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<CreateLeaveTypeDto>(leaveType);
        }
    }
}
