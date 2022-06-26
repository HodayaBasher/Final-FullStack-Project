using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL.BLL_Interfaces
{
    public interface IMessagesTableBLL
    {
        List<MessagesTableDTO> GetAllMessages();
    }
}
