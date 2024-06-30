using AutoMapper;
using HR_Managment.Application.DTOs.LeaveAllocation;
using HR_Managment.Application.DTOs.LeaveRequest;
using HR_Managment.Application.DTOs.LeaveType;
using HR_Managment.Domain.Models;

namespace HR_Managment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
        }
    }
}
