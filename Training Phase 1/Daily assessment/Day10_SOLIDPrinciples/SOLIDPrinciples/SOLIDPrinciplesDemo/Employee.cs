public class Employee
{
    public int Empno { get; set; }
    public string Name { get; set; }
    public double Basic { get; set; }

    // Constructor for Employee
    public Employee(int empno, string name, double basic)
    {
        Empno = empno;
        Name = name ?? throw new ArgumentNullException(nameof(name)); // Ensure Name is not null
        Basic = basic;
    }
}
