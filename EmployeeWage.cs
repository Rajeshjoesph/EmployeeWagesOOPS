namespace EmployeeWagesOOPS
{
    public class EmployeeWage
    {
        public static int RATEPERHOUR = 20;
        public static int ISFULLTIME = 2;
        public static int ISPARTTIME = 1;
        public static bool Attendance()
        {
            int isPresent = 1;
            Random random = new Random();
            int empCheck = random.Next(0,2);
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
            Random random = new Random();
            int empCheck = random.Next(0, 3);
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
    }
}
