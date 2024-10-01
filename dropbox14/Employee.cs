using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox14
{
    internal class Employee
    {
        private string employeeId;
        private string name;
        private decimal payrate;
        private decimal hoursworked;
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Payrate
        {
            get { return payrate; }
            set { payrate = value; }
        }
        public decimal Hoursworked
        {
            get { return hoursworked; }
            set { hoursworked = value; }
        }
 
        public Employee(string employeeId, string name, decimal payrate, decimal hoursworked)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.payrate = payrate;
            this.hoursworked = hoursworked;
        }
        public Employee(string employeeId, string name, decimal payrate)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.payrate = payrate;
        }

        public decimal PayAmount()
        {
            decimal amount;
            amount = Payrate * Hoursworked;
            return amount;
        }
        public override string ToString()
        {
            string str;
            str = $"{EmployeeId}\n{Name}\n{Payrate}\n{Hoursworked}";
            return str;
        }
    }
}
