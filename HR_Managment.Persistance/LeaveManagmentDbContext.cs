using HR_Managment.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Managment.Persistance
{
    public class LeaveManagmentDbContext:DbContext
    {
        public LeaveManagmentDbContext(DbContextOptions<LeaveManagmentDbContext>options):base(options)
        {
            
        }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}
