using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.WebApi.Interfaces;
using UserManagement.WebApi.Models;

namespace UserManagement.WebApi.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly List<User> _users = new List<User>
        {
            new User { Name = "Michael", Surname = "Carleone", BirthDate = new DateTime(1932, 07, 14), Company = "Carleone Family"},
            new User { Name = "Fredo", Surname = "Carleone", BirthDate = new DateTime(1930, 06, 15), Company = "Carleone Family"},
            new User { Name = "Sunny", Surname = "Carleone", BirthDate = new DateTime(1925, 04, 3), Company = "Carleone Family"}
        };

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await Task.Run(() => _users);
        }
    }
}
