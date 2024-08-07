﻿using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.Features.LeaveAllocations.Requests.Commands;
using HR_Managment.Application.Features.LeaveType.Requests.Commands;
using HR_Managment.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand, Unit>
    {
        IMapper _mapper;
        ILeaveAllocationRepository _leaveAllocationRepository;

        public UpdateLeaveAllocationCommandHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.Get(request.LeaveAllocationDto.Id);
            _mapper.Map(request.LeaveAllocationDto, leaveAllocation);
            await _leaveAllocationRepository.Update(leaveAllocation);
            return Unit.Value;
        }
    }
}
