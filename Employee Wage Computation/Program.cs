using System;

namespace Employee_Wage_Computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder.computeEmpWage("TCS", 20, 2, 10);
            EmpWageBuilder.computeEmpWage("Capgemini", 20, 4, 10);
        }
    }
}
