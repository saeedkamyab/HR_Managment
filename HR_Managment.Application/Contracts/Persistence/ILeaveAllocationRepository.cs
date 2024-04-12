﻿using HR_Managment.Application.Contracts.Persistence.Common;
using HR_Managment.Domain.Models;

namespace HR_Managment.Application.Contracts.Persistence
{
    public interface ILeaveAllocationRepository:IBaseRepository<int,LeaveAllocation>
    {
    }
}
