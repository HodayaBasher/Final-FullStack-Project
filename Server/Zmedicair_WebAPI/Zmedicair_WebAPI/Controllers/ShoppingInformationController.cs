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
    public class ShoppingInformationController : Controller
    {
        IShoppingInformationTableBLL _IShoppingInformationBLL;
        public ShoppingInformationController(IShoppingInformationTableBLL _IShoppingInformationBLL)
        {
            this._IShoppingInformationBLL = _IShoppingInformationBLL;
        }



        //GetShoppingInformation

        [HttpGet("GetShoppingInformation")]
        public IActionResult GetAllMessages()
        {
            return Ok(_IShoppingInformationBLL.getAllShoppingInformation());
        }

    }
}
