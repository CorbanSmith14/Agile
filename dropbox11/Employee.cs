using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace dropbox11
{
    public abstract class Employee
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
        //abstract, each employee class calls own pay type
        public abstract double GetPaidWeekly();

        public string Tostring ()
        {
            return $"Employee ID: {EmployeeID}, Name: {Employeename}";
        }

    }
}
