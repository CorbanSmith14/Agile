using dropbox08;
class program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Corban Smith", 21, 35);
        double totalPay = employee1.GetPayAmount();

        Console.WriteLine("Employee Name: " + employee1.EmployeeName);
        Console.WriteLine("Pay Rate: $" + employee1.PayRate);
        Console.WriteLine("Hours Worked: " + employee1.HoursWorked);
        Console.WriteLine("Total Pay: $" + totalPay);

        Employee employee2 = new Employee("Jon Thomas", 26, 32);
        double totalpay = employee2.GetPayAmount();

        Console.WriteLine("Employee Name: " + employee2.EmployeeName);
        Console.WriteLine("Pay Rate: $" + employee2.PayRate);
        Console.WriteLine("Hours Worked: " + employee2.HoursWorked);
        Console.WriteLine("Total Pay: $" + totalPay);
    }
}

