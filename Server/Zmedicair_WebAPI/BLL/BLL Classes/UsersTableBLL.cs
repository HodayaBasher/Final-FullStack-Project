using System;
using System.Collections.Generic;
using System.Text;
using BLL.BLL_Interfaces;
using DAL.DAL_Interfaces;
using AutoMapper;
using DTO;
using DAL.Models;


namespace BLL.BLL_Classes
{
    public class UsersTableBLL:IUsersTableBLL
    {
        IUsersTableDAL _usersTableDAL;
        IMapper _imapper;
        public UsersTableBLL(IUsersTableDAL _usersTableDAL)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();
            });
            _imapper = config.CreateMapper();
            this._usersTableDAL = _usersTableDAL;
        }
        //
        public List<UsersTableDTO> getAllUsers()
        {
            List<UsersTable> listgetAllUsersTableToMap = _usersTableDAL.getAllUsers();
            return _imapper.Map<List<UsersTable>, List<UsersTableDTO>>(listgetAllUsersTableToMap);
        }

        //הוספת לקוח חדש
        public List<UsersTableDTO> AddUser(UsersTableDTO c)
        {
            UsersTable userMap = _imapper.Map<UsersTableDTO, UsersTable>(c);
            try
            {
                _usersTableDAL.AddUser(userMap);
                return getAllUsers();
            }
            catch
            {
                return getAllUsers();
            }
        }

        //בדיקה האם לקוח קיים לפי שם וסיסמה
        public UsersTableDTO GetUserByNameAndPassword(string Name, string Password)
        {
            UsersTable c = _usersTableDAL.GetUserByNameAndPassword(Name, Password);
            return _imapper.Map<UsersTable, UsersTableDTO>(c);
        }
    }
}
