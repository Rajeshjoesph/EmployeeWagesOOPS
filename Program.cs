﻿namespace EmployeeWagesOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Employee Attendance
            bool attendance = EmployeeWage.Attendance();
            Console.WriteLine("Employee is attendence is :" + attendance);
            // Employee Daily Wages
            int dayWage=EmployeeWage.dailyWages();
            Console.WriteLine("\nEmployee Wages per Day:" + dayWage);
        }
    }
}