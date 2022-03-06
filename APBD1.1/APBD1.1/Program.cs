using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APBD1._1
{
    class Program
    {
        public async static Task Main(string[] args)
        {
            if (args.Length < 1) throw new ArgumentNullException();
            var websiteURL = args[0];
            Console.Write(websiteURL);

            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(websiteURL);
            //Console.WriteLine(response);
            var content = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(response);

            var regex = new Regex(@"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+");

            //var a = $"Content {content}";
            //var b = @"\.-]";

            var matchCollection = regex.Matches(content);

            var set = new HashSet<string>();

            foreach (var item in matchCollection)
            {
                set.Add(item.ToString());
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}

