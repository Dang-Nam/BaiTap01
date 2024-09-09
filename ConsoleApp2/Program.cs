using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;  // Thêm namespace của thư viện DLL

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập số ngày công và tiền công mỗi ngày
            Console.Write("Nhập số ngày công: ");
            int workDays = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập tiền công mỗi ngày: ");
            double dailyWage = Convert.ToDouble(Console.ReadLine());

            // Sử dụng lớp SalaryCalculator từ DLL
            SalaryCalculator calculator = new SalaryCalculator();

            // Tính lương
            double totalSalary = calculator.CalculateSalary(workDays, dailyWage);

            // Hiển thị kết quả
            Console.WriteLine("Tổng lương: " + totalSalary);

            // Giữ cửa sổ console mở
            Console.ReadLine();
        }
    }
}
