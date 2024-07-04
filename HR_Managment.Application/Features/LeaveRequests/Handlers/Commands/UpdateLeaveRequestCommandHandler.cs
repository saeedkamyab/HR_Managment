using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.DTOs.LeaveRequest;
using HR_Managment.Application.Features.LeaveRequests.Requests.Commands;
using HR_Managment.Application.Features.LeaveType.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveRequests.Handlers.Commands
{
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        IMapper _mapper;
        ILeaveRequestRepository _leaveRequestRepository;

        public UpdateLeaveRequestCommandHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.LeaveRequestDto.Id);
            _mapper.Map(request.LeaveRequestDto, leaveRequest);
            await _leaveRequestRepository.Update(leaveRequest);
            return Unit.Value;
        }
    }
}
