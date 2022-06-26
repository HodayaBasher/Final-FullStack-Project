using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class MachinesTableDTO
    {

        public short MachineId { get; set; }
        public string MachineName { get; set; }
        public decimal MachinePrice { get; set; }
        public int MachineUnitsInStack { get; set; }
        public string MachineDescription { get; set; }
        public double MachineLength { get; set; }
        public double MachineWidth { get; set; }
        public double MachineHeight { get; set; }
        public double MachineWeight { get; set; }
        public string MachineImg { get; set; }
    }
}
