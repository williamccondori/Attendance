using Attendance.Core.Repositories;
using Attendance.Infrastructure.PostgreSQL.Attendance.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Attendance.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}