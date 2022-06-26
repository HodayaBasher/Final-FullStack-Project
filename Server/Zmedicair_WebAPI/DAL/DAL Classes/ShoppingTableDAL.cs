using DAL.DAL_Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DAL.DAL_Classes
{
    public class ShoppingTableDAL:IShoppingTableDAL
    {
        Zmedicair_DBContext _DB;
        public ShoppingTableDAL(Zmedicair_DBContext _db)
        {
            _DB = _db;
        }
        //שליפת רשימת כל הקניות
        public List<ShoppingTable> GetAllShopping()
        {
            return _DB.ShoppingTables.ToList();
        }

        //הוספת קניה לרשימת הקניות
        public string AddShopping(ShoppingTable s)
        {

            try
            {
                _DB.ShoppingTables.Add(s);
                _DB.SaveChanges();
                return "Succeeded!";
            }
            catch
            {
                return "Fails";
            }
        }

        //הסרת קניה מרשימת הקניות
        public ShoppingTable DeleteShopping(short id)
        {
            var ShoppingToDelete = _DB.ShoppingTables.FirstOrDefault(p => p.ShoppingId == id);
            _DB.ShoppingTables.Remove(ShoppingToDelete);
            _DB.SaveChanges();
            return ShoppingToDelete;
        }

        //שליפת קניה לפי קוד
        public ShoppingTable GetShoppingById(short id)
        {
            var getShoppingById = _DB.ShoppingTables.FirstOrDefault(p => p.ShoppingId == id);
            if (getShoppingById != null)
            {
                return getShoppingById;
            }
            return null;
        }

        //עידכון קניה ברשימת הקניות
        public List<ShoppingTable> UpdateShopping(ShoppingTable s)
        {
            var ShoppingToEdit = _DB.ShoppingTables.FirstOrDefault(p => p.ShoppingId == s.ShoppingId);
            if (ShoppingToEdit != null)
            {
                ShoppingToEdit.UserId = s.UserId;
                ShoppingToEdit.ShoppingDate = s.ShoppingDate;
                ShoppingToEdit.ShoppingSum = s.ShoppingSum;
                _DB.SaveChanges();
                return _DB.ShoppingTables.ToList();
            }
            return null;
        }
    }
}
