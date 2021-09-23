using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
// HttpClient Http
using WebApplication.Data;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication.Data
{
    public class ProductsService
    {
        //public static string jsonFilePath = Http.GetFromJsonAsync<IEnumerable<Products>>("products.json")
        // public static string jsonString = r.ReadToEnd();
        // public static string jsonFilePath = "products.json";
        // ReadAllText("wwwroot/Data/products.json");
        //public static string json = System.IO.File.ReadAllText("C:/Users/Toshiba/source/repos/WebApplication/WebApplication/wwwroot/Data/products.json");
        //public static string json = System.IO.File.ReadAllText("products.json");
        /*
        public ProductsService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }


        private string JsonFile
        {
            //get { return Path.Combine(WebHostEnvironment.WebRootPath, "Data", "products.json"); }
            get { return JObject o1 = JObject.Parse(File.ReadAllText(@"c:\videogames.json")); }

        }




        public IEnumerable<Products> GetProductsAsync()
        {
            using (var jsonFileReader = File.OpenText(JsonFile))
            {
                return JsonSerializer.Deserialize<IEnumerable<Products>>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true});
            }
        }*/
        public List<Products> GetProductsAsync()
        {
            using (StreamReader r = new StreamReader(@"products.json"))
            {
                string jsonFileReader = r.ReadToEnd();
                return JsonSerializer.Deserialize<List<Products>>(jsonFileReader, 
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });


            }
        }

    }
}
