using HR_Managment.Application.Contracts.Persistence.Common;
using HR_Managment.Domain.Models;

namespace HR_Managment.Application.Contracts.Persistence
{
    public interface ILeaveRequestRepository:IBaseRepository<int,LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest,bool? approvalStatus);
    }
}
