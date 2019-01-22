using System.Collections.Generic;
using System.Threading.Tasks;
using LocalizeWord.API.Models;

namespace LocalizeWord.API.Repository
{
    public interface IWordRepository
    {
        Task<IEnumerable<Word>> GetVocabolary();

        Task<IEnumerable<Word>> FindWords(string Term);
        Task<Word> GetWordById(int Id);
    }
}