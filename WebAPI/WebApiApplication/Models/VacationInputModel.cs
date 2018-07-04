using System;

namespace WebApiApplication.Models
{
    public class VacationInputModel
    {
        public int EmployeeId { get; set; }

        public DateTimeOffset Begin { get; set; }

        public DateTimeOffset End { get; set; }
    }
}
