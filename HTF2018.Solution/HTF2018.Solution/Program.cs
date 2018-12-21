using System;
using RestSharp;
using System.Threading.Tasks;
using HTF2018.Solution.Model;

namespace HTF2018.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
            Console.ReadKey();
        }

        static async Task MainAsync()
        {
            var client = new RestClient("http://htf2018.azurewebsites.net");
            var request = new RestRequest("challenges", Method.GET);

            var response = await client.ExecuteTaskAsync<Challenge>(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine(response.Data);
            }
        }
    }
}