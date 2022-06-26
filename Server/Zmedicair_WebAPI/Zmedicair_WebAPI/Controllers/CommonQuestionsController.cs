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
    public class CommonQuestionsController : Controller
    {
        ICommonQuestionsTableBLL _IcommonBLL;
        public CommonQuestionsController(ICommonQuestionsTableBLL _IcommonBLL)
        {
            this._IcommonBLL = _IcommonBLL;
        }

        //GetAllCommonQuestions

        [HttpGet("GetAllCommonQuestions")]
        public IActionResult GetAllCommonQuestions()
        {
            return Ok(_IcommonBLL.getAllCommonQuestions());
        }

       
        
    }
}
