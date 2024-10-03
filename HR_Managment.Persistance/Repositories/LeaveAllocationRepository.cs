using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Domain.Models;

namespace HR_Managment.Persistance.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<int, LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly LeaveManagmentDbContext _context;
        public LeaveAllocationRepository(LeaveManagmentDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
