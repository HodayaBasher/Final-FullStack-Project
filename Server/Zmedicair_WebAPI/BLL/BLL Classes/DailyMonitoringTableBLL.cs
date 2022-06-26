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
    public class DailyMonitoringTableBLL : IDailyMonitoringTableBLL
    {
        IDailyMonitoringTableDAL _dailyMonitoringTableDAL;
        IMapper _imapper;
        public DailyMonitoringTableBLL(IDailyMonitoringTableDAL _dailyMonitoringTableDAL)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();
            });
            _imapper = config.CreateMapper();
            this._dailyMonitoringTableDAL = _dailyMonitoringTableDAL;
        }

        public List<DailyMonitoringTableDTO> getAllDailyMonitoringTables()
        {
            List<DailyMonitoringTable> listDailyMonitoringTableToMap = _dailyMonitoringTableDAL.getAllDailyMonitoringTables();
            return _imapper.Map<List<DailyMonitoringTable>, List<DailyMonitoringTableDTO>>(listDailyMonitoringTableToMap);
        }
    }
}
