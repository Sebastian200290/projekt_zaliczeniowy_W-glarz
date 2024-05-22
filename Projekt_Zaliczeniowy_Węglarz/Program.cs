using projekt_zaliczeniowy_weglarz.Services;

Database database = new Database();

while (true)
{
    Console.WriteLine();
Console.WriteLine("Powiedz mi, co chcesz zrobić:");
Console.WriteLine("1. Dodaj album");
Console.WriteLine("2. Wyświetl wszystkie albumy");
Console.WriteLine("3. Wyświetl szczegóły albumu");
Console.WriteLine("4. Wyświetl artystów albumu");
Console.WriteLine("5. Wyświetl szczegóły piosenki na wybranym albumie");
Console.WriteLine("6. Zapisz swoją bazę danych");
Console.WriteLine("7. Wczytaj zewnętrzną bazę danych");
Console.WriteLine("8. Zakończ");
    string option = Console.ReadLine();
    Console.WriteLine();
    switch (option)
    {
        case "1":
            database.AddAlbum();
            break;
        case "2":
            database.DisplayAlbums();
            break;
        case "3":
            Console.WriteLine("Podaj ID albumu::");
            int id = int.Parse(Console.ReadLine());
            database.DisplayAlbum(id);
            break;
        case "4":
            Console.WriteLine("Podaj ID albumu::");
            int albumID = int.Parse(Console.ReadLine());
            database.DisplayArtists(albumID);
            break;
        case "5":
            Console.WriteLine("Podaj ID albumu:");
            albumID = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj ID piosenki::");
            int songNumber = int.Parse(Console.ReadLine());
            database.DisplaySongDetails(albumID, songNumber);
            break;
        case "6":
            Console.WriteLine("Podaj nazwe pliku:");
            string fileName = Console.ReadLine();
            database.SaveDataBase(fileName);
            break;
        case "7":
            Console.WriteLine("Podaj nazwe pliku:");
            fileName = Console.ReadLine();
            database.ReadDataBase(fileName);
            break;
        case "8":
            return;
        default:
            Console.WriteLine("Zła opcja");
            break;
    }
    Console.WriteLine();
}