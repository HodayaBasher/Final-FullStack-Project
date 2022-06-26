using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ShoppingTable
    {
        public ShoppingTable()
        {
            ShoppingInformationTables = new HashSet<ShoppingInformationTable>();
        }

        public short ShoppingId { get; set; }
        public short UserId { get; set; }
        public DateTime ShoppingDate { get; set; }
        public decimal? ShoppingSum { get; set; }
        public virtual UsersTable User { get; set; }
        public virtual ICollection<ShoppingInformationTable> ShoppingInformationTables { get; set; }
    }
}
