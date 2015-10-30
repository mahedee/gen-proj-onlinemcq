using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineMCQ.Models
{
    public class QuizQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public int QuizTopicId { get; set; }
        public ICollection<QuizAnswers> QuizAnswers { get; set; }

        [ForeignKey("QuizTopicId")]
        public virtual QuizTopic QuizTopic { get; set; }
    }
}