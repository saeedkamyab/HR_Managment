using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.DTOs.LeaveType.Validator;
using HR_Managment.Application.Features.LeaveType.Requests.Commands;
using MediatR;

namespace HR_Managment.Application.Features.LeaveType.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        ILeaveTypeRepository _leaveTypeRepository;
        IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator=new CreateLeaveTypeDtoValidator();
            var validationResult=await validator.ValidateAsync(request.LeaveTypeDto, cancellationToken);
            if (!validationResult.IsValid) {
                throw new Exception();
            }
            var leaveType = _mapper.Map<Domain.Models.LeaveType>(request.LeaveTypeDto);
            leaveType=await _leaveTypeRepository.Add(leaveType);
            return leaveType.Id;
        }
    }
}
