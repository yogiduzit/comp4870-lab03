using System.Collections.Generic;
using Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Data
{
    public static class SeedData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
        }
        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>() {
            new Province() {    // 1
                ProvinceCode="BC",
                ProvinceName="British Columbia"
            },
             new Province() {    // 2
                ProvinceCode="AB",
                ProvinceName="Alberta"
            },
             new Province() {    // 3
                ProvinceCode="SK",
                ProvinceName="Saskatchewan"
            }
        };

            return provinces;
        }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 500000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 2,
                CityName = "Victoria",
                Population = 200000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 3,
                CityName = "Kelowna",
                Population = 100000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 4,
                CityName = "Calgary",
                Population = 100000,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 5,
                CityName = "Edmonton",
                Population = 100000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 6,
                CityName = "Banff",
                Population = 10000,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 7,
                CityName = "Regina",
                Population = 10000,
                ProvinceCode = "SK"
            },
            new City {
                CityId = 8,
                CityName = "Saskatoon",
                Population = 10000,
                ProvinceCode = "SK"
            },
            new City {
                CityId = 9,
                CityName = "Prince Albert",
                Population = 12345,
                ProvinceCode = "SK"
            }
        };

            return cities;
        }
    }
}
