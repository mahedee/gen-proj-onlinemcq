using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineMCQ.Models
{
    public class OnlineMCQContext : IdentityDbContext<ApplicationUser>
    {
        public OnlineMCQContext() : base("name=DefaultConnection")
        {
        }
        public DbSet<QuizCatagory> Catagory { get; set; }
        public DbSet<QuizTopic> Topic { get; set; }
        public DbSet<QuizQuestion> Question { get; set; }
        public DbSet<QuizAnswers> Answers { get; set; }
        public DbSet<QuizHistory> History { get; set; }

    }
}