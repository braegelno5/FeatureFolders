using System;

namespace WebApiApplication.Models
{
    public class EmployeeResultModel
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTimeOffset CreationDate { get; set; }
    }
}
