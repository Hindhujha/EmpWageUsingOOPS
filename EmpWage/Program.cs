using System;
namespace EmpWage
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAMS");
          
            while (true)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("1.EMPLOYEES ATTENDANCE");
                
                Console.WriteLine("ENTER YOUR OPTION");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Attendance.Attendace check = new Attendance.Attendace();
                        check.Present();
                        check.Empcheck();
                        break;
                   
                    default:
                        Console.WriteLine("ENTER CORRECT OPTION: ");
                        break;
                }
            }
        }
    }
    }

