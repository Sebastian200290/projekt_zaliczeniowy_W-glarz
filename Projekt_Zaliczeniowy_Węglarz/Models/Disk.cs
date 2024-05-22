namespace projekt_zaliczeniowy_weglarz.Models
{
    public class Album
    {
        public int Id { get; set; } 
        public string Title { get; set; } 
        public DiskType Type { get; set; } 
        public int Duration { get; set; } 
        public List<Song> Songs { get;  set; } 
        public List<string> Artists { get; set; } 
    }
}