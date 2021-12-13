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
                Console.WriteLine("2.DAILY WAGE OF EMPLOYEES");
                Console.WriteLine("3.PART TIME EMPLOYEE WAGE ADDED");
                Console.WriteLine("4.USING SWITCH CASE");
                Console.WriteLine("ENTER YOUR OPTION");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Attendance.Attendace check = new Attendance.Attendace();
                        check.Present();
                        check.Empcheck();
                        break;
                    case 2:
                        DailyWage.Daily_Wage wage = new DailyWage.Daily_Wage();
                        wage.Wage();
                        wage.Time();
                        break;
                    case 3:
                        PartTime.Part_Time myObj = new PartTime.Part_Time();
                        myObj.Parttime();
                        myObj.wage();
                        break;
                    case 4:
                        SwitchCase.Switch_Case employee = new SwitchCase.Switch_Case();
                        employee.Case();
                        employee.Empwage();
                        break;
                    default:
                        Console.WriteLine("ENTER CORRECT OPTION: ");
                        break;
                }
            }
        }
    }
    }

