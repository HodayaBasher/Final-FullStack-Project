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
    public class MessagesController : Controller
    {
        IMessagesTableBLL _IMessagesBLL;
        public MessagesController(IMessagesTableBLL _IMessagesBLL)
        {
            this._IMessagesBLL = _IMessagesBLL;
        }



        //GetAllMessages

        [HttpGet("GetAllMessages")]
        public IActionResult GetAllMessages()
        {
            return Ok(_IMessagesBLL.GetAllMessages());
        }


    }
}
