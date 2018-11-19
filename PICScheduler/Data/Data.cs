using PICScheduler.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PICScheduler.Data
{
    public class Data
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee{ Id = 1, Name = "Sarah", Priority = 1, NurseLevel = NurseLevel.RN, NightPreference = false, SundayPreference = 7, SaturdayPreference = 6, FridayPreference = 5, WednesdayPreference = 4, ThursdayPreference = 3, TuesdayPreference = 2, MondayPreference = 1},
            new Employee{ Id = 1, Name = "Dani", Priority = 2, NurseLevel = NurseLevel.RN, NightPreference = false, SundayPreference = 7, SaturdayPreference = 6, FridayPreference = 5, WednesdayPreference = 4, ThursdayPreference = 3, TuesdayPreference = 2, MondayPreference = 1},
        };
    }
}
