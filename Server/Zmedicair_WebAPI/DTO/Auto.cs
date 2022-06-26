using System;
using System.Collections.Generic;
using System.Text;
using DAL.Models;
using DTO;
using AutoMapper;

namespace DTO
{
    public class Auto : AutoMapper.Profile
    {
        public Auto()
        {
            CreateMap<CommonQuestionsTable, CommonQuestionsTableDTO>();
            CreateMap<CommonQuestionsTableDTO, CommonQuestionsTable>();

            CreateMap<DailyMonitoringTable, DailyMonitoringTableDTO>();
            CreateMap<DailyMonitoringTableDTO, DailyMonitoringTable>();

            CreateMap<MachinesTables, MachinesTableDTO>();
            CreateMap<MachinesTableDTO, MachinesTables>();

            CreateMap<MessagesTable, MessagesTableDTO>();
            CreateMap<MessagesTableDTO, MessagesTable>();

            CreateMap<ShoppingInformationTable, ShoppingInformationTableDTO>();
            CreateMap<ShoppingInformationTableDTO, ShoppingInformationTable>();

            CreateMap<ShoppingTable, ShoppingTableDTO>();
            CreateMap<ShoppingTableDTO, ShoppingTable>();

            CreateMap<UsersTable, UsersTableDTO>();
            CreateMap<UsersTableDTO, UsersTable>();
        }

      
    }
}
