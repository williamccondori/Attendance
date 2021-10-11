using System;

namespace Attendance.Core.Entities
{
    public class Attendance
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public Employee EmployeId { get; set; }
    }
}