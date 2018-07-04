using System;

namespace FeatureFolderWebApiApplication.Vacation
{
    public class VacationInputModel
    {
        public int EmployeeId { get; set; }

        public DateTimeOffset Begin { get; set; }

        public DateTimeOffset End { get; set; }
    }
}
