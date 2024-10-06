using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.Features.LeaveRequests.Requests.Commands;
using HR_Managment.Application.Features.LeaveType.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Managment.Application.Contracts.Infrastructure;
using HR_Managment.Application.Models;

namespace HR_Managment.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        ILeaveRequestRepository _leaveRequestRepository;
        IMapper _mapper;
        IEmailSender _emailSender;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper, IEmailSender emailSender)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }


        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = _mapper.Map<Domain.Models.LeaveRequest>(request.LeaveRequestDto);
            var email = new Email()
            {
                To = "saeedkamiab@gmail.com",
                Subject = "Leave request submitted",
                Body = $"your leave request for{request.LeaveRequestDto.StartDate}"+$"to {request.LeaveRequestDto.EndDate}"

            };
            try
            {
                await _emailSender.SendEmail(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);
            return leaveRequest.Id;
        }
    }
}
