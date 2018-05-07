using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eloquera;
using Eloquera.Client;

namespace ObjectedOrientedDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "server=localhost;password=pwd;options=none;";
            const string databaseName = "Base1";
            DB db = new DB("server=(local);password=;options=none;");



            db.DeleteDatabase(databaseName, true);
            db.CreateDatabase(databaseName);
            db.OpenDatabase(databaseName);
            //Start
            Movie movie = new Movie()
            {
                Location = "Sydney",
                Year = 2010,
                OpenDates = new DateTime[] { new DateTime(2003, 12, 10), new DateTime(2003, 10, 3) }
            };

            //db.Store(movie);

            Movie movie1 = new Movie()
            {
                Location = "Drohiczyn",
                Year = 1960,
                OpenDates = new DateTime[] { new DateTime(2003, 12, 10), new DateTime(2003, 10, 3) }
            };

            //db.Store(movie1);
            ///////////

            db.Store(new Autor() { IdOsoby = 1, Imie = "Adam", Nazwisko = "Abacki", DataUr = new DateTime(2000, 1, 2) });
            db.Store(new Autor() { IdOsoby = 2, Imie = "Bartłomiej", Nazwisko = "Bartnik", DataUr = new DateTime(1991, 12, 6) });
            db.Store(new Autor() { IdOsoby = 3, Imie = "Cezary", Nazwisko = "Cudzy", DataUr = new DateTime(1960, 10, 10) });
            db.Store(new Autor() { IdOsoby = 4, Imie = "Dominik", Nazwisko = "Duszyński", DataUr = new DateTime(1941, 3, 28) });
            db.Store(new Autor() { IdOsoby = 5, Imie = "Edward", Nazwisko = "Emu", DataUr = new DateTime(1986, 6, 30) });
            db.Store(new Autor() { IdOsoby = 6, Imie = "Fiona", Nazwisko = "Firlej", DataUr = new DateTime(1968, 1, 30) });
            db.Store(new Autor() { IdOsoby = 7, Imie = "Grażyna", Nazwisko = "Górnik", DataUr = new DateTime(1999, 9, 1) });
            db.Store(new Autor() { IdOsoby = 8, Imie = "Helena", Nazwisko = "Huta", DataUr = new DateTime(1983, 1, 15) });
            db.Store(new Autor() { IdOsoby = 9, Imie = "Ireneusz", Nazwisko = "Ikszewski", DataUr = new DateTime(1979, 9, 5) });


            //OdTadRobic
            //Movie mov = (Movie)db.ExecuteScalar("Select top 1 movie from Movie WHERE Location LIKE '%Sy%'");
            //Console.WriteLine(mov.Location.ToString());

            //var output = db.ExecuteQuery("Select movie from Autor WHERE Imie LIKE '%a%'");

            var output = from Autor a in db where (a.DataUr >= new DateTime(1970, 1, 1)) select a;
            foreach (var item in output)
            {
                Console.WriteLine(item.Imie + "---" + item.Nazwisko);
            }


            //Console.WriteLine(mov.DataUr.ToString());
            //END
            db.Close();
            Console.ReadKey();
        }
    }
}

public class Movie
{
    public String Location { get; set; }
    public int Year { get; set; }
    public DateTime[] OpenDates { get; set; }
}

////////////////
public class Wypozyczajacy
{
    public int IdOsoby { get; set; }
    public int Limit { get; set; }
    public string Nazwisko { get; set; }
    public string Imie { get; set; }
    public DateTime DataUr { get; set; }
}

public class Wypozyczenie
{
    public int IdOsoby { get; set; }
    public int IdTytulu { get; set; }
    public int IdPB { get; set; }
    public DateTime DataWyp { get; set; }
    public DateTime DataZwr { get; set; }
}

public class PozycjaBiblioteczna
{
    public int IdTytulu { get; set; }
    public int IdPB { get; set; }
}

public class Tylul
{
    public int IdTytulu { get; set; }
    public int IdGatunku { get; set; }
    public int IdWydawnictwa { get; set; }
    public string Tytul { get; set; }
    public DateTime DataWydania { get; set; }
}

public class Wydawnictwo
{
    public int IdWydawnictwa { get; set; }
    public string NazwaWydawnictwa { get; set; }
}

public class Autorzy
{
    public int IdTytulu { get; set; }
    public int IdOsoby { get; set; }
}

public class Autor
{
    public int IdOsoby { get; set; }
    public string Nazwisko { get; set; }
    public string Imie { get; set; }
    public DateTime DataUr { get; set; }
}

public class Gatunek
{
    public int IdGatunku { get; set; }
    public string NazwaGatunku { get; set; }
}

