using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DailyMonitoringTableDTO
    {
        public short DailyId { get; set; }
        public short UserId { get; set; }
        public DateTime DailyDateAndTime { get; set; }
        public string DailyFeeling { get; set; }
    }
}
