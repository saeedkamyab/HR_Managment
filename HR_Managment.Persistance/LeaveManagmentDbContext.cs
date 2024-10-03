using HR_Managment.Domain.Models;
using HR_Managment.Domain.Models.Common;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaveManagmentDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity<int>>())
            {
               entry.Entity.LastModified=DateTime.Now;
               if (entry.State == EntityState.Added)
               {
                   entry.Entity.CreatedDateTime=DateTime.Now;
               }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess,cancellationToken);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity<int>>())
            {
                entry.Entity.LastModified = DateTime.Now;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedDateTime = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}
