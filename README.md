# ObjectDump
Extension method on object to dump all the values using Microsoft.Extensions.Logging.ILogger and System.Text.Json

```csharp
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
```
The extension method can be used as following on Employee class

```csharp
Employee emp = new Employee { EmployeeId = 1, FirstName = "EmployeeFirstName", LastName = "EmployeeLastName" };
emp.Roles.Add(new EmployeeRole { RoleId = 1, RoleName = "Manager" });
emp.Roles.Add(new EmployeeRole { RoleId = 2, RoleName = "Leader" });
emp.DumpProperties();

//Output
{
  "EmployeeId": 1,
  "FirstName": "EmployeeFirstName",
  "LastName": "EmployeeLastName",
  "Roles": [
    {
      "RoleId": 1,
      "RoleName": "Manager"
    },
    {
      "RoleId": 2,
      "RoleName": "Leader"
    }
  ]
}
```
It has overloaded method where in we can pass an instance of Microsoft.Extensions.Logging.ILogger which will be used to write the output using LogInformation() method
