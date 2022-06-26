using DAL.DAL_Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL_Classes
{
    public class UsersTableDAL:IUsersTableDAL
    {
        Zmedicair_DBContext _DB;
        public UsersTableDAL(Zmedicair_DBContext _db)
        {
            _DB = _db;
        }
        //שליפת כל המשתמשים
        public List<UsersTable> getAllUsers()
        {
            return _DB.UsersTables.ToList();
        }

        //הוספת לקוח חדש
        public List<UsersTable> AddUser(UsersTable c)
        {
            try
            {
                _DB.UsersTables.Add(c);
                _DB.SaveChanges();
                return getAllUsers();
            }
            catch
            {
                return getAllUsers();
            }
        }

        //מחיקת לקוח
        public UsersTable DeleteUser(short id)
        {
            var userToDelete = _DB.UsersTables.FirstOrDefault(p => p.UserId == id);
            _DB.UsersTables.Remove(userToDelete);
            _DB.SaveChanges();
            return userToDelete;
        }
        //בדיקה האם לקוח קיים לפי שם וסיסמה
        public UsersTable GetUserByNameAndPassword(string Name, string Password)
        {
            return _DB.UsersTables.FirstOrDefault(p => p.UserFirstName.Equals(Name) && p.UserPassword.Equals(Password));
        }
        //עדכון פרטי לקוח
        public List<UsersTable> UpdateUser(UsersTable c)
        {
            var userToEdit = _DB.UsersTables.FirstOrDefault(p => p.UserId == c.UserId);
            if (userToEdit != null)
            {
                userToEdit.UserFirstName = c.UserFirstName;
                userToEdit.UserLastName = c.UserLastName;
                userToEdit.UserDateOfBirth = c.UserDateOfBirth;
                userToEdit.UserEmail = c.UserEmail;
                userToEdit.UserPhoneNumber = c.UserPhoneNumber;
                userToEdit.UserStatus = c.UserStatus;
                userToEdit.UserPassword = c.UserPassword;

                _DB.SaveChanges();
                return _DB.UsersTables.ToList();
            }
            return null;
        }

      
    }
}
