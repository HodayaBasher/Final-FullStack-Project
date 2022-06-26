using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL.DAL_Interfaces
{
    public interface IShoppingTableDAL
    {
        //שליפת רשימת כל הקניות
        List<ShoppingTable> GetAllShopping();

        //שליפת קניה לפי קוד
        public ShoppingTable GetShoppingById(short id);

        //הוספת קניה לרשימת הקניות
        public string AddShopping(ShoppingTable s);

        //עידכון קניה ברשימת הקניות
        public List<ShoppingTable> UpdateShopping(ShoppingTable s);

        //הסרת קניה מרשימת הקניות
        public ShoppingTable DeleteShopping(short id);

    }
}
