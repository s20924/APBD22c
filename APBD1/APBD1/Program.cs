using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APBD1
{
    class Program
    {
        public async static Task Main(string[] args)
        {
            var websiteURL = args[0];
            Console.Write(websiteURL);

            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(websiteURL);
            Console.WriteLine(response);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(response);

            var regex = new Regex(@".pjwstk.edu.pl");

            //var a = $"Content {content}";
            //var b = @"\.-]";

            var matchCollection = regex.Matches(content);

            foreach (var item in matchCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
