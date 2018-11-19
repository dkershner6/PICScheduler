using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using PICScheduler.Data;
using PICScheduler.Models;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Shift> shifts = new List<Shift>();

            for (int i = 1; i <= 4; i++)
            {
                foreach (string Day in Data.Days)
                {
                    foreach (Shift shift in Data.Shifts)
                    {
                        shift.Day = Day;
                        shift.Week = i;
                        shifts.Add(shift);
                    }
                }
            }

            foreach (Employee employee in Data.Employees.OrderBy(e => e.Priority))
            {
                for (int i = 1; i <= 4; i++)
                {
                    
                }
            }

            Console.WriteLine(JsonConvert.SerializeObject(shifts));
            Console.ReadLine();
        }
    }
}
