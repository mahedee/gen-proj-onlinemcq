using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineMCQ.Models
{
    public class QuizCatagory
    {
        public int Id { get; set; }
        public string QuizCatagoryName { get; set; }
        public ICollection<QuizTopic> QuizTopic { get; set; }
    }
}