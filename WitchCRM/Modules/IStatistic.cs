﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitchCRM.Modules
{
    interface IStatistic
    {
        long TotalClientsCount { get; set; }
        decimal TotalClientsPrise { get; set; }
        long TotalWorkDays { get; set; }
        decimal AvgDaylyPrise { get; set; }
        decimal AvgPayCheque { get; set; }
        decimal AvgDailyLoad { get; set; }
    }
}
