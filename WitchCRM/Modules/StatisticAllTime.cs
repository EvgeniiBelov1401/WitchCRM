using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitchCRM.Modules
{
    public class StatisticAllTime : IStatistic
    {
        public long TotalClientsCount { get; set; }
        public decimal TotalClientsPrise { get; set; }
        public long TotalWorkDays { get; set; }
        public decimal AvgDaylyPrise { get; set; }
        public decimal AvgPayCheque { get; set; }
        public decimal AvgDailyLoad { get; set; }
        public long SourceInstagramCount { get; set; }
        public long SourceTelegramCount { get; set; }
        public long SourceWhatsAppCount { get; set; }
        public long StatusNewClientCount { get; set; }
        public long StatusRepeatClientCount { get; set; }
    }
}
