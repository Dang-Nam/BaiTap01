﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BaiToanTinhLuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập số ngày công làm việc
            Console.Write("Nhập số ngày công: ");
            int workDays = Convert.ToInt32(Console.ReadLine());

            // Nhập tiền công mỗi ngày
            Console.Write("Nhập tiền công mỗi ngày: ");
            double dailyWage = Convert.ToDouble(Console.ReadLine());

            // Tính tổng lương
            double totalSalary = workDays * dailyWage;

            // Xuất kết quả
            Console.WriteLine("Tổng lương: " + totalSalary);

            // Giữ cửa sổ console mở
            Console.ReadLine();
        }
    }

}
