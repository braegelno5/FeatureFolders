using System;

namespace FeatureFolderWebApiApplication.Vacation
{

    public class VacationResultModel
    {
        public int EmployeeId { get; set; }

        public DateTimeOffset Begin { get; set; }

        public DateTimeOffset End { get; set; }

        public bool? IsApproved { get; set; }

        public DateTimeOffset CreationDate { get; set; }
    }
}
