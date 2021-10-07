using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeREST
{
    public class QuoteRepository
    {
        public static void kanyeQuote()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine("--------------");
            Console.WriteLine($"So Kanye says:  '{kanyeQuote}.'");
            Console.WriteLine("--------------");

            Console.WriteLine("");

        }

        public static void ronQuote()
        {
            var client = new HttpClient();

            var swansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(swansonURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("-------------"); 
            Console.WriteLine($"Then Ron says:  {ronQuote}");
            Console.WriteLine("-------------");
            Console.WriteLine("");


        }
    }
}
