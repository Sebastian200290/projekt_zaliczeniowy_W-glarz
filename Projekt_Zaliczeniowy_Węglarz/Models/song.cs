namespace projekt_zaliczeniowy_weglarz.Models
{
    public class Song
    {
        public int Number { get; set; } 
        public string Title { get; set; } 
        public int Duration { get; set; } 
        public List<string> Artist { get; set; } 
        public string Composer { get; set; } 
    }
}