using HTF2018.Solution.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HTF2018.Solution.Logic
{
    public class Challenge04 : IChallenge
    {
        public List<Value> Solve(List<Value> inputValues)
        {
            var start = Convert.ToInt32(inputValues.Single(x => x.Name == "start").Data);
            var end = Convert.ToInt32(inputValues.Single(x => x.Name == "end").Data);

            var result = new List<Value>();

            for (int number = start; number <= end; number++)
            {
                var isPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(number); divider++)
                {
                    if (number % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result.Add(new Value { Name = "prime", Data = $"{number}" });
                }
            }

            return result;
        }
    }
}