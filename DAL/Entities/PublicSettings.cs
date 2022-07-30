﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class PublicSettings
    {
        public int Id { get; set; }
        public int ExtraHours { get; set; }
        public int MissingHours { get; set; }
        public DayOfWeek Weekend1 { get; set; }
        public DayOfWeek? Weekend2 { get; set; }


    }
}
