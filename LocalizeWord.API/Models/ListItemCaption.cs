namespace LocalizeWord.API.Models
{
    public class ListItemCaption
    {
        public int Id { get; set; }
        public int ListItemId { get; set; }
        public string Language { get; set; }
        public string Caption { get; set; }
        public virtual ListItem ListItem { get; set; }
    }
}