using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ShoppingInformationTable
    {
        public short ShoppingInformationId { get; set; }
        public short ShoppingId { get; set; }
        public short MachineId { get; set; }
        public int ShoppingAmount { get; set; }

        public virtual MachinesTables Machine { get; set; }
        public virtual ShoppingTable Shopping { get; set; }
    }
}
