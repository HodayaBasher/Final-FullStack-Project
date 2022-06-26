using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL_Interfaces;

namespace ZmedicairWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : Controller
    {
        IShoppingTableBLL _IShoppingBLL;
        public ShoppingController(IShoppingTableBLL _IShoppingBLL)
        {
            this._IShoppingBLL = _IShoppingBLL;
        }



        //GetAllShopping

        [HttpGet("GetAllShopping")]
        public IActionResult GetAllShopping()
        {
            return Ok(_IShoppingBLL.GetAllShopping());
        }

    }
}
