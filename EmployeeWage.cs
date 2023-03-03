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

        public static int DailyWages()
        {
            int workHours = 0;
            if (empCheck == ISFULLTIME)
            {
                Console.WriteLine("Employee Full Time Wage: ");
                workHours = 8;
            }
            else if (empCheck == ISPARTTIME)
            {
                Console.WriteLine("Employee Part Time Wage: ");
                workHours = 4;
            }
            else
            {
                workHours = 0;
            }
            int dailyWage = workHours * RATEPERHOUR;
            return dailyWage;
        }
        public static int SwitchCase()
        {
            int workHours = 0;
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
            int dailyWage = workHours * RATEPERHOUR;
            return dailyWage;
        }
        public static int MonthlyWage()
        {
            int workHours = 0;
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
            int dailyWage = workHours * RATEPERHOUR;
            int monthlyWage = dailyWage * MAX_WORK_DAYS;
            return monthlyWage;
        }
    }
}
