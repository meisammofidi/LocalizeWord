using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LocalizeWord.API.Models
{
    public class Word
    {
        public Word()
        {
            NativeWords = new HashSet<Word>();
        }
        public int Id { get; set; }
        public Nullable<int> LoanWordId { get; set; }
        public string Context { get; set; }
        public int LanguageId { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ListItem Language { get; set; }
        public virtual ListItem Category { get; set; }
        public virtual Word LoanWord { get; set; }
        public virtual ICollection<Word> NativeWords { get; set; }
    }
}