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
    public class ShoppingTableBLL:IShoppingTableBLL
    {
        IShoppingTableDAL _shoppingTableDAL;
        IMapper _imapper;
        public ShoppingTableBLL(IShoppingTableDAL _shoppingTableDAL)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();
            });
            _imapper = config.CreateMapper();
            this._shoppingTableDAL = _shoppingTableDAL;
        }

        public List<ShoppingTableDTO> GetAllShopping()
        {
            List<ShoppingTable> listgetAllShoppingToMap = _shoppingTableDAL.GetAllShopping();
            return _imapper.Map<List<ShoppingTable>, List<ShoppingTableDTO>>(listgetAllShoppingToMap);
        }

        
    }
}
