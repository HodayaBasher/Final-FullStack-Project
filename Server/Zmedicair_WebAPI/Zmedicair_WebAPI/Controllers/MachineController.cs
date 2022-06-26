using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.BLL_Interfaces;
using DTO;

namespace ZmedicairWebAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : Controller
    {
        IMachinesTableBLL _IMachinesBLL;
        public MachineController(IMachinesTableBLL _IMachinesBLL)
        {
            this._IMachinesBLL = _IMachinesBLL;
        }

        //GetAllMachines

        [HttpGet("GetAllMachines")]
        public IActionResult GetAllMachines()
        {
            return Ok(_IMachinesBLL.GetAllMachines());
        }

        //הסרת מוצר מרשימת המוצרים
        [HttpDelete("DeleteMachine/{id}")]
        public IActionResult DeleteMachine(short id)
        {
            return Ok(_IMachinesBLL.DeleteMachine(id));
        }

        //עידכון מוצר ברשימת המוצרים
        [HttpPut("UpdateMachine")]
        public IActionResult UpdateMachine([FromBody] MachinesTableDTO p)
        {
            return Ok(_IMachinesBLL.UpdateMachine(p));
        }

        //הוספת מוצר לרשימת המוצרים
        [HttpPost("AddMachine")]
        public IActionResult AddMachine([FromBody] MachinesTableDTO p)
        {
            return Ok(_IMachinesBLL.AddMachine(p));
        }

        //שליפת מוצר לפי קוד
        [HttpGet("GetMachineByID/{id}")]
        public IActionResult GetMachineByID(short id)
        {
            return Ok(_IMachinesBLL.GetMachineByID(id));
        }

    }
}
