using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class MessagesTableDTO
    {
        public short MessagesId { get; set; }
        public short UserIdFromWho { get; set; }
        public short UserIdToWho { get; set; }
    }
}
