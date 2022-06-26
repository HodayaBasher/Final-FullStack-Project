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
   
    public class CommonQuestionsTableBLL:ICommonQuestionsTableBLL
    {
        ICommonQuestionsTableDAL _ICommonQuestions;
        IMapper _imapper;
        public CommonQuestionsTableBLL(ICommonQuestionsTableDAL _ICommonQuestions)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Auto>();
            });
            _imapper = config.CreateMapper();
            this._ICommonQuestions = _ICommonQuestions;
        }

        public List<CommonQuestionsTableDTO> getAllCommonQuestions()
        {
            List<CommonQuestionsTable> listCommonQuestionsToMap = _ICommonQuestions.getAllCommonQuestions();
            return _imapper.Map <List<CommonQuestionsTable>, List<CommonQuestionsTableDTO>>(listCommonQuestionsToMap);
        }
    }
}
