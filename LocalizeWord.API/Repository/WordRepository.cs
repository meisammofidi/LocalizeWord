using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizeWord.API.Data;
using LocalizeWord.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalizeWord.API.Repository
{
    public class WordRepository : IWordRepository
    {
        private readonly DataContext _context;
        public WordRepository(DataContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<Word>> GetVocabolary()
        {
            //To display the navigation properties, The relationships in database must Include into query
            var vocabolary = await _context.Words.Where(c => !c.LoanWordId.HasValue) //The where cluse is for to avoid native words in root, means tha to get just loan word 
            .Include(lng => lng.Language)
            .Include(lngc => lngc.Language.ListItemCaptions)
            .Include(ct => ct.Category)
            .Include(ctc => ctc.Category.ListItemCaptions)
            .Include (nw => nw.NativeWords).ThenInclude(t =>t.Language.ListItemCaptions)
            .ToListAsync();

            return vocabolary;
        }

        public async Task<IEnumerable<Word>> FindWords(string Term)
        {
            var vocabolary = await _context.Words.Where(c => !c.LoanWordId.HasValue && c.Context.Contains(Term))
            .Include(lng => lng.Language)
            .Include(lngc => lngc.Language.ListItemCaptions)
            .Include(ct => ct.Category)
            .Include(ctc => ctc.Category.ListItemCaptions)
            .Include (nw => nw.NativeWords).ThenInclude(t =>t.Language.ListItemCaptions)
            .ToListAsync();

            return vocabolary;
                        
        }

        public async Task<Word> GetWordById(int Id)
        {
             var vocabolary = await _context.Words.Where(c => c.Id == Id)
            .Include(lng => lng.Language)
            .Include(lngc => lngc.Language.ListItemCaptions)
            .Include(ct => ct.Category)
            .Include(ctc => ctc.Category.ListItemCaptions)
            .Include (nw => nw.NativeWords).ThenInclude(t =>t.Language.ListItemCaptions)
            .FirstOrDefaultAsync();

            return vocabolary;
        }
    }
}