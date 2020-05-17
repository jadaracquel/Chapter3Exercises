using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3Exercises1_5
{
    class Program
    {
        public static double GetHours(String prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            double wkPay;   //weekly pay
            double hrPay = 7.50;    //hourly pay
            double OTPay = 11.25;   //overtime pay
            double overtime;
            double hours = GetHours("Enter number of hours worked: ");
            if (hours > 40.0)
            {
                overtime = hours - 40.0;
                wkPay = (hrPay * 40) + (OTPay * overtime);
            }
            else
            {
                wkPay = hrPay * hours;
            }
            Console.WriteLine("Week's Pay: {0:C}", wkPay);
        }
    }
}
