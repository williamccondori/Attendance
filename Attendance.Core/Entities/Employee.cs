using System;

namespace Attendance.Core.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        private string Name { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
        public string IsEnabled { get; set; }
        public Group Group { get; set; }
        public JournalHour JournalHourId { get; set; }

        public static Employee Create(string name)
        {
            return new Employee
            {
                Name = name
            };
        }
    }
}