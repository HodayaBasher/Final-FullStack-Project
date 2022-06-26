using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL.DAL_Interfaces
{
    public interface IShoppingInformationTableDAL
    {
        List<ShoppingInformationTable> GetAllShoppingInformation();


        //שליפת פרטי קניה לפי קוד
        ShoppingInformationTable GetShoppingItemById(short id);

        //הוספת פרטי קניה לרשימת פרטי הקניות
        string AddShoppingItem(ShoppingInformationTable s);

        //עידכון קניה ברשימת הקניות
        List<ShoppingInformationTable> UpdateShoppingItem(ShoppingInformationTable s);

        //הסרת פרטי קניה מרשימת פרטי הקניות
        ShoppingInformationTable DeleteShoppingItem(short id);
    }
}
