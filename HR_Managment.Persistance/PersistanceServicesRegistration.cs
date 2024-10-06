using HR_Managment.Application.Contracts.Persistence;
using HR_Managment.Application.Contracts.Persistence.Common;
using HR_Managment.Domain.Models;
using HR_Managment.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Persistance
{
    public static class PersistanceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistanceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<LeaveManagmentDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("connectionString"));
            });
            
            services.AddScoped(typeof(IBaseRepository<>), typeof(GenericRepository<>));
           
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            
            return services;
        }

    }
}
