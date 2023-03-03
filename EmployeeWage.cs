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
        public const int ISFULLTIME = 2;
        public const int ISPARTTIME = 1;
        public static Random random = new Random();
        public static int empCheck = random.Next(0, 3);
        public static int MAX_WORK_DAYS = 20;
        public static int TotalHours()
        {
            int maxWorkMounth = 10;
            int workHours = 0,totWages=0, monthlyWage=0,totHours=0,totDays=0;
            while(workHours <= MAX_WORK_DAYS && totDays<= maxWorkMounth) {
                totDays++;
                switch (empCheck)
                {
                    case ISFULLTIME:
                        workHours = 8;

                        break;
                    case ISPARTTIME:
                        workHours = 4;
                        break;

                    default:
                        workHours = 0;
                        break;

                }
                totHours = totHours + workHours;


            }
            totWages = totHours * RATEPERHOUR;
            return totWages;
        }
    }
}
