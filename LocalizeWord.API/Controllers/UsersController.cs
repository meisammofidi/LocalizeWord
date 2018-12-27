using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using LocalizeWord.API.Dto;
using LocalizeWord.API.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocalizeWord.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAppRepository _repo;
        private readonly IMapper _mapper;
        public UsersController(IAppRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _repo.GetUsers();
            var usersToReturen = _mapper.Map<IEnumerable<UserDetailsDto>>(users);

            return Ok(usersToReturen);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _repo.GetUserById(id);
            var userToReturn = _mapper.Map<UserDetailsDto>(user);

            return Ok(userToReturn);
        }
    }
}