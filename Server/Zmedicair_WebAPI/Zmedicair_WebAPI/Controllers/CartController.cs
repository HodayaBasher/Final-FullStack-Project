using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using BLL;

namespace ZmedicairWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CartController : Controller
    {
        //הגדרת מופע מסוג ממשק סל קניות
        CartBLL _cartBLL;
        //הזרקת תלויות
        public CartController(CartBLL _cartBLL)
        {
            this._cartBLL = _cartBLL ?? throw new ArgumentNullException(nameof(_cartBLL));
        }

        //הוספת מוצר לסל
        [HttpPost("AddToCart/{id}")]
        public IActionResult AddToCart(short id, [FromBody] List<CartDTO> c)
        {
            return Ok(_cartBLL.AddToCart(id, c));
        }
    }

}
