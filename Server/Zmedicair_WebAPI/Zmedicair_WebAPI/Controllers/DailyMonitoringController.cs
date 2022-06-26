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
    public class DailyMonitoringController : Controller
    {
        IDailyMonitoringTableBLL _IDailyBLL;
        public DailyMonitoringController(IDailyMonitoringTableBLL _IDailyBLL)
        {
            this._IDailyBLL = _IDailyBLL;
        }



        //GetAllDailyMonitoring

        [HttpGet("GetAllDailyMonitoring")]
        public IActionResult GetAllDailyMonitoring()
        {
            return Ok(_IDailyBLL.getAllDailyMonitoringTables());
        }

    }
}
