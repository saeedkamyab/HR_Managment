using AutoMapper;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.DTOs.LeaveType.Validator;
using HR_Managment.Application.Features.LeaveType.Requests.Commands;
using MediatR;
using System.ComponentModel.DataAnnotations;
using HR_Managment.Application.Responses;

namespace HR_Managment.Application.Features.LeaveType.Handlers.Commands
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, BaseCommandResponse>
    {
        ILeaveTypeRepository _leaveTypeRepository;
        IMapper _mapper;

        public CreateLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var validator=new CreateLeaveTypeDtoValidator();
            var response = new BaseCommandResponse();
            var validationResult=await validator.ValidateAsync(request.LeaveTypeDto, cancellationToken);
            if (!validationResult.IsValid)
            {
                response.Success=false;
                response.Message = "Creation was failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
                throw new Exceptions.ValidationException(validationResult);
            }
            var leaveType = _mapper.Map<Domain.Models.LeaveType>(request.LeaveTypeDto);
            leaveType=await _leaveTypeRepository.Add(leaveType);

            response.Success = true;
            response.Message = "Successful";
            response.Id= leaveType.Id;

            return response;
        }
    }
}
