using DAL.DAL_Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL_Classes
{
    public class ShoppingInformationTableDAL : IShoppingInformationTableDAL
    {
        Zmedicair_DBContext _DB;
        public ShoppingInformationTableDAL(Zmedicair_DBContext _db)
        {
            _DB = _db;
        }
        //שליפת רשימת כל פרטי הקניות
        public List<ShoppingInformationTable> GetAllShoppingInformation()
        {
            return _DB.ShoppingInformationTables.ToList();
        }
        //הוספת פרטי קניה לרשימת פרטי הקניות
        public string AddShoppingItem(ShoppingInformationTable s)
        {
            try
            {
                _DB.ShoppingInformationTables.Add(s);
                _DB.SaveChanges();
                return "Succeeded!";
            }
            catch
            {
                return "Fails";
            }
        }

        //הסרת פרטי קניה מרשימת פרטי הקניות
        public ShoppingInformationTable DeleteShoppingItem(short id)
        {
            var ShoppingItemToDelete = _DB.ShoppingInformationTables.FirstOrDefault(p => p.ShoppingInformationId == id);
            _DB.ShoppingInformationTables.Remove(ShoppingItemToDelete);
            _DB.SaveChanges();
            return ShoppingItemToDelete;
        }


        //שליפת פרטי קניה לפי קוד
        public ShoppingInformationTable GetShoppingItemById(short id)
        {
            var getShoppingItemById = _DB.ShoppingInformationTables.FirstOrDefault(p => p.ShoppingInformationId == id);
            if (getShoppingItemById != null)
            {
                return getShoppingItemById;
            }
            return null;
        }

        //עידכון קניה ברשימת הקניות
        public List<ShoppingInformationTable> UpdateShoppingItem(ShoppingInformationTable s)
        {
            var ShoppingItemToEdit = _DB.ShoppingInformationTables.FirstOrDefault(p => p.ShoppingInformationId == s.ShoppingInformationId);
            if (ShoppingItemToEdit != null)
            {
                ShoppingItemToEdit.ShoppingId = s.ShoppingId;
                ShoppingItemToEdit.MachineId = s.MachineId;
                ShoppingItemToEdit.ShoppingAmount = s.ShoppingAmount;
                _DB.SaveChanges();
                return _DB.ShoppingInformationTables.ToList();
            }
            return null;
        }
    }
}
