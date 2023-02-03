using ChallengeApp;

Employee employee1 = new Employee("Alojzy", "Pietruszka", 18);
Employee employee2 = new Employee("Baltazar", "Gąbka", 46);
Employee employee3 = new Employee("Mieszko", "Pierwszy", 82);

employee1.AddPoint(4);
employee1.AddPoint(2);
employee1.AddPoint(5);
employee1.AddPoint(1);
employee1.AddPoint(3);

employee2.AddPoint(10);
employee2.AddPoint(3);
employee2.AddPoint(1);
employee2.AddPoint(9);
employee2.AddPoint(4);

employee3.AddPoint(5);
employee3.AddPoint(1);
employee3.AddPoint(4);
employee3.AddPoint(1);
employee3.AddPoint(9);

List<Employee> Employees = new List<Employee>()
{
  employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeMaxResult = null;

foreach (var employee in Employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeMaxResult = employee;
    }
}
 Console.WriteLine("Pracownik z najlepszym wynikiem:");
Console.WriteLine(employeeMaxResult.Name + " " + employeeMaxResult.Surname + ", lat " + employeeMaxResult.Age);
Console.WriteLine("Jego wynik to " + employeeMaxResult.Result);
    