using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectDumpConsoleSample
{
    public class Employee
    {
        public Employee()
        {
            Roles = new List<EmployeeRole>();
        }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<EmployeeRole> Roles { get; set; }
    }

    public class EmployeeRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
