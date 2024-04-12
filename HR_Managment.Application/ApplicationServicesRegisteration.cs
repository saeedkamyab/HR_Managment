using HR_Managment.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HR_Managment.Application
{
    public static class ApplicationServicesRegisteration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services)
        {
            //  services.AddAutoMapper(typeof(MappingProfile)); in this way you have to call a specific file name but in below way it find automatically
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
