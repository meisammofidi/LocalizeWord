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
    public class WordsController : ControllerBase
    {
        private readonly IWordRepository _repo;
        private readonly IMapper _mapper;
        public WordsController(IWordRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetVocabolary()
        {
            var vocabolary = await _repo.GetVocabolary();

            var vocabolaryToReturn = _mapper.Map<IEnumerable<WordListDto>>(vocabolary);

            return Ok(vocabolaryToReturn);

        }

        [HttpGet("find/{term}")]
        public async Task<IActionResult> FindWords(string term)
        {
            var searchResult = await _repo.FindWords(term);

            var vocabolaryToReturn = _mapper.Map<IEnumerable<WordListDto>>(searchResult);

            return Ok(vocabolaryToReturn);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWordById(int Id)
        {
            var searchResult = await _repo.GetWordById(Id);

            var vocabolaryToReturn = _mapper.Map<WordListDto>(searchResult);

            return Ok(vocabolaryToReturn);

        }
        

    }
}