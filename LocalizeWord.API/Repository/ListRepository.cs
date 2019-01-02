using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalizeWord.API.Data;
using LocalizeWord.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalizeWord.API.Repository
{
    public class ListRepository : IListRepository
    {
        private readonly DataContext _context;
        public ListRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<ListItem>> GetListItems()
        {
            var listItems = await _context.ListItems
            .Include(lic => lic.ListItemCaptions)
            .ToListAsync();

            return listItems;
        }
    }
}