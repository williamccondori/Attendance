using System;

namespace Attendance.Core.Entities
{
    public class JournalHour
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
    }
}