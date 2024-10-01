using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox10
{
    internal class Fulltime : Employee
    {

        public Fulltime(string EmployeeID, string Employeename, double salary)
        : base(EmployeeID, Employeename, salary)
        {
        //Salary Field is called within Fulltime Class base but stored within Employee Class
        }
    }
}
