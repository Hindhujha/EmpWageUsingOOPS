using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage.Attendance
{
    internal class Attendace
    {
        const int IS_FULL_TIME = 1;
        int empCheck;
        public void Present()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
        }
        public void Empcheck()
        { 
    
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("EMPLOYEE IS PRESENT");
            }
            else
            {
                Console.WriteLine("EMPLOYEE IS ABSENT");
            }
        }
}
    

}

