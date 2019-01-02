using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalizeWord.API.Models
{
    public class ListItem
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public string ItemKey { get; set; }
        public int Oridinal { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }        
        public virtual List List { get; set; }
        public virtual ICollection<ListItemCaption> ListItemCaptions { get; set; }
    }
}