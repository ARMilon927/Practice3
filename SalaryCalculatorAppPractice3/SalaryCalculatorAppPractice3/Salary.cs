using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorAppPractice3
{
    class Salary
    {
        public string employeeName;
        public double basicAmount;
        public double totalSalary;

        public double GetTotalSalary(double rent, double medical)
        {
            totalSalary = basicAmount + basicAmount * (rent + medical) / 100;
            return totalSalary;
        }
    }
}
