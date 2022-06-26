using DAL.DAL_Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class CommonQuestionsTableDAL : ICommonQuestionsTableDAL
    {
        Zmedicair_DBContext _DB;
        public CommonQuestionsTableDAL(Zmedicair_DBContext _db)
        {
            _DB = _db;

        }

        public List<CommonQuestionsTable> getAllCommonQuestions()
        {
            return _DB.CommonQuestionsTables.ToList();
        }
    }
}
