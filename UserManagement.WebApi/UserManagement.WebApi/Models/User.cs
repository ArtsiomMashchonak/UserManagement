using System;

namespace UserManagement.WebApi.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Company { get; set; }
    }
}
