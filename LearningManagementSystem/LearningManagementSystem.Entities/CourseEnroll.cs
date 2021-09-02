using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Entities
{
    class CourseEnroll
    {
        public int EnrollId { get; set; }
        public int UsserId { get; set; }
        public int CourseId { get; set; }
        public DateTime DateOfEnrollment { get; set; }
        public DateTime DateOfCompletion { get; set; }
        public bool CourseStatus { get; set; }
        public int Result { get; set; }
    }
}
