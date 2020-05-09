using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagement.WebApi.Interfaces;
using UserManagement.WebApi.Models;

namespace UserManagement.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        //TODO: Investigate the possibility to use Unit of Work here
        private readonly IUsersRepository _usersRepository;

        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _usersRepository.GetAllAsync();
        }
    }
}