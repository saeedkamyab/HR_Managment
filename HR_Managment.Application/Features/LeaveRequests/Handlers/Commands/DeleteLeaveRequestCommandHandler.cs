using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.Features.LeaveRequests.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveRequests.Handlers.Commands
{
    public class DeleteLeaveRequestCommandHandler : IRequestHandler<DeleteLeaveRequestCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveRequestRepository _leaveRequestRepo;

        public DeleteLeaveRequestCommandHandler(IMapper mapper, ILeaveRequestRepository leaveRequestRepo)
        {
            _mapper = mapper;
            _leaveRequestRepo = leaveRequestRepo;
        }

        public async Task<Unit> Handle(DeleteLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepo.Get(request.Id);
            await _leaveRequestRepo.Delete(request.Id);
            return Unit.Value;
        }
    }
}
