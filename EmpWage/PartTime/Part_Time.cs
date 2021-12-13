using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage.PartTime
{
    internal class Part_Time
    {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 0;
        const int rate_per_hr = 20;
        int part_time_empHrs = 0;
        int full_time_empHrs = 0;
        int full_time_empWage;
        int part_time_empWage;
        int empCheck;
        public void Parttime()
        {
          
        Random random = new Random();
        empCheck = random.Next(0, 2);
    }
    public void wage()
    {
        if (empCheck == IS_FULL_TIME || empCheck == IS_PART_TIME)
        {
            full_time_empHrs = 16;
            part_time_empHrs = 8;

        }


        full_time_empWage = rate_per_hr * full_time_empHrs;
        part_time_empWage = rate_per_hr * part_time_empHrs;
        Console.WriteLine("FULL TIME EMPLOYEE WAGE IS:" + full_time_empWage);
        Console.WriteLine("PART TIME EMPLOYEE WAGE IS:" + part_time_empWage);
    }

        }
    }







