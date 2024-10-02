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

            #region  LeaveRequestMapping
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, UpdateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, ChangeLeaveRequestApprovedDto>().ReverseMap();
            #endregion

            #region  LeaveTypeMapping
            CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();
            #endregion


            #region  LeaveAllocationMapping
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveAllocation, CreateLeaveAllocation>().ReverseMap();
            CreateMap<LeaveAllocation, UpdateLeaveAllocationDto>().ReverseMap();

            #endregion


        }
    }
}
