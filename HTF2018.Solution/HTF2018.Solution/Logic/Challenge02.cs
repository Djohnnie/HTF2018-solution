using HTF2018.Solution.Model;
using System;
using System.Collections.Generic;

namespace HTF2018.Solution.Logic
{
    public class Challenge02 : IChallenge
    {
        public List<Value> Solve(List<Value> inputValues)
        {
            int sum = 0;

            foreach (var inputValue in inputValues)
            {
                sum += Convert.ToInt32(inputValue.Data);
            }

            return new List<Value>
            {
                new Value {Name = "sum", Data = $"{sum}"}
            };
        }
    }
}