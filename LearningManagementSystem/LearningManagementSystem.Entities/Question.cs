using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Entities
{
    class Question
    {
        public int QuestionId { get; set; }
        public int QuestionDescription { get; set; }
        public int CourseId { get; set; }
    }
}
