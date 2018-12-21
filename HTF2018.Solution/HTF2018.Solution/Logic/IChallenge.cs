using HTF2018.Solution.Model;
using System.Collections.Generic;

namespace HTF2018.Solution.Logic
{
    public interface IChallenge
    {
        List<Value> Solve(List<Value> inputValues);
    }
}