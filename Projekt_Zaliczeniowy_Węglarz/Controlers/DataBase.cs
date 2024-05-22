
using projekt_zaliczeniowy_weglarz.Models;
using Projekt_Zaliczeniowy_Węglarz.Controlers;
using System.Text.Json;

namespace projekt_zaliczeniowy_weglarz.Services
{
    public class Database
    {
        public List<Album> Albums { get; set; } = Seed.SeedData();

        public void AddAlbum()
        {
            Console.WriteLine("Podaj tytuł albumu");
            string title = Console.ReadLine();
            Console.WriteLine("Wybierz typ  (CD/DVD):");
            string type = Console.ReadLine();
            Console.WriteLine("Podaj szcegóły :");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj nr piosenki:");
            int songCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Album album = new Album
            {
                Id = Albums.Count + 1,
                Title = title,
                Type = type == "CD" ? DiskType.CD : DiskType.DVD,
                Duration = duration,
                Songs = new List<Song>()
            };
            Albums.Add(album);
        }
        public void DisplayAlbums()
        {
            foreach (Album album in Albums)
            {
                Console.WriteLine($"{album.Id}: {album.Title}");
            }
        }
        public void DisplayAlbum(int id)
        {
            Album album = Albums.FirstOrDefault(a => a.Id == id);
            if (album == null)
            {
                Console.WriteLine("Nie znaleziono albumu");
                return;
            }
            Console.WriteLine($"Tytuł: {album.Title}");
            Console.WriteLine($"Typ: {album.Type}");
            Console.WriteLine($"Czas: {album.Duration} minutes");
            Console.WriteLine("Piosenki:");
            foreach (Song song in album.Songs)
            {
                Console.WriteLine($"- {song.Number}. {song.Title} ({song.Duration} minuty)");
            }
        }
        public void DisplayArtists(int albumID)
        {
            Album album = Albums.FirstOrDefault(a => a.Id == albumID);
            if (album == null)
            {
                Console.WriteLine("Nie znaleziono albumu ");
                return;
            }
            Console.WriteLine($"Artyści na albumie {album.Title}:");
            foreach (string artist in album.Artists)
            {
                Console.WriteLine(artist);
            }
        }
        public void DisplaySongDetails(int albumID, int songNumber)
        {
            Album album = Albums.FirstOrDefault(a => a.Id == albumID);
            if (album == null)
            {
                Console.WriteLine("Album nie znaleziony");
                return;
            }
            Song song = album.Songs.FirstOrDefault(s => s.Number == songNumber);
            if (song == null)
            {
                Console.WriteLine("Piosenka nie znaleziona");
                return;
            }
            Console.WriteLine($"Tytu;: {song.Title}");
            Console.WriteLine($"Czas: {song.Duration} minuty");
            Console.WriteLine("Artyści:");
            foreach (string artist in song.Artist)
            {
                Console.WriteLine(artist);
            }
            Console.WriteLine($"Kompozytor: {song.Composer}");
        }
        public void SaveDataBase(string fileName)
        {
            Console.WriteLine($"Zapisywanie pliku {fileName}");
            string json = JsonSerializer.Serialize(Albums);
            File.WriteAllText($"{fileName}.json", json);
            if (File.Exists($"{fileName}.json"))
            {
                Console.WriteLine("Zapis Udany");
                return;
            }
            Console.WriteLine("Błąd podczas zapisu");
        }
        public void ReadDataBase(string fileName)
        {
            if (!File.Exists($"{fileName}.json"))
            {
                Console.WriteLine("Nie znaleziono Pliku");
                return;
            }
            string json = File.ReadAllText($"{fileName}.json");
            Albums = JsonSerializer.Deserialize<List<Album>>(json);
            Console.WriteLine("Pomyślnie zapisano Plik");
        }
    }
}