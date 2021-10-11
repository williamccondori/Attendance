using Attendance.Core.Entities;
using Attendance.Core.Repositories;

namespace Attendance.Application.Services.Operations
{
    public class CreateEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public CreateEmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void Execute()
        {
            var employee = Employee.Create("");
            _employeeRepository.Create(employee);
        }
    }
}