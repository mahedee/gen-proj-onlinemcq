using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineMCQ.Models
{
    public class QuizTopic
    {
        public int Id { get; set; }
        public string QuizTopicName { get; set; }
        public int NumberOfQuestions { get; set; }
        public int QuizDuration { get; set; }
        public int DifficultyLevel { get; set; }
        public ICollection<QuizQuestion> QuizQuestion { get; set; }
        public ICollection<QuizHistory> QuizHistory { get; set; }
        public int QuizCatagoryId { get; set; }
        
        [ForeignKey("QuizCatagoryId")]
        public virtual QuizCatagory QuizCatagory { get; set; }
    }
}