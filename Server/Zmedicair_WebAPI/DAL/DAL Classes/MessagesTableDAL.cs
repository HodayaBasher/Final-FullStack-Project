using DAL.DAL_Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL_Classes
{
    public class MessagesTableDAL : IMessagesTableDAL
    {
       
       Zmedicair_DBContext _DB;
      public MessagesTableDAL(Zmedicair_DBContext _db)
    {
         _DB = _db;
    }

        public List<MessagesTable> GetAllMessages()
        {
            return _DB.MessagesTables.ToList();
        }
    }
}
