using System;

namespace LearningManagementSystem.Entities
{
    public class User
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
