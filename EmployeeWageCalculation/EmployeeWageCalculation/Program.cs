using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
     public class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employee = new EmployeeWage();
            employee.Attendance();
            employee.DailyWage();
            employee.EmployeePartTime();
            employee.PartOrFullTIme();
            employee.CalculateWagesOfMonth();
            employee.TotalWorkingHours();
             

        }
    }
}
