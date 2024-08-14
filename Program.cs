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
        Console.WriteLine("==============Butun kayitli filmler============");
        foreach (Film newFilm in films)
        {
            Console.WriteLine(newFilm.Ad+", IMBD Puani= "+newFilm.Puan);
        }
        Console.WriteLine("============Film adi 'A' karakteriyle baslayanlar==============");
        foreach(Film newFilm in films)
        {
            char firstLetter = newFilm.Ad[0];
            if(firstLetter=='A')
            {
                Console.WriteLine(newFilm.Ad + ", IMBD Puani= " + newFilm.Puan);
            }
        }
        Console.WriteLine("===========Puani dort ile dokuz arasinda olanlar.====================");
        foreach (Film newFilm in films)
        {
            if(newFilm.Puan<=9&&newFilm.Puan>=4)
            {
                Console.WriteLine(newFilm.Ad + ", IMBD Puani= " + newFilm.Puan);
                loop = false;
            }
        }

    }
}
