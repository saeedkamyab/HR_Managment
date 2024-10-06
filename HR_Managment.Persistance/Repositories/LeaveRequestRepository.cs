using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.Contracts.Persistence.Common;
using HR_Managment.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Managment.Persistance.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly LeaveManagmentDbContext _context;
        public LeaveRequestRepository(LeaveManagmentDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        {
            var leaveRequest = await _context.LeaveRequests.Include(t => t.LeaveType).FirstOrDefaultAsync();
            return leaveRequest;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
        {
            var leaveRequest = await _context.LeaveRequests.Include(t => t.LeaveType).ToListAsync();
            return leaveRequest;
        }

        public async Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approvalStatus)
        {
            leaveRequest.Approved = approvalStatus;
            _context.Entry(leaveRequest).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
