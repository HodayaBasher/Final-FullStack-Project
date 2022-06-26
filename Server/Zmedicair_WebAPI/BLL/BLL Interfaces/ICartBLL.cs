using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BLL.BLL_Interfaces
{
    interface ICartBLL
    {
        List<bool> AddToCart(short id, List<CartDTO> c);
    }
}
