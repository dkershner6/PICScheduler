using System;
using System.Collections.Generic;
using System.Text;

namespace PICScheduler.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public NurseLevel NurseLevel { get; set;}
        public int? Priority { get; set; }
        public bool? NightPreference { get; set; }
        public int? SundayPreference { get; set; }
        public int? MondayPreference { get; set; }
        public int? TuesdayPreference { get; set; }
        public int? WednesdayPreference { get; set; }
        public int? ThursdayPreference { get; set; }
        public int? FridayPreference { get; set; }
        public int? SaturdayPreference { get; set; }
    }

    public enum NurseLevel
    {
        RN,
        MA
    }
}
