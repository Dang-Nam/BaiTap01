using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class SalaryCalculator
    {
        // Phương thức tính lương dựa trên số ngày làm việc và tiền công mỗi ngày
        public double CalculateSalary(int workDays, double dailyWage)
        {
            // Tính lương: số ngày làm việc * tiền công mỗi ngày
            return workDays * dailyWage;
        }
    }
}
