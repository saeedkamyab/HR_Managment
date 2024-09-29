using FluentValidation;
using HR_Managment.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application.DTOs.LeaveRequest.Validators
{
    public class CreateLeaveRequestDtoValidator:AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveRequestDtoValidator(ILeaveTypeRepository leaveTypeRepository)
        {
            _leaveTypeRepository = leaveTypeRepository;
            RuleFor(p => p.LeaveTypeId).GreaterThan(0).MustAsync(async (id, token) =>
            {
                var existingLeaveType = await _leaveTypeRepository.Get(id);
                if (existingLeaveType != null) return false; else return true;
            }).WithMessage("{PropertyName} does not exist.");
        }

    }
}
