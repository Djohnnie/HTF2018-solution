using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HTF2018.Solution.Model;

namespace HTF2018.Solution.Logic
{
    public class Challenge03 : IChallenge
    {
        public List<Value> Solve(List<Value> inputValues)
        {
            var result = "";

            char[] chars =
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
                'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
                'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };

            foreach (var c in inputValues[0].Data)
            {
                if (c != ' ')
                {
                    var pos = Array.FindIndex(chars, x => x == c);

                    var charAnswer = chars.Reverse().ToArray()[pos];

                    result += charAnswer;
                }
                else
                {
                    result += ' ';
                }
            }

            return new List<Value>
            {
                new Value {Name = "decoded", Data = $"{result}"}
            };
        }
    }
}
