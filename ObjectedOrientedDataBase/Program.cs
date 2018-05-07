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
        const string connectionString = "server=localhost;password=pwd;options=none;";
        const string databaseName = "Base1";
        public static DB db = new DB("server=(local);password=;options=none;");

        static void Main(string[] args)
        {
            //db = new DB("server=(local);password=;options=none;"); 

            db.OpenDatabase(databaseName);



            Console.ReadKey();
            db.Close();
        }

        public void AddItemsToDataBase()
        {
            db.DeleteDatabase(databaseName, true);
            db.CreateDatabase(databaseName);
            db.OpenDatabase(databaseName);
            //Start
            #region addItems
            //Autor
            db.Store(new Autor() { IdOsoby = 1, Imie = "Adam", Nazwisko = "Abacki", DataUr = new DateTime(2000, 1, 2) });
            db.Store(new Autor() { IdOsoby = 2, Imie = "Bartłomiej", Nazwisko = "Bartnik", DataUr = new DateTime(1991, 12, 6) });
            db.Store(new Autor() { IdOsoby = 3, Imie = "Cezary", Nazwisko = "Cudzy", DataUr = new DateTime(1960, 10, 10) });
            db.Store(new Autor() { IdOsoby = 4, Imie = "Dominik", Nazwisko = "Duszyński", DataUr = new DateTime(1941, 3, 28) });
            db.Store(new Autor() { IdOsoby = 5, Imie = "Edward", Nazwisko = "Emu", DataUr = new DateTime(1986, 6, 30) });
            db.Store(new Autor() { IdOsoby = 6, Imie = "Fiona", Nazwisko = "Firlej", DataUr = new DateTime(1968, 1, 30) });
            db.Store(new Autor() { IdOsoby = 7, Imie = "Grażyna", Nazwisko = "Górnik", DataUr = new DateTime(1999, 9, 1) });
            db.Store(new Autor() { IdOsoby = 8, Imie = "Helena", Nazwisko = "Huta", DataUr = new DateTime(1983, 1, 15) });
            db.Store(new Autor() { IdOsoby = 9, Imie = "Ireneusz", Nazwisko = "Ikszewski", DataUr = new DateTime(1979, 9, 5) });
            db.Store(new Autor() { IdOsoby = 10, Imie = "Jan", Nazwisko = "Jackowiak", DataUr = new DateTime(2000, 11, 12) });
            db.Store(new Autor() { IdOsoby = 11, Imie = "Karol", Nazwisko = "Kalicki", DataUr = new DateTime(2005, 5, 16) });
            db.Store(new Autor() { IdOsoby = 12, Imie = "Laura", Nazwisko = "Leonowicz", DataUr = new DateTime(1997, 1, 12) });
            db.Store(new Autor() { IdOsoby = 13, Imie = "Mateusz", Nazwisko = "Mościcki", DataUr = new DateTime(1948, 6, 8) });
            db.Store(new Autor() { IdOsoby = 14, Imie = "Natalia", Nazwisko = "Norman", DataUr = new DateTime(1983, 1, 3) });
            db.Store(new Autor() { IdOsoby = 15, Imie = "Ola", Nazwisko = "Orzeł", DataUr = new DateTime(1968, 9, 10) });
            db.Store(new Autor() { IdOsoby = 17, Imie = "Paula", Nazwisko = "Połczyńska", DataUr = new DateTime(1929, 9, 14) });
            db.Store(new Autor() { IdOsoby = 18, Imie = "Roman", Nazwisko = "Romuald", DataUr = new DateTime(1985, 11, 11) });
            db.Store(new Autor() { IdOsoby = 19, Imie = "Stanisław", Nazwisko = "Salada", DataUr = new DateTime(1949, 1, 31) });
            //Gatunek
            db.Store(new Gatunek() { IdGatunku = 1, NazwaGatunku = "Horror" });
            db.Store(new Gatunek() { IdGatunku = 2, NazwaGatunku = "Historyczny" });
            db.Store(new Gatunek() { IdGatunku = 3, NazwaGatunku = "Science Fiction" });
            db.Store(new Gatunek() { IdGatunku = 4, NazwaGatunku = "Romans" });
            db.Store(new Gatunek() { IdGatunku = 5, NazwaGatunku = "Katastroficzny" });
            db.Store(new Gatunek() { IdGatunku = 6, NazwaGatunku = "Poradnik" });
            db.Store(new Gatunek() { IdGatunku = 7, NazwaGatunku = "Naukowy" });
            //Wydawnictwo
            db.Store(new Wydawnictwo() { IdWydawnictwa = 1, NazwaWydawnictwa = "Nova" });
            db.Store(new Wydawnictwo() { IdWydawnictwa = 2, NazwaWydawnictwa = "Państwowe Wydawnictwo Naukowe" });
            db.Store(new Wydawnictwo() { IdWydawnictwa = 3, NazwaWydawnictwa = "Stara Szafa" });
            db.Store(new Wydawnictwo() { IdWydawnictwa = 4, NazwaWydawnictwa = "Nasza Drukarnia" });
            db.Store(new Wydawnictwo() { IdWydawnictwa = 5, NazwaWydawnictwa = "Sowa" });
            //Wypozyczajacy
            db.Store(new Wypozyczajacy() { IdOsoby = 1, Limit = 10, Imie = "Adrian", Nazwisko = "Pustelnik", DataUr = new DateTime(1999, 9, 9) });
            db.Store(new Wypozyczajacy() { IdOsoby = 2, Limit = 10, Imie = "Barbara", Nazwisko = "Ostrołęcka", DataUr = new DateTime(1987, 1, 2) });
            db.Store(new Wypozyczajacy() { IdOsoby = 3, Limit = 10, Imie = "Hanna", Nazwisko = "Myszyńska", DataUr = new DateTime(1991, 11, 1) });
            db.Store(new Wypozyczajacy() { IdOsoby = 4, Limit = 10, Imie = "Anna", Nazwisko = "Kalinka", DataUr = new DateTime(2000, 10, 30) });
            db.Store(new Wypozyczajacy() { IdOsoby = 5, Limit = 10, Imie = "Patryk", Nazwisko = "Niewiński", DataUr = new DateTime(2013, 2, 27) });
            db.Store(new Wypozyczajacy() { IdOsoby = 6, Limit = 10, Imie = "Łukasz", Nazwisko = "Kłosowski", DataUr = new DateTime(2004, 3, 21) });
            db.Store(new Wypozyczajacy() { IdOsoby = 7, Limit = 10, Imie = "Karol", Nazwisko = "Klepka", DataUr = new DateTime(2001, 12, 6) });
            db.Store(new Wypozyczajacy() { IdOsoby = 8, Limit = 10, Imie = "Radosław", Nazwisko = "Daleki", DataUr = new DateTime(2003, 2, 12) });
            db.Store(new Wypozyczajacy() { IdOsoby = 9, Limit = 10, Imie = "Gabriel", Nazwisko = "Siekierka", DataUr = new DateTime(2000, 1, 30) });
            db.Store(new Wypozyczajacy() { IdOsoby = 10, Limit = 50, Imie = "Maksymilian", Nazwisko = "Miernik", DataUr = new DateTime(1992, 2, 12) });
            db.Store(new Wypozyczajacy() { IdOsoby = 11, Limit = 50, Imie = "Janusz", Nazwisko = "Tracz", DataUr = new DateTime(1992, 2, 2) });
            db.Store(new Wypozyczajacy() { IdOsoby = 12, Limit = 50, Imie = "Małgorzata", Nazwisko = "Czarna", DataUr = new DateTime(1994, 9, 17) });
            db.Store(new Wypozyczajacy() { IdOsoby = 13, Limit = 50, Imie = "Anita", Nazwisko = "Wojciechowska", DataUr = new DateTime(1950, 3, 21) });
            db.Store(new Wypozyczajacy() { IdOsoby = 14, Limit = 50, Imie = "Oliwia", Nazwisko = "Noks", DataUr = new DateTime(1960, 4, 10) });
            db.Store(new Wypozyczajacy() { IdOsoby = 15, Limit = 50, Imie = "Karol", Nazwisko = "Motylewicz", DataUr = new DateTime(1979, 3, 21) });
            db.Store(new Wypozyczajacy() { IdOsoby = 16, Limit = 50, Imie = "Anita", Nazwisko = "Chmiel", DataUr = new DateTime(1998, 4, 30) });
            db.Store(new Wypozyczajacy() { IdOsoby = 17, Limit = 50, Imie = "Oktawian", Nazwisko = "Warciak", DataUr = new DateTime(1992, 1, 13) });
            db.Store(new Wypozyczajacy() { IdOsoby = 18, Limit = 50, Imie = "Romuald", Nazwisko = "Galwon", DataUr = new DateTime(1981, 7, 18) });
            db.Store(new Wypozyczajacy() { IdOsoby = 19, Limit = 10, Imie = "Maciej", Nazwisko = "Kalinka", DataUr = new DateTime(1959, 4, 13) });
            db.Store(new Wypozyczajacy() { IdOsoby = 20, Limit = 10, Imie = "Mariusz", Nazwisko = "Atamaniuk", DataUr = new DateTime(1999, 1, 7) });
            db.Store(new Wypozyczajacy() { IdOsoby = 21, Limit = 10, Imie = "Jakub", Nazwisko = "Szklisty", DataUr = new DateTime(1990, 5, 28) });
            db.Store(new Wypozyczajacy() { IdOsoby = 22, Limit = 10, Imie = "Wojciech", Nazwisko = "Ostry", DataUr = new DateTime(2001, 1, 28) });
            db.Store(new Wypozyczajacy() { IdOsoby = 23, Limit = 10, Imie = "Radosław", Nazwisko = "Korek", DataUr = new DateTime(1994, 7, 11) });
            db.Store(new Wypozyczajacy() { IdOsoby = 24, Limit = 10, Imie = "Gracjan", Nazwisko = "Rybak", DataUr = new DateTime(1979, 1, 4) });
            db.Store(new Wypozyczajacy() { IdOsoby = 25, Limit = 10, Imie = "Daniel", Nazwisko = "Don", DataUr = new DateTime(1969, 9, 19) });
            db.Store(new Wypozyczajacy() { IdOsoby = 26, Limit = 10, Imie = "Dominik", Nazwisko = "Daktyl", DataUr = new DateTime(1986, 12, 30) });
            db.Store(new Wypozyczajacy() { IdOsoby = 27, Limit = 10, Imie = "Magdalena", Nazwisko = "Boratynowicz", DataUr = new DateTime(1968, 8, 11) });
            //Tytul
            db.Store(new Tylul() { IdTytulu = 1, IdGatunku = 1, IdWydawnictwa = 1, Tytul = "W drogę", DataWydania = new DateTime(1990, 5, 28) });
            db.Store(new Tylul() { IdTytulu = 2, IdGatunku = 1, IdWydawnictwa = 2, Tytul = "Za horyzont", DataWydania = new DateTime(2001, 12, 6) });
            db.Store(new Tylul() { IdTytulu = 3, IdGatunku = 1, IdWydawnictwa = 3, Tytul = "To", DataWydania = new DateTime(1968, 9, 10) });
            db.Store(new Tylul() { IdTytulu = 4, IdGatunku = 2, IdWydawnictwa = 4, Tytul = "Sztuka wojny", DataWydania = new DateTime(2003, 2, 12) });
            db.Store(new Tylul() { IdTytulu = 5, IdGatunku = 2, IdWydawnictwa = 5, Tytul = "XIXw. w Polsce", DataWydania = new DateTime(2004, 3, 21) });
            db.Store(new Tylul() { IdTytulu = 6, IdGatunku = 2, IdWydawnictwa = 1, Tytul = "Dzieje oręża polskiego", DataWydania = new DateTime(1986, 6, 30) });
            db.Store(new Tylul() { IdTytulu = 7, IdGatunku = 3, IdWydawnictwa = 2, Tytul = "Star Fights", DataWydania = new DateTime(1992, 2, 12) });
            db.Store(new Tylul() { IdTytulu = 8, IdGatunku = 3, IdWydawnictwa = 3, Tytul = "Pewien most", DataWydania = new DateTime(1990, 5, 28) });
            db.Store(new Tylul() { IdTytulu = 9, IdGatunku = 3, IdWydawnictwa = 4, Tytul = "Przyszłość", DataWydania = new DateTime(1959, 4, 13) });
            db.Store(new Tylul() { IdTytulu = 10, IdGatunku = 4, IdWydawnictwa = 5, Tytul = "Razem", DataWydania = new DateTime(1968, 8, 11) });
            db.Store(new Tylul() { IdTytulu = 11, IdGatunku = 4, IdWydawnictwa = 1, Tytul = "Ściana", DataWydania = new DateTime(1949, 1, 31) });
            db.Store(new Tylul() { IdTytulu = 12, IdGatunku = 4, IdWydawnictwa = 2, Tytul = "On i Ona", DataWydania = new DateTime(2017, 9, 19) });
            db.Store(new Tylul() { IdTytulu = 13, IdGatunku = 5, IdWydawnictwa = 3, Tytul = "Ostatni dzień", DataWydania = new DateTime(2017, 2, 19) });
            db.Store(new Tylul() { IdTytulu = 14, IdGatunku = 5, IdWydawnictwa = 4, Tytul = "End", DataWydania = new DateTime(1994, 9, 17) });
            db.Store(new Tylul() { IdTytulu = 15, IdGatunku = 5, IdWydawnictwa = 5, Tytul = "Już czas", DataWydania = new DateTime(1929, 9, 14) });
            db.Store(new Tylul() { IdTytulu = 16, IdGatunku = 6, IdWydawnictwa = 1, Tytul = "C++ w pigułce", DataWydania = new DateTime(2004, 3, 21) });
            db.Store(new Tylul() { IdTytulu = 17, IdGatunku = 6, IdWydawnictwa = 2, Tytul = "Dlaczego C# a nie Java ?", DataWydania = new DateTime(2001, 12, 6) });
            db.Store(new Tylul() { IdTytulu = 18, IdGatunku = 6, IdWydawnictwa = 3, Tytul = "OpenGL", DataWydania = new DateTime(2004, 3, 21) });
            db.Store(new Tylul() { IdTytulu = 19, IdGatunku = 7, IdWydawnictwa = 4, Tytul = "Droga mleczna", DataWydania = new DateTime(1992, 2, 12) });
            db.Store(new Tylul() { IdTytulu = 20, IdGatunku = 7, IdWydawnictwa = 5, Tytul = "Fizyka relatiwystyczna", DataWydania = new DateTime(1991, 11, 1) });
            //Autorzy
            db.Store(new Autorzy() { IdTytulu = 1, IdOsoby = 10 });
            db.Store(new Autorzy() { IdTytulu = 2, IdOsoby = 9 });
            db.Store(new Autorzy() { IdTytulu = 3, IdOsoby = 8 });
            db.Store(new Autorzy() { IdTytulu = 4, IdOsoby = 7 });
            db.Store(new Autorzy() { IdTytulu = 5, IdOsoby = 5 });
            db.Store(new Autorzy() { IdTytulu = 6, IdOsoby = 5 });
            db.Store(new Autorzy() { IdTytulu = 7, IdOsoby = 4 });
            db.Store(new Autorzy() { IdTytulu = 8, IdOsoby = 3 });
            db.Store(new Autorzy() { IdTytulu = 9, IdOsoby = 1 });
            db.Store(new Autorzy() { IdTytulu = 10, IdOsoby = 1 });
            db.Store(new Autorzy() { IdTytulu = 11, IdOsoby = 2 });
            db.Store(new Autorzy() { IdTytulu = 12, IdOsoby = 3 });
            db.Store(new Autorzy() { IdTytulu = 13, IdOsoby = 4 });
            db.Store(new Autorzy() { IdTytulu = 14, IdOsoby = 5 });
            db.Store(new Autorzy() { IdTytulu = 15, IdOsoby = 6 });
            db.Store(new Autorzy() { IdTytulu = 16, IdOsoby = 7 });
            db.Store(new Autorzy() { IdTytulu = 17, IdOsoby = 8 });
            db.Store(new Autorzy() { IdTytulu = 18, IdOsoby = 9 });
            db.Store(new Autorzy() { IdTytulu = 19, IdOsoby = 10 });
            db.Store(new Autorzy() { IdTytulu = 20, IdOsoby = 11 });
            db.Store(new Autorzy() { IdTytulu = 21, IdOsoby = 12 });
            db.Store(new Autorzy() { IdTytulu = 22, IdOsoby = 13 });
            db.Store(new Autorzy() { IdTytulu = 23, IdOsoby = 14 });
            db.Store(new Autorzy() { IdTytulu = 24, IdOsoby = 15 });
            db.Store(new Autorzy() { IdTytulu = 25, IdOsoby = 17 });
            db.Store(new Autorzy() { IdTytulu = 26, IdOsoby = 18 });
            db.Store(new Autorzy() { IdTytulu = 27, IdOsoby = 19 });
            db.Store(new Autorzy() { IdTytulu = 28, IdOsoby = 19 });
            db.Store(new Autorzy() { IdTytulu = 29, IdOsoby = 18 });
            db.Store(new Autorzy() { IdTytulu = 30, IdOsoby = 17 });
            //PozycjaBiblioteczna
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 1, IdPB = 1 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 2, IdPB = 2 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 3, IdPB = 3 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 4, IdPB = 4 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 5, IdPB = 5 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 6, IdPB = 6 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 7, IdPB = 7 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 8, IdPB = 8 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 9, IdPB = 9 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 10, IdPB = 10 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 11, IdPB = 11 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 12, IdPB = 12 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 13, IdPB = 13 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 14, IdPB = 14 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 15, IdPB = 15 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 16, IdPB = 16 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 17, IdPB = 17 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 18, IdPB = 18 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 19, IdPB = 19 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 20, IdPB = 20 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 21, IdPB = 21 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 22, IdPB = 22 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 23, IdPB = 23 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 24, IdPB = 24 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 25, IdPB = 25 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 26, IdPB = 26 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 27, IdPB = 27 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 28, IdPB = 28 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 29, IdPB = 29 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 30, IdPB = 30 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 1, IdPB = 41 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 2, IdPB = 42 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 3, IdPB = 43 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 4, IdPB = 44 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 5, IdPB = 45 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 6, IdPB = 46 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 7, IdPB = 47 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 8, IdPB = 48 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 9, IdPB = 49 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 10, IdPB = 50 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 11, IdPB = 51 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 12, IdPB = 52 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 13, IdPB = 53 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 14, IdPB = 54 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 15, IdPB = 55 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 16, IdPB = 56 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 17, IdPB = 57 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 18, IdPB = 58 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 19, IdPB = 59 });
            db.Store(new PozycjaBiblioteczna() { IdTytulu = 20, IdPB = 60 });
            //Wypozyczenie
            db.Store(new Wypozyczenie() { IdOsoby = 1, IdTytulu = 1, IdPB = 1, DataWyp = new DateTime(2017, 8, 7), DataZwr = new DateTime(2017, 8, 18) });
            db.Store(new Wypozyczenie() { IdOsoby = 2, IdTytulu = 2, IdPB = 2, DataWyp = new DateTime(2017, 8, 7), DataZwr = new DateTime(2018, 1, 22) });
            db.Store(new Wypozyczenie() { IdOsoby = 3, IdTytulu = 3, IdPB = 3, DataWyp = new DateTime(2017, 8, 7), DataZwr = new DateTime(2018, 1, 28) });
            db.Store(new Wypozyczenie() { IdOsoby = 4, IdTytulu = 4, IdPB = 4, DataWyp = new DateTime(2017, 8, 18), DataZwr = new DateTime(2018, 1, 11) });
            db.Store(new Wypozyczenie() { IdOsoby = 5, IdTytulu = 5, IdPB = 5, DataWyp = new DateTime(2018, 1, 12), DataZwr = new DateTime(2018, 1, 12) });
            db.Store(new Wypozyczenie() { IdOsoby = 6, IdTytulu = 6, IdPB = 6, DataWyp = new DateTime(2017, 8, 18), DataZwr = new DateTime(2017, 9, 19) });
            db.Store(new Wypozyczenie() { IdOsoby = 7, IdTytulu = 7, IdPB = 7, DataWyp = new DateTime(2017, 9, 19), DataZwr = new DateTime(2018, 2, 18) });
            db.Store(new Wypozyczenie() { IdOsoby = 8, IdTytulu = 8, IdPB = 8, DataWyp = new DateTime(2017, 11, 13), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 9, IdTytulu = 9, IdPB = 9, DataWyp = new DateTime(2018, 1, 12), DataZwr = new DateTime(2018, 2, 18) });
            db.Store(new Wypozyczenie() { IdOsoby = 10, IdTytulu = 10, IdPB = 10, DataWyp = new DateTime(2017, 9, 19), DataZwr = new DateTime(2017, 12, 1) });
            db.Store(new Wypozyczenie() { IdOsoby = 11, IdTytulu = 11, IdPB = 11, DataWyp = new DateTime(2018, 2, 11), DataZwr = new DateTime(2018, 3, 11) });
            db.Store(new Wypozyczenie() { IdOsoby = 12, IdTytulu = 12, IdPB = 12, DataWyp = new DateTime(2018, 2, 12), DataZwr = new DateTime(2018, 3, 12) });
            db.Store(new Wypozyczenie() { IdOsoby = 13, IdTytulu = 13, IdPB = 13, DataWyp = new DateTime(2018, 3, 11), DataZwr = new DateTime(2018, 3, 27) });
            db.Store(new Wypozyczenie() { IdOsoby = 14, IdTytulu = 14, IdPB = 14, DataWyp = new DateTime(2018, 4, 3), DataZwr = new DateTime(2018, 4, 4) });
            db.Store(new Wypozyczenie() { IdOsoby = 15, IdTytulu = 15, IdPB = 15, DataWyp = new DateTime(2018, 4, 3), DataZwr = new DateTime(2018, 5, 1) });
            db.Store(new Wypozyczenie() { IdOsoby = 1, IdTytulu = 16, IdPB = 16, DataWyp = new DateTime(2017, 9, 11), DataZwr = new DateTime(2017, 12, 1) });
            db.Store(new Wypozyczenie() { IdOsoby = 2, IdTytulu = 17, IdPB = 17, DataWyp = new DateTime(2017, 9, 13), DataZwr = new DateTime(2018, 2, 9) });
            db.Store(new Wypozyczenie() { IdOsoby = 3, IdTytulu = 18, IdPB = 18, DataWyp = new DateTime(2017, 10, 11), DataZwr = new DateTime(2017, 12, 1) });
            db.Store(new Wypozyczenie() { IdOsoby = 4, IdTytulu = 19, IdPB = 19, DataWyp = new DateTime(2018, 4, 13), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 5, IdTytulu = 20, IdPB = 20, DataWyp = new DateTime(2018, 5, 2), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 6, IdTytulu = 21, IdPB = 21, DataWyp = new DateTime(2017, 9, 15), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 7, IdTytulu = 22, IdPB = 22, DataWyp = new DateTime(2017, 11, 13), DataZwr = new DateTime(2018, 5, 3) });
            db.Store(new Wypozyczenie() { IdOsoby = 8, IdTytulu = 23, IdPB = 23, DataWyp = new DateTime(2018, 3, 17), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 9, IdTytulu = 24, IdPB = 24, DataWyp = new DateTime(2018, 4, 3), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 10, IdTytulu = 25, IdPB = 25, DataWyp = new DateTime(2018, 5, 3), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 11, IdTytulu = 26, IdPB = 26, DataWyp = new DateTime(2017, 10, 11), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 12, IdTytulu = 27, IdPB = 27, DataWyp = new DateTime(2018, 5, 3), DataZwr = new DateTime(2018, 5, 3) });
            db.Store(new Wypozyczenie() { IdOsoby = 13, IdTytulu = 28, IdPB = 28, DataWyp = new DateTime(2018, 5, 5), DataZwr = new DateTime(2018, 2, 18) });
            db.Store(new Wypozyczenie() { IdOsoby = 14, IdTytulu = 29, IdPB = 29, DataWyp = new DateTime(2018, 3, 3), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 15, IdTytulu = 30, IdPB = 30, DataWyp = new DateTime(2017, 9, 28), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 16, IdTytulu = 1, IdPB = 41, DataWyp = new DateTime(2017, 9, 19), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 16, IdTytulu = 2, IdPB = 42, DataWyp = new DateTime(2018, 3, 1), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 16, IdTytulu = 3, IdPB = 43, DataWyp = new DateTime(2018, 4, 27), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 21, IdTytulu = 4, IdPB = 44, DataWyp = new DateTime(2017, 8, 7), DataZwr = new DateTime(2018, 5, 3) });
            db.Store(new Wypozyczenie() { IdOsoby = 21, IdTytulu = 5, IdPB = 45, DataWyp = new DateTime(2017, 8, 7), DataZwr = new DateTime(2017, 8, 18) });
            db.Store(new Wypozyczenie() { IdOsoby = 21, IdTytulu = 6, IdPB = 46, DataWyp = new DateTime(2017, 8, 7), DataZwr = new DateTime(2018, 2, 19) });
            db.Store(new Wypozyczenie() { IdOsoby = 21, IdTytulu = 7, IdPB = 47, DataWyp = new DateTime(2017, 8, 7), DataZwr = new DateTime(2017, 12, 1) });
            db.Store(new Wypozyczenie() { IdOsoby = 21, IdTytulu = 8, IdPB = 48, DataWyp = new DateTime(2017, 12, 1), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 21, IdTytulu = 9, IdPB = 49, DataWyp = new DateTime(2017, 12, 12), DataZwr = new DateTime(2018, 2, 18) });
            db.Store(new Wypozyczenie() { IdOsoby = 21, IdTytulu = 10, IdPB = 50, DataWyp = new DateTime(2017, 12, 1), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 21, IdTytulu = 11, IdPB = 51, DataWyp = new DateTime(2017, 8, 18), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 30, IdTytulu = 12, IdPB = 52, DataWyp = new DateTime(2017, 11, 11), DataZwr = new DateTime(2018, 5, 3) });
            db.Store(new Wypozyczenie() { IdOsoby = 27, IdTytulu = 13, IdPB = 53, DataWyp = new DateTime(2018, 3, 11), DataZwr = new DateTime(2018, 5, 3) });
            db.Store(new Wypozyczenie() { IdOsoby = 11, IdTytulu = 14, IdPB = 54, DataWyp = new DateTime(2017, 10, 11), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 11, IdTytulu = 15, IdPB = 55, DataWyp = new DateTime(2017, 12, 11), DataZwr = new DateTime(2018, 2, 19) });
            db.Store(new Wypozyczenie() { IdOsoby = 19, IdTytulu = 16, IdPB = 56, DataWyp = new DateTime(2017, 10, 1), DataZwr = new DateTime(2018, 2, 18) });
            db.Store(new Wypozyczenie() { IdOsoby = 19, IdTytulu = 17, IdPB = 57, DataWyp = new DateTime(2017, 10, 12), DataZwr = new DateTime(2018, 2, 11) });
            db.Store(new Wypozyczenie() { IdOsoby = 19, IdTytulu = 18, IdPB = 58, DataWyp = new DateTime(2017, 10, 25), DataZwr = DateTime.MinValue });
            db.Store(new Wypozyczenie() { IdOsoby = 1, IdTytulu = 19, IdPB = 59, DataWyp = new DateTime(2017, 11, 1), DataZwr = new DateTime(2018, 5, 3) });
            #endregion

            db.Close();
        }
    }
}

public abstract class Osoba
{
    public int IdOsoby { get; set; }
    public string Nazwisko { get; set; }
    public string Imie { get; set; }
    public DateTime DataUr { get; set; }
}

public class Wypozyczajacy : Osoba
{
    public int Limit { get; set; }
}

public class Autor : Osoba
{

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

public class Gatunek
{
    public int IdGatunku { get; set; }
    public string NazwaGatunku { get; set; }
}
