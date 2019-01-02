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
    public class ListsController : ControllerBase
    {
        private readonly IListRepository _repo;
        public ListsController(IListRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetListItems()
        {
            var listItems = await _repo.GetListItems();

            //var listToReturn = _mapper.Map<IEnumerable<WordDto>>(vocabolary);

            return Ok(listItems);

        }

    }
}