using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox08
{
    internal class Employee
    {
        public string EmployeeName { get; set; }
        public double PayRate { get; set; }
        public double HoursWorked { get; set; }

        // Constructor
        public Employee(string _name, double _payRate, double _hoursWorked)
        {
            EmployeeName = _name;
            PayRate = _payRate;
            HoursWorked = _hoursWorked;
        }

        // Method to calculate the total pay for the employee
        public double GetPayAmount()
        {
            return PayRate * HoursWorked;
        }
    }
}
