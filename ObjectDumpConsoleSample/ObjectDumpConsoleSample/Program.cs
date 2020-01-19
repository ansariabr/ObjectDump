using Microsoft.Extensions.Logging;
using ObjectDumpHelper;
using System;

namespace ObjectDumpConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
            });

            Employee emp = new Employee { EmployeeId = 1, FirstName = "EmployeeFirstName", LastName = "EmployeeLastName" };
            emp.Roles.Add(new EmployeeRole { RoleId = 1, RoleName = "Manager" });
            emp.Roles.Add(new EmployeeRole { RoleId = 2, RoleName = "Leader" });

            emp.DumpProperties(loggerFactory.CreateLogger<Program>());
            Console.ReadKey();
        }
    }
}
