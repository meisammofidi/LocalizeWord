using System;
using System.Collections.Generic;

namespace LocalizeWord.API.Models
{
    public class ListItem
    {
        public int Id { get; set; }
        public string ItemKey { get; set; }
        public int Oridinal { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List List { get; set; }
        public int ListId { get; set; }
        public ICollection<ListItemCaption> ListItemCaptions { get; set; }
    }
}