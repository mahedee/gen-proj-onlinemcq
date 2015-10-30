using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineMCQ.Models
{
    public class QuizAnswers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Option { get; set; }
        public bool IsCorrect { get; set; }

        [ForeignKey("QuestionId")]
        public virtual QuizQuestion QuizQuestion { get; set; }

    }
}