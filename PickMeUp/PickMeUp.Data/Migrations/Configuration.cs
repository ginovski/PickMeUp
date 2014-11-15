namespace PickMeUp.Data.Migrations
{
    using PickMeUp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PickMeUpDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        private List<City> SeedCities(PickMeUpDbContext context)
        {
            var cities = new List<City>();
            var cityNames = new List<string>
                                {
                                    "Sofia", "Plovdiv", "Varna", "Burgas", "Ruse", "Stara Zagora", "Pleven", "Sliven", "Dobrich",
                                    "Pernik", "Shumen", "Haskovo", "Yambol", "Pazardzhik", "Blagoevgrad", "Veliko Tarnovo", "Vratsa",
                                    "Gabrovo", "Asenovgrad", "Vidin", "Kazanlak", "Kyustendil", "Kardzhali", "Montana", "Dimitrovgrad",
                                    "Targovishte", "Lovech", "Silistra", "Dupnitsa", "Svishtov", "Razgrad", "Gorna Oryahovitsa",
                                    "Smolyan", "Petrich", "Sandanski", "Samokov", "Sevlievo", "Lom", "Karlovo", "Velingrad",
                                    "Nova Zagora", "Troyan", "Aytos", "Botevgrad", "Gotse Delchev", "Peshtera", "Harmanli",
                                    "Karnobat", "Svilengrad", "Panagyurishte", "Chirpan", "Popovo", "Rakovski", "Radomir",
                                    "Novi Iskar", "Kozloduy", "Parvomay", "Berkovitsa", "Cherven Bryag", "Pomorie", "Ihtiman",
                                    "Radnevo", "Provadiya", "Novi Pazar", "Razlog", "Byala Slatina", "Nesebar", "Balchik", "Kostinbrod",
                                    "Stamboliyski", "Kavarna", "Knezha", "Pavlikeni", "Mezdra", "Etropole", "Levski", "Teteven",
                                    "Elhovo", "Bankya", "Tryavna", "Lukovit", "Tutrakan", "Sredets", "Sopot", "Byala", "Veliki Preslav",
                                    "Isperih", "Belene", "Omurtag", "Bansko", "Krichim", "Galabovo", "Devnya", "Septemvri", "Rakitovo",
                                    "Lyaskovets", "Svoge", "Aksakovo", "Kubrat", "Dryanovo", "Beloslav", "Pirdop", "Lyubimets",
                                    "Momchilgrad", "Slivnitsa", "Hisarya", "Zlatograd", "Kostenets", "Devin", "General Toshevo",
                                    "Simeonovgrad", "Simitli", "Elin Pelin", "Dolni Chiflik", "Tervel", "Dulovo", "Varshets", "Kotel",
                                    "Madan", "Straldzha", "Saedinenie", "Bobov Dol", "Tsarevo", "Kuklen", "Tvarditsa", "Yakoruda",
                                    "Elena", "Topolovgrad", "Bozhurishte", "Chepelare", "Oryahovo", "Sozopol", "Belogradchik",
                                    "Perushtitsa", "Zlatitsa", "Strazhitsa", "Krumovgrad", "Kameno", "Dalgopol", "Vetovo", "Suvorovo",
                                    "Dolni Dabnik", "Dolna Banya", "Pravets", "Nedelino", "Polski Trambesh", "Trastenik", "Bratsigovo",
                                    "Koynare", "Godech", "Slavyanovo", "Dve Mogili", "Kostandovo", "Debelets", "Strelcha",
                                    "Sapareva Banya", "Ignatievo", "Smyadovo", "Breznik", "Sveti Vlas", "Nikopol", "Shivachevo", "Belovo",
                                    "Tsar Kaloyan", "Ivaylovgrad", "Valchedram", "Marten", "Glodzhevo", "Sarnitsa", "Letnitsa",
                                    "Varbitsa", "Iskar", "Ardino", "Shabla", "Rudozem", "Vetren", "Kresna", "Banya", "Batak", "Maglizh",
                                    "Valchi Dol", "Gulyantsi", "Dragoman", "Zavet", "Kran", "Miziya", "Primorsko", "Sungurlare",
                                    "Dolna Mitropoliya", "Krivodol", "Kula", "Kalofer", "Slivo Pole", "Kaspichan", "Apriltsi", "Belitsa",
                                    "Roman", "Dzhebel", "Dolna Oryahovitsa", "Buhovo", "Gurkovo", "Pavel Banya", "Nikolaevo", "Yablanitsa",
                                    "Kableshkovo", "Opaka", "Rila", "Ugarchin", "Dunavtsi", "Dobrinishte", "Hadzhidimovo", "Bregovo",
                                    "Byala Cherkva", "Zlataritsa", "Kocherinovo", "Dospat", "Tran", "Sadovo", "Laki", "Koprivshtitsa",
                                    "Malko Tarnovo", "Loznitsa", "Obzor", "Kilifarevo", "Borovo", "Batanovtsi", "Chernomorets", "Aheloy",
                                    "Pordim", "Suhindol", "Merichleri", "Glavinitsa", "Chiprovtsi", "Kermen", "Brezovo", "Plachkovtsi",
                                    "Zemen", "Balgarovo", "Alfatar", "Boychinovtsi", "Gramada", "Senovo", "Momin Prohod", "Kaolinovo",
                                    "Shipka", "Antonovo", "Ahtopol", "Boboshevo", "Bolyarovo", "Brusartsi", "Klisura", "Dimovo", "Kiten",
                                    "Pliska", "Madzharovo", "Melnik"
                                };

            foreach (var cityName in cityNames)
            {
                var city = new City { Name = cityName };
                context.Cities.Add(city);

                cities.Add(city);
            }

            return cities;
        }

        protected override void Seed(PickMeUpDbContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            var cities = this.SeedCities(context);

            context.SaveChanges();
        }
    }
}
