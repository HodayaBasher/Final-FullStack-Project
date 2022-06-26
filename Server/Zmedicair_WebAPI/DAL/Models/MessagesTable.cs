using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class MessagesTable
    {
        public short MessagesId { get; set; }
        public short UserIdFromWho { get; set; }
        public short UserIdToWho { get; set; }

        public virtual UsersTable UserIdFromWhoNavigation { get; set; }
        public virtual UsersTable UserIdToWhoNavigation { get; set; }
    }
}
