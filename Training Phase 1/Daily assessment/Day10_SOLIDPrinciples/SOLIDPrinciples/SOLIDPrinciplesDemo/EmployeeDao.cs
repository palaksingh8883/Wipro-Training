using System;
using System.Collections.Generic;

public class EmployeeDao : IAddOperation, IGetOperation
{
    private List<Employee> employeeList = new List<Employee>();

    // Implementing AddEmployeeDetails from IAddOperation interface
    public bool AddEmployeeDetails(Employee employee)
    {
        employeeList.Add(employee); // Add employee to the list
        Console.WriteLine($"Employee {employee.Name} added successfully.");
        return true;
    }

    // Implementing ShowEmployeeDetails from IGetOperation interface
    public bool ShowEmployeeDetails(int employeeId)
    {
        var employee = employeeList.Find(e => e.Empno == employeeId);
        if (employee != null)
        {
            Console.WriteLine($"Employee Found: {employee.Name}, Basic: {employee.Basic}");
            return true;
        }
        else
        {
            Console.WriteLine("Employee not found.");
            return false;
        }
    }
}
