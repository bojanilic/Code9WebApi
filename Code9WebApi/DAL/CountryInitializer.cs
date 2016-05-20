using System.Collections.Generic;
using System.Data.Entity;
using Code9WebApi.Models;

namespace Code9WebApi.DAL
{
    public class CountryInitializer : DropCreateDatabaseAlways<CountryContext>
    {
        protected override void Seed(CountryContext context)
        {
            var countries = new List<Country>
            {
                new Country
                {
                    Name = "Serbia",
                    Area = 77474,
                    Currency = "Serbian dinar",
                    ShortName = "RS"
                },
                new Country
                {
                    Name = "Brasil",
                    Area = 8515767d,
                    Currency = "real",
                    ShortName = "BR"
                },
                new Country
                {
                    Name = "Japan",
                    Area = 377972.28,
                    Currency = "Yen",
                    ShortName = "JP"
                }
            };
            countries.ForEach(country => context.Countries.Add(country));
            context.SaveChanges();
        }
    }
}