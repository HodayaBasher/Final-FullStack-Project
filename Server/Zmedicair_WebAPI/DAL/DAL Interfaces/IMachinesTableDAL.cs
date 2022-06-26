using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL.DAL_Interfaces
{
    public interface IMachinesTableDAL
    {
        //שליפת כל המכשירים
        List<MachinesTables> GetAllMachines();

        //שליפת מוצר לפי קוד
        public MachinesTables GetMachineByID(short id);

        //הוספת מכשיר לרשימת המכשירים
        public string AddMachine(MachinesTables t);

        //עידכון מכשיר ברשימת המכשירים
        public List<MachinesTables> UpdateMachine(MachinesTables t);

        //הסרת מכשיר מרשימת המכשירים
        public MachinesTables DeleteMachine(short id);


    }
}
