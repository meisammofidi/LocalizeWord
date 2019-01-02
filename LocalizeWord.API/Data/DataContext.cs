using LocalizeWord.API.Models;
using Microsoft.EntityFrameworkCore;

using System.Linq;

namespace LocalizeWord.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {  }

        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<List> Lists { get; set; }
        public DbSet<ListItem> ListItems { get; set; }
        public DbSet<ListItemCaption> ListItemCaptions { get; set; }
        public DbSet<Word> Words { get; set; }

    }
}