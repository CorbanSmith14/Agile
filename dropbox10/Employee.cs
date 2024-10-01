using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dropbox10
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string Employeename { get; set; }
        public double Salary { get; set; }  
        // Constructor
        public Employee(string _ID, string _name, double _salary)
        {
            EmployeeID = _ID;
            Employeename = _name;
            Salary = _salary;
        }
        public virtual double GetPaidWeekly()
        {
            return Math.Round(Salary / 52,2);
        }
        public string Tostring ()
        {
            return $"Employee ID: {EmployeeID}, Name: {Employeename}";
        }

    }
}
