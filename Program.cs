using coderbyte;
bool loop = true;
List<Film> films = new List<Film>();
while(loop)
{
    Console.Write("Yeni bir film eklemek ister misiniz ? (e/h)=");
    string input = Console.ReadLine().ToLower();
    if(input=="e")
    {
        Console.WriteLine("Lutfen film adi ve puanini giriniz.");
        Console.Write("Film adi: ");
        string ad = Console.ReadLine();
        Console.Write("IMDB puani: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Film newFilm = new Film(ad,d);
        films.Add(newFilm);
    }
    else if (input=="h")
    {
        foreach(Film newFilm in films)
        {
            Console.WriteLine(newFilm.Ad+", IMBD Puani= "+newFilm.Puan);
            loop = false;
        }
    }
}
