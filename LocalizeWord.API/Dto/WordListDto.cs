using System;
using System.Collections.Generic;

namespace LocalizeWord.API.Dto
{
    public class WordListDto
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public int LanguageId { get; set; }
        public string LanguageKey { get; set; }
        public string LanguageCaption { get; set; }
        public int CategoryId { get; set; }
        public string CategoryKey { get; set; }
        public string CategoryCaption { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }        
        public ICollection<WordDto> NativeWords { get; set; }
    }
}