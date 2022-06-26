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
    public class ShoppingInformationTableBLL: IShoppingInformationTableBLL
    {

        IShoppingInformationTableDAL _shoppingInformationTableDAL;
        IMapper _imapper;
        public ShoppingInformationTableBLL(IShoppingInformationTableDAL _shoppingInformationTableDAL)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();
            });
            _imapper = config.CreateMapper();
            this._shoppingInformationTableDAL = _shoppingInformationTableDAL;
        }

        public List<ShoppingInformationTableDTO> getAllShoppingInformation()
        {
            List<ShoppingInformationTable> listgetAllShoppingInformationToMap = _shoppingInformationTableDAL.GetAllShoppingInformation();
            return _imapper.Map<List<ShoppingInformationTable>, List<ShoppingInformationTableDTO>>(listgetAllShoppingInformationToMap);
        }

       
    }
}

