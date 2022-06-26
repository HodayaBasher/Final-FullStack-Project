using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;

namespace DAL.DAL_Interfaces
{
    public interface IDailyMonitoringTableDAL
    {
        List<DailyMonitoringTable> getAllDailyMonitoringTables();
    }
}
