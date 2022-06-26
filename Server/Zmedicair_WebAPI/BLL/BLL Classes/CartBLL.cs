using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DAL.Models;
using DAL.DAL_Interfaces;
using BLL.BLL_Interfaces;

namespace BLL
{
    public class CartBLL : ICartBLL
    {
        //מופע מסוג ממשק קניה
        IShoppingTableDAL _shoppingDAL;
        //מופע מסוג ממשק פרטי קניה
        IShoppingInformationTableDAL _shoppingInformationDAL;
        //מופע מסוג ממשק מוצר
        IMachinesTableDAL _machineDAL;
        //מופע מסוג מסד הנתונים
        Zmedicair_DBContext _db;

        //הזרקת תלויות
        public CartBLL(IShoppingTableDAL _shoppingDAL, IShoppingInformationTableDAL _shoppingInformationDAL, IMachinesTableDAL _machineDAL, Zmedicair_DBContext _db)
        {
            this._shoppingDAL = _shoppingDAL;
            this._shoppingInformationDAL = _shoppingInformationDAL;
            this._machineDAL = _machineDAL;
            this._db = _db;
        }

        //פונקציה הבודקת את כמות המלאי
        //הפונקציה מקבלת מספר מזהה עבור מוצר מסוים
        //ואת הכמות שרוצים להזמין ממוצר זה
        public bool checkCountOfQtyStay(short prodID, short countBuy)
        {
            //קבלת המוצר על ידי מספר מזהה
            var someProd = _machineDAL.GetMachineByID(prodID);
            //אם המוצר אכן קיים
            if (someProd != null)
            {
                //בדיקה האם קיים מספיק כמות במלאי ממוצר זה-
                //אם הכמות במלאי קטנה מהכמות שרוצים להזמין
                //return false
                if (someProd.MachineUnitsInStack < countBuy)
                {
                    return false;
                }
                //אם יש מספיק כמות ממוצר זה במלאי
                //מתבצעת הזמנה- הורדת כמות במלאי לפי בקשת המזמין
                //return true
                else
                {
                    someProd.MachineUnitsInStack -= countBuy;
                    _db.SaveChanges();
                    return true;
                }
            }
            return false;
        }


        //פונקציה המוסיפה מוצר לסל קניות
        public List<bool> AddToCart(short id, List<CartDTO> c)
        {
            //רשימה המכילה ערכי אמת ושקר עבור כל מוצר בסל
            //האם ניתן להזמינו בכמות המבוקשת או שיש חוסר במלאי
            List<bool> a = new List<bool>();
            try
            {
                //סכום לתשלום
                decimal sum = 0;
                //מעבר על כל המוצרים בסל
                foreach (var item in c)
                {
                    //עבור כל מוצר בסל
                    //בדיקה האם קיים את הכמות שרוצים להזמין במלאי
                    bool check = checkCountOfQtyStay(item.ProductId, item.Qty);
                    //הכנסת הערך המתקבל לרשימה המכילה ערכי אמת ושקר
                    //אמת- ניתן להזמין בכמות המבוקשת
                    //שקר- יש חוסר במלאי עבור הכמות המבוקשת
                    a.Add(check);
                    //אם הערך המתקבל הוא אמת- ניתן להזמין בכמות המבוקשת
                    if (check)

                        //חישוב התשלום עבור המוצר * כמות 
                        sum += item.TotalPrice;


                }
                //הגדרת מופע מסוג קנייה
                ShoppingTable s = new ShoppingTable();
                //השמה ידנית של פרטי הקניה
                s.UserId = id;
                s.ShoppingDate = DateTime.Now;
                s.ShoppingSum = sum;
                //הוספת הקנייה למערכת
                var sh = _shoppingDAL.AddShopping(s);
                //אם הוספת הקנייה התבצעה בהצלחה- מילוי פרטי קנייה
                if (sh == "Succeeded!")
                {
                    //מעבר על כל מוצר ברשימה המכילה ערכי אמת ושקר- אם ניתן להזמין את המוצר
                    foreach (var item in c)
                    {
                        int i = 0;
                        //אם ניתן להזמין את המוצר- יש את הכמות המבוקשת במלאי
                        if (a[i] == true)
                        {
                            //יצירת מופע מסוג פרטי קנייה
                            ShoppingInformationTable shoppingItem = new ShoppingInformationTable();
                            //השמה ידנית של פרטי קנייה 
                            shoppingItem.ShoppingId = s.ShoppingId; //קוד קנייה
                            shoppingItem.ShoppingAmount = item.Qty; //כמות
                            shoppingItem.MachineId = item.ProductId; //קוד מוצר
                            //הוספת פרטי קנייה למערכת
                            _shoppingInformationDAL.AddShoppingItem(shoppingItem);
                        }
                        i++;
                    }
                }
                return a;
            }
            catch
            {
                return a;
            }
        }
    }

  
}
