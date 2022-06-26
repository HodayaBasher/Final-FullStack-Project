using System;
using System.Collections.Generic;
using System.Text;
using DTO;


namespace BLL.BLL_Interfaces
{
    public interface IMachinesTableBLL
    {
        //שליפת כל המכשירים
        List<MachinesTableDTO> GetAllMachines();

        //הוספת מכשיר לרשימת המכשירים
        public string AddMachine(MachinesTableDTO t);

        //עידכון מכשיר ברשימת המכשירים
        public List<MachinesTableDTO> UpdateMachine(MachinesTableDTO t);

        //הסרת מכשיר מרשימת המכשירים
        public MachinesTableDTO DeleteMachine(short id);

        //שליפת מוצר לפי קוד
        public MachinesTableDTO GetMachineByID(short id);
    }
}
