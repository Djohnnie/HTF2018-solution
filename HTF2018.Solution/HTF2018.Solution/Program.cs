using HTF2018.Solution.Logic;
using HTF2018.Solution.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HTF2018.Solution
{
    class Program
    {
        private static ChallengeSolver _solver = new ChallengeSolver();

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
                if (response.Data.Identifier == Identifier.Challenge01)
                {
                    var answer = new Answer
                    {
                        ChallengeId = response.Data.Id,
                        Values = new List<Value>
                        {
                            new Value {Name = "name", Data = "DoodPaard"},
                            new Value {Name = "secret", Data = "levendpaard!"}
                        }
                    };

                    var postRequest = new RestRequest("challenges", Method.POST);
                    postRequest.AddJsonBody(answer);
                    var postResponse = await client.ExecuteTaskAsync<Response>(postRequest);

                    if (postResponse.IsSuccessful)
                    {
                        var identification = postResponse.Data.Identification;
                        for (int i = 2; i < 20; i++)
                        {
                            var overviewType = typeof(Overview);
                            var challengePropertyName = $"Challenge{i:D2}";
                            var challengePropertyInfo = overviewType.GetProperty(challengePropertyName);
                            var progress = (Progress)challengePropertyInfo.GetValue(postResponse.Data.Overview);

                            var challengeUrl = progress.Entry.Replace("htf2018.azurewebsites.net/", "");
                            var challengeRequest = new RestRequest(challengeUrl, Method.GET);
                            challengeRequest.AddHeader("htf-identification", identification);

                            var challengeResponse = await client.ExecuteTaskAsync<Challenge>(challengeRequest);
                            if (challengeResponse.IsSuccessful)
                            {
                                var challengeAnswer = new Answer
                                {
                                    ChallengeId = challengeResponse.Data.Id,
                                    Values = _solver.Solve(challengeResponse.Data.Identifier, challengeResponse.Data.Question.InputValues)
                                };

                                var challengePostRequest = new RestRequest(challengeUrl, Method.POST);
                                challengePostRequest.AddJsonBody(challengeAnswer);
                                challengePostRequest.AddHeader("htf-identification", identification);

                                var challengePostResponse = await client.ExecuteTaskAsync<Response>(challengePostRequest);
                                if (challengePostResponse.IsSuccessful)
                                {

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}