using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Home_Test.Models;
using Microsoft.AspNetCore.Hosting;

namespace Home_Test.Services
{
    public class Stock_Markert_Service
    {
        public Stock_Markert_Service(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Stock_Market_data.json"); }
        }

        public IEnumerable<Stock_Market> Getdata()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Stock_Market[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}