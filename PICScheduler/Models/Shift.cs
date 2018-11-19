using System;
using System.Collections.Generic;
using System.Text;

namespace PICScheduler.Models
{
    public class Shift
    {
        public string Name { get; set; }
        public NurseLevel NurseLevel { get; set; }
        public int Hours { get; set; }
        public string Day { get; set; }
        public int Week { get; set; }
        public long NurseId { get; set; }
    }
}
