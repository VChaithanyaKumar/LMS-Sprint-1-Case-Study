using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Entities
{
    class Course
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDercription { get; set; }
        public int AuthorId { get; set; }
        public string CourseOutcome { get; set; }
    }
}
