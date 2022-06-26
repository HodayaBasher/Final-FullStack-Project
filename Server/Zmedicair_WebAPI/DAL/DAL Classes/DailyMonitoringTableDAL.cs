using DAL.DAL_Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class DailyMonitoringTableDAL:IDailyMonitoringTableDAL
    {
        Zmedicair_DBContext _DB;
        public DailyMonitoringTableDAL(Zmedicair_DBContext _db)
        {
            _DB = _db;

        }

        public List<DailyMonitoringTable> getAllDailyMonitoringTables()
        {
            return _DB.DailyMonitoringTables.ToList();
        }
    }
}
