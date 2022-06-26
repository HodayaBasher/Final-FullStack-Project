using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ShoppingInformationTableDTO
    {
        public short ShoppingInformationId { get; set; }
        public short ShoppingId { get; set; }
        public short MachineId { get; set; }
        public int ShoppingAmount { get; set; }
    }
}
