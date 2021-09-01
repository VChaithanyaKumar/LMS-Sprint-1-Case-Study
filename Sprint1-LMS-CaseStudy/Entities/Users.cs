using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1_LMS_CaseStudy.Entities
{
    class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        private string UserPassword { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public char Gender { get; set; }
        public string UserEmail { get; set; }
        public string Address { get; set; }

    }
}
