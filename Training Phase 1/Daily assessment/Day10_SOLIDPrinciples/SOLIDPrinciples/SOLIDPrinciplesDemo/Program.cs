class Program
{
    static void Main(string[] args)
    {
        // Create EmployeeDao object
        EmployeeDao employeeDao = new EmployeeDao();

        // Create some Employee objects
        Employee emp1 = new Employee(123, "John Doe", 50000);
        Employee emp2 = new Employee(124, "Jane Smith", 60000);

        // Add employees to the list
        employeeDao.AddEmployeeDetails(emp1);
        employeeDao.AddEmployeeDetails(emp2);

        // Show employee details
        employeeDao.ShowEmployeeDetails(123); // Should show "John Doe"
        employeeDao.ShowEmployeeDetails(124); // Should show "Jane Smith"

        // Trying to show a non-existing employee
        employeeDao.ShowEmployeeDetails(999); // Should say "Employee not found"
    }
}
