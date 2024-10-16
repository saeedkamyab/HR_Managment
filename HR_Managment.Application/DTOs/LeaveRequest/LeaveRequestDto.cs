﻿using HR_Managment.Application.DTOs.LeaveType;
using HR_Managment.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace HR_Managment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDto:BaseDto<int>
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateRequested { get; set; }
        public string? RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        [Required]
        public required CreateLeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

    }
}
