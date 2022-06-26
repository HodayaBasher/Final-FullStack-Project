using DAL.DAL_Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL_Classes
{
    public class MachinesTableDAL:IMachinesTableDAL
    {
        Zmedicair_DBContext _DB;
        public MachinesTableDAL(Zmedicair_DBContext _db)
        {
            _DB = _db;

        }

        //שליפת כל מכשירים
        public List<MachinesTables> GetAllMachines()
        {
            return _DB.MachinesTables.ToList();
        }
        //הוספת מכשיר לרשימת המכשירים
        public string AddMachine(MachinesTables t)
        {
            try
            {
                _DB.MachinesTables.Add(t);
                _DB.SaveChanges();
                return "Succeeded!";
            }
            catch
            {
                return "Fails!";
            }
        }


        //הסרת מכשיר מרשימת המכשירים
        public MachinesTables DeleteMachine(short id)
        {
            var productToRemove = _DB.MachinesTables.FirstOrDefault(p => p.MachineId == id);
            _DB.MachinesTables.Remove(productToRemove);
            _DB.SaveChanges();
            return productToRemove;
        }


        //שליפת מכשיר לפי קוד
        public MachinesTables GetMachineByID(short id)
        {
            var getProductByID = _DB.MachinesTables.FirstOrDefault(p => p.MachineId == id);
            if (getProductByID != null)
            {
                return getProductByID;
            }
            return null;
        }

        //עידכון מכשיר ברשימת המכשירים
        public List<MachinesTables> UpdateMachine(MachinesTables t)
        {
            var productToUpdate = _DB.MachinesTables.FirstOrDefault(p => p.MachineId == t.MachineId);
            if (productToUpdate != null)
            {
                productToUpdate.MachineId = t.MachineId;
                productToUpdate.MachineName = t.MachineName;
                productToUpdate.MachinePrice = t.MachinePrice;
                productToUpdate.MachineUnitsInStack = t.MachineUnitsInStack;
                productToUpdate.MachineDescription = t.MachineDescription;
                productToUpdate.MachineLength = t.MachineLength;
                productToUpdate.MachineWidth = t.MachineWidth;
                productToUpdate.MachineHeight = t.MachineHeight;
                productToUpdate.MachineWeight = t.MachineWeight;


                _DB.SaveChanges();
                return GetAllMachines();
            }
            return null;
        }
    }
}
