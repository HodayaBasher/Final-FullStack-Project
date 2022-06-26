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
    public class MachinesTableBLL:IMachinesTableBLL
    {
        IMachinesTableDAL _machinesTableDAL;
        IMapper _imapper;
        public MachinesTableBLL(IMachinesTableDAL _machinesTableDAL)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();
            });
            _imapper = config.CreateMapper();
            this._machinesTableDAL = _machinesTableDAL;
        }
        //שליפת כל המכשירים
        public List<MachinesTableDTO> GetAllMachines()
        {
            List<MachinesTables> listDailyMachinesTableToMap = _machinesTableDAL.GetAllMachines();
            return _imapper.Map<List<MachinesTables>, List<MachinesTableDTO>>(listDailyMachinesTableToMap);
        }

        //הוספת מכשיר לרשימת המכשירים
        public string AddMachine(MachinesTableDTO t)
        {
            MachinesTables MachineMap = _imapper.Map<MachinesTableDTO, MachinesTables>(t);
            try
            {
                _machinesTableDAL.AddMachine(MachineMap);
                return "Succeeded!";
            }
            catch
            {
                return "Fails!";
            }
        }

        //הסרת מכשיר מרשימת המכשירים
        public MachinesTableDTO DeleteMachine(short id)
        {
            MachinesTables x = _machinesTableDAL.DeleteMachine(id);
            return _imapper.Map<MachinesTables, MachinesTableDTO>(x);
        }

        //שליפת מכשיר לפי קוד
        public MachinesTableDTO GetMachineByID(short id)
        {
            MachinesTables x = _machinesTableDAL.GetMachineByID(id);
            return _imapper.Map<MachinesTables, MachinesTableDTO>(x);
        }



        //עידכון מוצר ברשימת המוצרים
        public List<MachinesTableDTO> UpdateMachine(MachinesTableDTO t)
        {
            MachinesTables pMap = _imapper.Map<MachinesTableDTO, MachinesTables>(t);
            List<MachinesTables> m2 = _machinesTableDAL.UpdateMachine(pMap);
            return _imapper.Map<List<MachinesTables>, List<MachinesTableDTO>>(m2);
        }
    }

}

