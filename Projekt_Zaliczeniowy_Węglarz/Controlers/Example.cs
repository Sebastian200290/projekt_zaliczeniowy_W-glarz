using projekt_zaliczeniowy_weglarz.Models;

namespace Projekt_Zaliczeniowy_Węglarz.Controlers
{
    public static class Seed
    {
        public static List<Album> SeedData()
        {
            return new List<Album>()
            {
                new Album
                {
                    Id = 1,
                    Title = "The Dark Side of the Moon",
                    Type = DiskType.CD,
                    Duration = 43,
                    Artists = new List<string> { "Pink Floyd" },
                    Songs = new List<Song>
                    {
                        new Song
                        {
                            Number = 1,
                            Title = "Speak to Me",
                            Duration = 1,
                            Artist = new List<string> { "Pink Floyd" },
                            Composer = "Roger Waters"
                        },
                        new Song
                        {
                            Number = 2,
                            Title = "Breathe",
                            Duration = 2,
                            Artist = new List<string> { "Pink Floyd" },
                            Composer = "Roger Waters"
                        },
                        new Song
                        {
                            Number = 3,
                            Title = "On the Run",
                            Duration = 3,
                            Artist = new List<string> { "Pink Floyd" },
                            Composer = "Roger Waters"
                        },
                        new Song
                        {
                            Number = 4,
                            Title = "Time",
                            Duration = 4,
                            Artist = new List<string> { "Pink Floyd" },
                            Composer = "Roger Waters"
                        },
                    }
                },
                new Album
                {
                    Id = 2,
                    Title = "The Real Slim Shady",
                    Type = DiskType.DVD,
                    Duration = 60,
                    Artists = new List<string> { "Eminem" },
                    Songs = new List<Song>
                    {
                        new Song
                        {
                            Number = 1,
                            Title = "The Real Slim Shady",
                            Duration = 5,
                            Artist = new List<string> { "Eminem" },
                            Composer = "Marshall Mathers"
                        },
                        new Song
                        {
                            Number = 2,
                            Title = "The Way I Am",
                            Duration = 6,
                            Artist = new List<string> { "Eminem" },
                            Composer = "Marshall Mathers"
                        },
                        new Song
                        {
                            Number = 3,
                            Title = "Stan",
                            Duration = 7,
                            Artist = new List<string> { "Eminem" },
                            Composer = "Marshall Mathers"
                        },
                        new Song
                        {
                            Number = 4,
                            Title = "The Kids",
                            Duration = 8,
                            Artist = new List<string> { "Eminem" },
                            Composer = "Marshall Mathers"
                        },
                    }
                },
                new Album
                {
                    Id = 3,
                    Title = "Smerfne Hity",
                    Type = DiskType.CD,
                    Duration = 30,
                    Artists = new List<string> { "Smerfy" },
                    Songs = new List<Song>
                    {
                        new Song
                        {
                            Number = 1,
                            Title = "Smerfy",
                            Duration = 9,
                            Artist = new List<string> { "Smerfy" },
                            Composer = "Smerfne Hity"
                        },
                        new Song
                        {
                            Number = 2,
                            Title = "Smerfne Disco",
                            Duration = 10,
                            Artist = new List<string> { "Smerfy" },
                            Composer = "Smerfne Hity"
                        },
                        new Song
                        {
                            Number = 3,
                            Title = "Smerfne Tango",
                            Duration = 11,
                            Artist = new List<string> { "Smerfy" },
                            Composer = "Smerfne Hity"
                        },
                    }
                }
            };
        }
    }
}