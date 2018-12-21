using System;
using HTF2018.Solution.Model;
using System.Collections.Generic;
using System.Globalization;

namespace HTF2018.Solution.Logic
{
    public class Challenge06 : IChallenge
    {
        public List<Value> Solve(List<Value> inputValues)
        {
            int result = 0;
            var startDate = DateTime.Parse(inputValues[0].Data, new CultureInfo("en-us"));
            var endDate = DateTime.Parse(inputValues[1].Data, new CultureInfo("en-us"));
            Enum.TryParse(inputValues[2].Data, out DayOfWeek theDay);

            var timeSpan = endDate - startDate;

            for (int day = 0; day <= timeSpan.TotalDays; day++)
            {
                var date = startDate.AddDays(day);

                if (date.DayOfWeek == theDay)
                {
                    result++;
                }
            }

            return new List<Value>
            {
                new Value {Name = "count", Data = $"{result}"}
            };

        }
    }
}