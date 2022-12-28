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
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
