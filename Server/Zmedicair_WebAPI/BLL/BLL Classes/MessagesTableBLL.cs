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
    public class MessagesTableBLL:IMessagesTableBLL
    {

        IMessagesTableDAL _messagesTableDAL;
            IMapper _imapper;
            public MessagesTableBLL(IMessagesTableDAL _messagesTableDAL)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<Auto>();
                });
                _imapper = config.CreateMapper();
                this._messagesTableDAL = _messagesTableDAL;
            }

            public List<MessagesTableDTO> GetAllMessages()
            {
            List<MessagesTable> listgetAllMessagesToMap = _messagesTableDAL.GetAllMessages();
            return _imapper.Map<List<MessagesTable>, List<MessagesTableDTO>>(listgetAllMessagesToMap);
        }
        }
    }

