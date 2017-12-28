using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp.Data.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string QuestionSubject { get; set; }

        public string QuestionBody { get; set; }
    }
}
