using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dropbox11
{
    internal class Fulltime : Employee
    {

        public Fulltime(string EmployeeID, string Employeename, double salary)
        : base(EmployeeID, Employeename, salary)
        {
        //Fulltime Employee class is created
        }


        //weeklypay class for fulltime
        public override double GetPaidWeekly()
        {
            return Math.Round(Salary / 52, 2);
        }
    }
}
