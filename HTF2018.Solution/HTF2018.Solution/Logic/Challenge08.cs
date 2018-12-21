using System;
using HTF2018.Solution.Model;
using System.Collections.Generic;
using System.Text;

namespace HTF2018.Solution.Logic
{
    public class Challenge08 : IChallenge
    {
        public List<Value> Solve(List<Value> inputValues)
        {
            int numOfBytes = inputValues[0].Data.Length / 8;
            byte[] bytes = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; ++i)
            {
                bytes[i] = Convert.ToByte(inputValues[0].Data.Substring(8 * i, 8), 2);
            }
            
            var result = Encoding.ASCII.GetString(bytes);

            return new List<Value>
            {
                new Value {Name="decoded", Data=$"{result}"}
            };
        }
    }
}