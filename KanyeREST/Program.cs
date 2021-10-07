using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeREST
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                QuoteRepository.kanyeQuote();

                QuoteRepository.ronQuote();

            }
        }
    }
}
