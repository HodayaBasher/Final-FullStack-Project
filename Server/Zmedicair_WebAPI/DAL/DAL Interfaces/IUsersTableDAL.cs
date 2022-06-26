using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL.DAL_Interfaces
{
    public interface IUsersTableDAL
    {
        //שליפת רשימת כל הלקוחות
        List<UsersTable> getAllUsers();

        //הוספת לקוח חדש
        List<UsersTable> AddUser(UsersTable c);

        //בדיקה האם לקוח קיים לפי שם וסיסמה
        UsersTable GetUserByNameAndPassword(string Name, string Password);

        //מחיקת לקוח
        public UsersTable DeleteUser(short id);

        //עדכון פרטי לקוח
        public List<UsersTable> UpdateUser(UsersTable c);


    }
}
