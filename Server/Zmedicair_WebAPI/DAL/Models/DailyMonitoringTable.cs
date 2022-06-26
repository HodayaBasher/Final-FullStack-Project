using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DailyMonitoringTable
    {
        public short DailyId { get; set; }
        public short UserId { get; set; }
        public DateTime DailyDateAndTime { get; set; }
        public string DailyFeeling { get; set; }

        public virtual UsersTable User { get; set; }
    }
}
