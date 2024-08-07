﻿using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.Features.LeaveType.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.Features.LeaveType.Handlers.Commands
{
    public class UpdateLeaveTypeCommandHandler:IRequestHandler<UpdateLeaveTypeCommand,Unit>
    {
        IMapper _mapper;
        ILeaveTypeRepository _leaveTypeRepository;

        public UpdateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = await _leaveTypeRepository.Get(request.LeaveTypeDto.Id);
            _mapper.Map(request.LeaveTypeDto, leaveType);
            await _leaveTypeRepository.Update(leaveType);

           return Unit.Value;
        }
    }
}
