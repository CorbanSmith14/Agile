using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dropbox11
{
    public class Parttime : Employee
    {
        public double HourlyWage { get; set; }
        public double HoursWorked { get; set; }

        public Parttime(string EmployeeID, string Employeename, double hourlyWage, double hoursWorked)
            : base(EmployeeID, Employeename, 0) // Salary is set to 0 for part-time employees
        {
            HourlyWage = hourlyWage;
            HoursWorked = hoursWorked;
        }

        //weekly pay class for parttime
        public override double GetPaidWeekly()
        {
            return HourlyWage * HoursWorked;
        }
    }
}
