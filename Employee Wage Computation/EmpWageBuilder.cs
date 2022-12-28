using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation
{
    public class EmpWageBuilder
    {
        public static void CheckAttendance()
        {
            int Full_Time = 1;
            int Part_Time = 2;
            int Emp_Per_Hours = 20;
            int empHrs, empWage;
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == Full_Time)
            {
                empHrs = 8;
            }
            else if (check == Part_Time)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Per_Hours;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}
