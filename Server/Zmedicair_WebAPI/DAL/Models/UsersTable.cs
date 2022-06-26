using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class UsersTable
    {
        public UsersTable()
        {
            DailyMonitoringTables = new HashSet<DailyMonitoringTable>();
            MessagesTableUserIdFromWhoNavigations = new HashSet<MessagesTable>();
            MessagesTableUserIdToWhoNavigations = new HashSet<MessagesTable>();
            ShoppingTables = new HashSet<ShoppingTable>();
        }

        public short UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public DateTime UserDateOfBirth { get; set; }
        public string UserEmail { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserStatus { get; set; }
        public string UserPassword { get; set; }

        public virtual ICollection<DailyMonitoringTable> DailyMonitoringTables { get; set; }
        public virtual ICollection<MessagesTable> MessagesTableUserIdFromWhoNavigations { get; set; }
        public virtual ICollection<MessagesTable> MessagesTableUserIdToWhoNavigations { get; set; }
        public virtual ICollection<ShoppingTable> ShoppingTables { get; set; }
    }
}
