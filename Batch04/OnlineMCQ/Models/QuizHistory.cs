using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineMCQ.Models
{
    public class QuizHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuizTopicId { get; set; }
        public double Score { get; set; }
        public DateTime Date { get; set; }
        public int TimeConsumed { get; set; }

        [ForeignKey("QuizTopicId")]
        public virtual QuizTopic QuizTopic { get; set; }
    }
}