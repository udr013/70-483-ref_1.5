using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AggregateExceptions
{
    class Program
    {
        async static Task<string> FetchWebPage(string uri)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(uri);
            return await response.Content.ReadAsStringAsync();

        }
        static void Main(string[] args)
        {
            try
            {
                Task<string> getpage = FetchWebPage("http://google.com");
                getpage.Wait();
                Console.WriteLine(getpage.Result);
                throw new ArgumentNullException();
            }
            catch (AggregateException ag)
            {
                foreach(Exception e in ag.InnerExceptions)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}