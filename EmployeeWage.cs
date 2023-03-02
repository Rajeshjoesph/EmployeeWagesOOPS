using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageOOPS
{
    public class EmployeeWage
    {
        public static bool Attendance()
        {
            int isPresent = 1;
            Random random=new Random();
            int empCheck = random.Next(0, 2);
            if(empCheck == isPresent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
