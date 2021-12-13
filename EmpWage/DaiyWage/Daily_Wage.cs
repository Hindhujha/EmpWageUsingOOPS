using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage.DailyWage
{
    internal class Daily_Wage
    {
        const int IS_FULL_TIME = 1;
        const int RATE_PER_HR = 20;
        int empHrs;
        int empWage;
        int empCheck;
        public void Wage()
        {
            
            Random random = new Random();
            empCheck = random.Next(0, 2);
        }
        public void Time()
        {
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * RATE_PER_HR;
            Console.WriteLine("Employee wage is:" + empWage);
        }
           
        }
    }

    

