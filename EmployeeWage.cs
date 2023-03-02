using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesOOPS
{
    public class EmployeeWage
    {
        public static int RATEPERHOUR = 20;
        
        public static bool Attendance()
        {
            int isPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == isPresent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int dailyWages()
        {
            int workHours = 0;
            bool empData=Attendance();
            if (empData == true)
            {
                workHours = 8;
            }
            else
            {
                workHours = 0;
            }
            int dailyWage = workHours * RATEPERHOUR;
            return dailyWage;

        }

    }
}
