using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using MyWebApp.Models;

namespace MyWebApp
{
    public static class FileParser
    {
        public static Dictionary<string, List<string>> GetCategoriesDictionaryFromFile()
        {
            string jsonFilePath = @"./wwwroot/data/SampleData.json";
            string jsonString = File.ReadAllText(jsonFilePath);

            var categories = JsonSerializer.Deserialize<Categories>(jsonString);

            var categoriesDictionary = new Dictionary<string, List<string>>();

            if (categories != null)
            {
                categoriesDictionary.Add("HouseholdItems", categories.HouseholdItems);
                categoriesDictionary.Add("CarParts", categories.CarParts);
                categoriesDictionary.Add("Electronics", categories.Electronics);
                categoriesDictionary.Add("Clothing", categories.Clothing);
                categoriesDictionary.Add("OfficeSupplies", categories.OfficeSupplies);
            }

            foreach (var category in categoriesDictionary)
            {
                Console.WriteLine($"{category.Key}: {String.Join(", ", category.Value)}");
            }

            return categoriesDictionary;
        }
    }
}
