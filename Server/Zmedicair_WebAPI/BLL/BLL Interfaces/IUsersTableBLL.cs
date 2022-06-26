using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL.BLL_Interfaces
{
    public interface IUsersTableBLL
    {
        //שליפת כל המשתמשים
        List<UsersTableDTO> getAllUsers();

        //הוספת לקוח חדש
        List<UsersTableDTO> AddUser(UsersTableDTO c);

        //בדיקה האם לקוח קיים לפי שם וסיסמה
        UsersTableDTO GetUserByNameAndPassword(string Name, string Password);
    }
}
