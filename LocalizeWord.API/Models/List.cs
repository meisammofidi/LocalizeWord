using System;
using System.Collections.Generic;

namespace LocalizeWord.API.Models
{
    public class List
    {
        public int Id { get; set; }
        public string ListKey { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ListItem> ListItems { get; set; }
    }
}