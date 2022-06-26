using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL_Interfaces;
using BLL;
using DTO;

namespace ZmedicairWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        IUsersTableBLL _IUsersBLL;
        public UserController(IUsersTableBLL _IUsersBLL)
        {
            this._IUsersBLL = _IUsersBLL;
        }

        //GetAllUsers

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            return Ok(_IUsersBLL.getAllUsers());
        }


        ////הוספת לקוח חדש
        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] UsersTableDTO c)
        {
            return Ok(_IUsersBLL.AddUser(c));
        }

        //בדיקה האם לקוח קיים לפי שם וסיסמה
        [HttpGet("GetUserByNameAndPassword/{Name}/{Password}")]
        public IActionResult GetUserByNameAndPassword(string Name, string Password)
        {
            return Ok(_IUsersBLL.GetUserByNameAndPassword(Name, Password));
        }

    }
}
