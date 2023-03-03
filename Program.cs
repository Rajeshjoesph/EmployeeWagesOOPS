namespace EmployeeWagesOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Employee Attendance
            //bool attendance = EmployeeWage.Attendance();
            //Console.WriteLine("Employee is attendence is :" + attendance);
            // Employee Daily Wages
            int dayWage = EmployeeWage.SwitchCase();
            Console.WriteLine("\nEmployee Wages per Day:" + dayWage);
            // Employee monthly Wages
            Console.WriteLine("\nEmployee monthly wages: "+EmployeeWage.MonthlyWage());
        }
    }
}