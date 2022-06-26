using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CommonQuestionsTable
    {
        public short CommonQuestionsId { get; set; }
        public string CommonQuestions { get; set; }
        public string CommonAnswers { get; set; }
    }
}
