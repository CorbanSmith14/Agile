using dropbox11;

class program
{ 

    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        Fulltime fullTimeEmployee1 = new Fulltime("1", "John Doe", 83000);

        Fulltime fullTimeEmployee2 = new Fulltime("2", "Kevin James", 59000);

        Parttime partTimeEmployee1 = new Parttime("3", "Jane Fonda", 18, 23);

        Parttime partTimeEmployee2 = new Parttime("4", "Lebron James", 25, 30);

        employees.Add(fullTimeEmployee1);
        employees.Add(fullTimeEmployee2);
        employees.Add(partTimeEmployee1);
        employees.Add(partTimeEmployee2);

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.Tostring());
            Console.WriteLine("Weekly pay: $" + employee.GetPaidWeekly());
            Console.WriteLine();
        }
    }

}